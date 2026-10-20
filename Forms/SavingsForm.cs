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
        private readonly MainForm mainForm; // Instans av MainForm
        private readonly ITransactionService transaction; // Instans av TransactionService genom interfacet
        //private readonly FinanceService finance; // Instans av FinanceService
        private readonly SavingsService saving; // Instans av SavingsService   

        private int dailyPlayCount = 0; // Hur många gånger som användaren har spelat/dag
        private DateTime playDate = DateTime.Today; // Datumet för när användaren spelade senast

        // Konstruktor
        public SavingsForm(ITransactionService transaction, MainForm mainForm, SavingsService saving)
        {
            InitializeComponent();
            this.transaction = transaction;
            this.mainForm = mainForm;
            this.saving = saving;
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

        // Vid klick på "Spela"-knappen startas ett utmaningsspel, där användaren kan vinna eller förlora pengar. Användaren kan spela max 2 gånger/dag.
        private async void playChallangeBtn_Click(object sender, EventArgs e)
        {
            // Tittar om dagens datum ligger före datumet för senaste spelet, isåfall nollställs räknaren och datumet uppdateras
            if (DateTime.Today > playDate)
            {
                dailyPlayCount = 0; // Nollställer spelräknaren vid ny dag
                playDate = DateTime.Today; // Uppdaterar datumet för senaste spel
            }
            // Om användaren har spelat 2 gånger idag redan, visas ett "informations-meddelande", går heller inte köra vidare spelet
            if (dailyPlayCount >= 2 || !await saving.CanPlayToday())
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
            var futureSavings = saving.CalculateFutureSavings(startAmount, monthlyInvest, annualInterestRate, years);

            decimal totalDeposit = startAmount + (monthlyInvest * years * 12); // Totalt insatt belopp
            decimal totalInterest = futureSavings - totalDeposit; // Total ränta

            totalSumSavingsText.Text = $"{futureSavings:N2} kr"; // Visar det totala beloppet i labeln med två decimaler
            equityLabelText.Text = $"{totalDeposit:N2} kr";
            interestSumText.Text = $"{totalInterest:N2} kr";
            totalSavingsPanel.Visible = true; // Visar panelen med resultatet
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            playChallangeBtn.Enabled = checkBox1.Checked; // Aktiverar knappen för att kunna spela sparutmaningen

            if (checkBox1.Checked)
            {
                playChallangeBtn.BackColor = Color.Green; // Ändrar färgen på knappen
                playChallangeBtn.ForeColor = Color.Black; // Ändrar färgen på texten på knappen
            }
            else
            {
                playChallangeBtn.BackColor = Color.LightGray; // Ändrar färgen på knappen
                playChallangeBtn.ForeColor = Color.Black; // Ändrar färgen på texten på knappen
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
            anticipateSavingsPanel.Visible = false; // Döljer panelen
            totalSavingsPanel.Visible = false; // Dölj "beräknings-resultatet"
            savingsPanel.Visible = true; // Visar panelen med sparutmaningen
            openToolsSavingBtn.Visible = false; // Döljer knappen
        }

        private void openToolsSavingBtn_Click(object sender, EventArgs e)
        {
            anticipateSavingsPanel.Visible = false; // Döljer panelen
            totalSavingsPanel.Visible = false; // Dölj "beräknings-resultatet"
            savingsPanel.Visible = true; // Visar panelen med sparutmaningen
            openToolsSavingBtn.Visible = false; // Döljer knappen
        }


    }
}
