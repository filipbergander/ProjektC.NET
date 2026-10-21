using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Projekt.Models;
using Projekt.Interfaces;
using Projekt.Services;
using Projekt.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Projekt.Forms
{
    public partial class MainForm : Form
    {
        private readonly ITransactionService transaction; // Instans av TransactionService genom interfacet
        private readonly FinanceService financeService; // Instans av financeservice för att hämta in "finansvärden" till mainform
        private readonly GamingService savingsService; // Instans av savingsservice för att hämta in "sparvärden" till mainform
        private readonly UserService userService;
        private readonly BudgetMLService mlService;
        public MainForm(ITransactionService transaction)
        {
            InitializeComponent();
            this.transaction = transaction;
            this.userService = new UserService();
            this.financeService = new FinanceService(transaction);
            this.savingsService = new GamingService(transaction);
            this.mlService = mlService ?? new BudgetMLService(new SavingsGameInput());
            MainFormLoad();
        }
        // Metod som körs när formuläret laddas, hämtar in värdena från financeService och skapar diagrammet
        private async void MainFormLoad()
        {
            await InsertFinanceValues();
            await LoadDiagram();
        }
        // Öppnar formuläret TransactionForm när knappen "Transaktioner" klickas på
        private void mainFormTransactionBtn_Click(object sender, EventArgs e)
        {
            var transactionForm = new TransactionForm(transaction, this);
            OpenForm(transactionForm);
        }
        // Öppnar formuläret SavingsForm när knappen "Sparande" klickas på
        private void mainFormSavingsBtn_Click(object sender, EventArgs e)
        {
            var savingsForm = new SavingsForm(transaction, this, savingsService, financeService, mlService);
            OpenForm(savingsForm);
        }
        // Öppnar formuläret RegisterForm när knappen "Skapa ny användare" klickas på
        private void mainFormRegisterBtn_Click(object sender, EventArgs e)
        {
            var registerForm = new newUserRegisterForm(userService);
            OpenForm(registerForm);
        }
        // Öppnar formulär och döljer mainform, när sedan formuläret stängs öppnas mainform igen
        private void OpenForm(Form form)
        {
            form.FormClosed += async (s, args) =>
            {
                this.Show();
                MainFormLoad();
            };
            form.Show();
            this.Hide();
        }
        // Hämtar in värdena som metoden i financeService kalkylerat och returnerar dem i labels ínom mainform
        private async Task InsertFinanceValues()
        {
            string monthNow = DateTime.Now.ToString("MMMM", new CultureInfo("sv-SE"));
            monthNow = char.ToUpper(monthNow[0]) + monthNow.Substring(1); // Gör första bokstaven i månadens namn som versal

            // Värdena från financeservice
            var (monthBalanceSum, incomeSum, expenseSum, quantity) = await financeService.InsertFinanceValues();

            // Labels inom layoutpanel
            mainFormMonthLabel.Text = $"Totalt {monthNow}: ";
            monthValueLabel.Text = $"{monthBalanceSum:N2} kr";
            totalIncomeLabel.Text = $"+ {incomeSum:N2} kr";
            totalExpenseLabel.Text = $"- {expenseSum:N2} kr";
            monthQuantityLabel.Text = $"{quantity} st";

            // Om totala saldot för månaden är positivt -> visa värdet i grönt, annars rött
            monthValueLabel.ForeColor = monthBalanceSum >= 0 ? Color.SeaGreen : Color.Firebrick;
        }

        // Skapar ett diagram som visar största utgifter per kategorier denna månad
        private async Task LoadDiagram()
        {
            chartPanel.Controls.Clear(); // Rensar panelen innan diagrammet skapas, annars läggs diagram ovanpå varandra
            noTransactionsLabel.Visible = false; // Visar inte label
            // Hämtar in kategorierna och summan av utgifterna per kategori
            var transactionData = await financeService.GetExpensesByCategory();

            var monthNow = DateTime.Now.ToString("MMMM", new CultureInfo("sv-SE")); // Aktuell månad
            monthNow = char.ToUpper(monthNow[0]) + monthNow.Substring(1); // Gör första bokstaven i månadens namn som versal

            Chart chart = new Chart(); // Skapar diagrammet
            chart.ChartAreas.Add(new ChartArea()); // En chartarea läggs till i diagrammet
            chartPanel.Controls.Add(chart); // Lägger till diagrammet i panelen, som skapades via designer
            chart.Name = "chart1"; // Namn
            chart.Dock = DockStyle.Fill; // Diagrammet fyller hela panelen
            chartPanel.BackColor = Color.Transparent;
            chart.BorderlineColor = Color.Transparent;
            chart.Titles.Add($"{monthNow} \n Utgifter per kategori"); // Titel
            chart.Titles[0].Font = new Font("Lucida Sans", 12, FontStyle.Bold); // Font för titeln
            chart.Legends.Add(new Legend()); // Legened läggs till i diagrammet för att visa namn på kategorierna
            chart.Legends[0].Font = new Font("Lucida Sans", 11, FontStyle.Bold); // Font för legend

            chart.GetToolTipText += (sender, e) =>
            {
                if (e.HitTestResult.ChartElementType == ChartElementType.DataPoint || e.HitTestResult.ChartElementType == ChartElementType.LegendItem)
                {
                    var point = e.HitTestResult.Series.Points[e.HitTestResult.PointIndex];
                    e.Text = $"{point.AxisLabel}: {point.YValues[0]:N2} kr"; // Tooltip som visas när man hovrar över kategorierna i diagrammet
                }
            };

            var series = new Series(); // Data för diagrammet -> series
            if (transactionData == null || !transactionData.Any())
            {
                noTransactionsLabel.Visible = true; // Visar labeln för att visa att inga transaktioner finns tillagda
                return;
            }
            if (transactionData.Count() > 7)
            {
                // Om det finns fler än 7 kategorier -> Bar-diagram
                series.ChartType = SeriesChartType.Pie;
                chart.Legends[0].Enabled = true;
            }
            else
            {
                series.ChartType = SeriesChartType.Doughnut;
                chart.Legends[0].Enabled = true;
            }

            // Skriver ut varje kategori av utgifter och summa -> i diagrammet
            foreach (var category in transactionData)
            {
                series.Points.AddXY(category.Category, category.Sum);
            }
            series.IsValueShownAsLabel = false; // Visar värderna för kategorierna, Sum, i diagrammet
            series.Label = "";
            series["PieLabelStyle"] = "Disabled"; // Inaktiverar labels för pie-diagrammet
            series.LabelForeColor = Color.Black; // Färg på värderna i diagrammet
            series.Font = new Font("Lucida Sans", 10, FontStyle.Bold); // Font för värderna i diagrammet
            chart.Series.Add(series); // Lägger till series i diagrammet
        }

        public async Task RefreshDashboard()
        {
            await InsertFinanceValues();
            await LoadDiagram();
        }
    }
}
