using Projekt.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Projekt.Models;
using Projekt.Services;

namespace Projekt.Forms
{
    public partial class SavingsForm : Form
    {
        //Instanser
        private readonly MainForm mainForm;
        private readonly ITransactionService transaction;
        //private readonly FinanceService finance;
        private readonly GamingService gaming;
        private readonly FinanceService finance;

        private int dailyPlayCount = 0; // Hur många gånger som användaren har spelat/dag
        private DateTime playDate = DateTime.Today; // Datumet för när användaren spelade senast

        // Konstruktor
        public SavingsForm(ITransactionService transaction, MainForm mainForm, GamingService gaming, FinanceService finance)
        {
            InitializeComponent();
            this.transaction = transaction;
            this.mainForm = mainForm;
            this.gaming = gaming;
            this.finance = finance;
        }

        // Går tillbaka till Mainform vid klick -> "Gå tillbaka" knapp
        private void savingsFormReturnBtn_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }


        // Stänger formuläret vid klick -> "Stäng" (X-knappen i windows)
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void playChallangeBtn_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            challengePanel.Visible = true; // Visar panelen med sparutmaningen
            InsertChallengeValues(); // Hämtar in data för spelaren i sparutmaningen
        }
        // Vid klick på "Starta utmaning"-knappen startas utmaningsspelet, där användaren kan vinna eller förlora pengar. Användaren kan spela max 2 gånger/dag.
        private async void initiateChallengeBtn_Click_1(object sender, EventArgs e)
        {
            // Tittar om dagens datum ligger före datumet för senaste spelet, isåfall nollställs räknaren och datumet uppdateras
            if (DateTime.Today > playDate)
            {
                dailyPlayCount = 0; // Nollställer spelräknaren vid ny dag
                playDate = DateTime.Today; // Uppdaterar datumet för senaste spel
            }
            // Om användaren har spelat 2 gånger idag redan, visas ett "informations-meddelande", går heller inte köra vidare spelet
            if (dailyPlayCount >= 2 || !await gaming.CanPlayToday())
            {
                MessageBox.Show("Du har redan spelat 2 gånger idag. Välkommen åter imorgon!", "Begränsning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dailyPlayCount++; // Ökar spelräknaren när användaren genomfört ett spel

            Random randomNumb = new Random(); // För att kunna generera ett random-nummer
            int fee = 300; // Kostnaden för att spela

            int reward = randomNumb.Next(200, 600); // Random-nummer mellan 200 och 600
            int netWin = reward - fee; // Vinsten i sek

            string resultMsg = ""; // Nollställer meddelandet

            // Om vinsten är positiv
            if (netWin > 0)
            {
                resultMsg = $"Fantastiskt! Du gick med +{netWin} kr plus i sparutmaningen!";
                MessageBox.Show(resultMsg, "Sparutmaning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var winTransaction = new Transaction("Inkomst", "Sparutmaning (vinst)", "Sparande", (float)Math.Abs(netWin), DateTime.Today.ToString("yyyy-MM-dd"));

                await transaction.AddTransaction(winTransaction);
            }
            // Om man skulle gå +-0
            else if (netWin == 0)
            {
                resultMsg = $"Ojdå! Det blev plus minus noll({netWin} kr) i sparutmaningen!";
                MessageBox.Show(resultMsg, "Sparutmaning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var zeroTransaction = new Transaction("Inkomst", "Sparutmaning (nollresultat)", "Sparande", (float)Math.Abs(netWin), DateTime.Today.ToString("yyyy-MM-dd"));
                await transaction.AddTransaction(zeroTransaction);
            }
            else
            // Vid förlust
            {
                resultMsg = $"Det blev en förlust på {Math.Abs(netWin)} kr denna gång, vilket räknas som en utgift.";
                MessageBox.Show(resultMsg, "Sparutmaning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                var looseTransaction = new Transaction("Utgift", "Sparutmaning (förlust)", "Sparande", (float)Math.Abs(netWin), DateTime.Today.ToString("yyyy-MM-dd"));
                await transaction.AddTransaction(looseTransaction);
            }
            ShowToolsPanel();
        }
        // Vid klick på "Beräkna"-knappen räknas det totala beloppet ut som man kommer ha efter ett visst antal år, med startbelopp, avsättning per månad och årlig ränta.
        private void calculateSavingsButton_Click(object sender, EventArgs e)
        {

            // Hämtar in värdena från inputs
            decimal startAmount = startAmountNum.Value; // Startbelopp
            decimal monthlyInvest = monthlyAmountNum.Value;// Avsättning per månad
            int years = (int)savingsYearGoalNum.Value; // Antal år som man vill spara
            double annualInterestRate = (double)yearlyInterestNum.Value / 100; // Omvandlar till decimal, t.ex 6% blir 0.06

            // Skickar med värdena och får tillbaka det totala beloppet enligt formeln
            var futureSavings = finance.CalculateFutureSavings(startAmount, monthlyInvest, annualInterestRate, years);

            decimal totalDeposit = startAmount + (monthlyInvest * years * 12); // Totalt insatt belopp
            decimal totalInterest = futureSavings - totalDeposit; // Total ränta

            totalSumSavingsText.Text = $"{futureSavings:N2} kr"; // Visar det totala beloppet i labeln med två decimaler
            equityLabelText.Text = $"{totalDeposit:N2} kr";
            interestSumText.Text = $"{totalInterest:N2} kr";
            totalSavingsPanel.Visible = true; // Visar panelen med resultatet
        }
        // Känner av när användaren kryssar i checkboxen för att kunna spela sparutmaningen, aktiverar knappen för att gå vidare och ändrar färger
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            initiateChallengeBtn.Enabled = checkBox1.Checked; // Aktiverar knappen för att kunna spela sparutmaningen

            if (checkBox1.Checked)
            {
                initiateChallengeBtn.BackColor = Color.Green; // Ändrar färgen på knappen
                initiateChallengeBtn.ForeColor = Color.Black; // Ändrar färgen på texten på knappen
            }
            else
            {
                initiateChallengeBtn.BackColor = Color.LightGray; // Ändrar färgen på knappen
                initiateChallengeBtn.ForeColor = Color.Black; // Ändrar färgen på texten på knappen
            }
        }
        // Öppnar panelen för att kunna skriva in värden för beräkning av sparande
        private void anticipateSavingsBtn_Click(object sender, EventArgs e)
        {
            anticipateSavingsPanel.Visible = true; // Visar panelen
            savingsPanel.Visible = false; // Döljer den stora panelen för verktygen
            openToolsSavingBtn.Visible = true; // Visar knappen för att kunna se sparverktygen igen
        }
        // Stänger ned panelen för sparkalkylator och döljer även resultatet av beräkningen
        private void closeCalculatorPanelBtn_Click(object sender, EventArgs e)
        {
            ShowToolsPanel();
            /*
            anticipateSavingsPanel.Visible = false; // Döljer panelen
            totalSavingsPanel.Visible = false; // Dölj "beräknings-resultatet"
            savingsPanel.Visible = true; // Visar panelen med sparutmaningen
            openToolsSavingBtn.Visible = false; // Döljer knappen
            */
        }
        // Öppnar stora panelen för sparverktygen igen, döljer sparkalkylatorn
        private void openToolsSavingBtn_Click(object sender, EventArgs e)
        {
            anticipateSavingsPanel.Visible = false; // Döljer panelen
            totalSavingsPanel.Visible = false; // Dölj "beräknings-resultatet"
            savingsPanel.Visible = true; // Visar panelen med sparutmaningen
            openToolsSavingBtn.Visible = false; // Döljer knappen
        }
        // Vid klick hämtas det totala saldot från FinanceService och visas i ett meddelande
        private void displayBalanceBtn_Click(object sender, EventArgs e)
        {
            var totalBalance = finance.GetTotalBalance(); // Totala saldot
            MessageBox.Show($"Totala saldot är: {totalBalance.Result:N2} kr", "Totalt saldo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // Hämtar och visar värden för utmaningen
        private async void InsertChallengeValues()
        {
            var amountPlayedToday = await gaming.GetAmountsPlayedToday(); // Hämtar in hur många gånger spelaren spelat idag
            var playerData = await finance.GetPlayerResult(); // Hämtar in data för spelaren, största vinst och totalt resultat
            amountPlayedTodayLabel.Text = $"Spel idag: {amountPlayedToday}/2 st"; // Antal gånger spelat idag
            bestWinLabel.Text = $"Största vinsten: {playerData.LargestWin:N2} kr"; // Största vinsten
            totalResultLabel.Text = $"Totalt spelresultat: {playerData.TotalResult:N2} kr"; // Totalt resultat för spelaren, vinst minus förlust
        }
        // Vid klick på "Avbryt"-knappen i sparutmaningen, visas sparverktygen igen och sparutmaningen döljs
        private void addTransactionCancelBtn_Click(object sender, EventArgs e)
        {
            ShowToolsPanel();
        }

        private void ShowToolsPanel()
        {
            anticipateSavingsPanel.Visible = false; // Döljer panelen
            totalSavingsPanel.Visible = false; // Dölj "beräknings-resultatet"
            savingsPanel.Visible = true; // Visar panelen med sparutmaningen
            openToolsSavingBtn.Visible = false; // Döljer knappen
            panel2.Visible = true;
            panel3.Visible = true;
            challengePanel.Visible = false; // Döljer panelen med sparutmaningen
        }
    }
}
