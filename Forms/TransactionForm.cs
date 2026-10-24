using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Projekt.Services;
using Projekt.Models;
using Projekt.Forms;
using Projekt.Interfaces;

namespace Projekt.Forms
{
    public partial class TransactionForm : Form

    {
        private readonly MainForm mainForm; // Instans av mainform
        private string currentSortColumn = ""; // Vilken kolumn som är sorterad i datagriden
        private bool ascending = true; // Sorteringsordningen för kolumnerna i datagriden
        private readonly ITransactionService transaction;   // Instans av TransactionService
        private readonly TransactionService transactionn;
        private readonly QueryService queryService; // Instans av TransactionQueryService
        private List<Transaction> displayingTransactions = []; // Sparar antalet transaktioner som visas i datagriden "nu" till denna variabel
        private readonly TransactionFilter filter = new TransactionFilter(); // Instans av TransactionFilter som används för filtrering & sökning av transaktioner

        //private List<Transaction> transactions = new List<Transaction>();
        // Konstruktor som tar emot en instans av TransactionService (transaction) och sätter den till _transaction
        public TransactionForm(ITransactionService transaction, MainForm mainForm)
        {
            InitializeComponent();
            this.transaction = transaction;
            this.mainForm = mainForm;
            this.queryService = new QueryService(transaction);
            LoadTransactions(); // Hämtar in alla sparade transaktioner 
            fromDatePicker.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1); // Sätter default-värde på "från datumet" för filtrering till första dagen i månaden
        }
        // Hämtar in transaktioner sparade i databasen och visar i datagriden (listan av transaktioner)
        private async void LoadTransactions()
        {
            displayingTransactions = await transaction.GetTransactions();
            resetTransactionGrid(displayingTransactions);
            await AddFilterInfo();
            DisplayTotalTransactionsCount();
            OrderColumns();
        }
        // Känner efter ändringar i datagriden och uppdaterar "Radera" knappen beroende på om en rad är markerad eller inte
        private void transactionGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (transactionGrid.SelectedRows.Count > 0)
            {
                ModifyButton(); // Radera-knappen ändrar färg och blir enabled
            }
        }
        // Sorterar kolumnerna i datagriden när man klickar på kolumnrubriken, och lägger till en pil som visar sorteringsordningen (fallande/stigande)
        private async void transactionGrid_ColumnHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Hämtar den klickade kolumnen och dess namn
            var clickedColumn = transactionGrid.Columns[e.ColumnIndex];
            string columnName = clickedColumn.DataPropertyName;

            // Om kolumnnamnet är tomt -> gör inget
            if (string.IsNullOrEmpty(columnName))
                return;

            // Vänder på sorteringsordningen om samma kolumn klickas igen
            if (currentSortColumn == columnName)
            {
                ascending = !ascending;
            }
            else
            {
                ascending = true;
                currentSortColumn = columnName;
            }
            // Hämtar in de sorterade transaktionerna och visar dem i datagriden
            displayingTransactions = await queryService.GetSortedTransactions(displayingTransactions, columnName, ascending);
            resetTransactionGrid(displayingTransactions);

            //Återställer kolumnrubrikerna till sitt ordinarie namn varje gång vid klick, annars läggs text till på text
            foreach (DataGridViewColumn column in transactionGrid.Columns)
            {
                if (!string.IsNullOrEmpty(column.DataPropertyName))
                {
                    column.HeaderText = column.DataPropertyName switch
                    {
                        nameof(Transaction.Id) => "Id",
                        nameof(Transaction.Typ) => "Typ",
                        nameof(Transaction.Namn) => "Namn",
                        nameof(Transaction.Kategori) => "Kategori",
                        nameof(Transaction.Belopp) => "Belopp",
                        nameof(Transaction.Datum) => "Datum",
                        _ => column.DataPropertyName
                    };
                }
            }
            // Lägger till pilen som visar sorteringsordningen (fallande/stigande) på den klickade kolumnen
            var refreshedColumn = transactionGrid.Columns[e.ColumnIndex];
            refreshedColumn.HeaderText += ascending ? " ▲" : " ▼";
        }

        // Uppdaterar & återställer datagriden med transaktionerna
        private void resetTransactionGrid(List<Transaction> transaction)
        {
            transactionGrid.DataSource = null;
            transactionGrid.DataSource = transaction;
            OrderColumns();
        }

        // Ändrar muspekaren på datagridens kolumnrubriker vid hover
        private void transactionGrid_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0) // Hover på de faktiska kolumnrubrikerna (inte på celler)
            {
                transactionGrid.Cursor = Cursors.Hand; // Muspekaren -> hand
            }
            else
            {
                transactionGrid.Cursor = Cursors.Default; // Muspekaren -> standard
            }
        }

        // Går tillbaka till Mainform vid klick -> "Gå tillbaka" knapp
        private async void transactionFormReturnBtn_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            await mainForm.RefreshDashboard();
            this.Close();

        }
        // Öppnar formuläret för att lägga till en ny transaktion vid klick -> "Lägg till"
        private void AddNewTransactionBtn_Click(object sender, EventArgs e)
        {
            var addTransactionForm = new AddTransactionForm(transaction, this, queryService, mainForm, null);
            addTransactionForm.FormClosed += (s, args) =>
            {
                this.Show(); // Laddar om transaktionerna när formuläret stängs
                LoadTransactions();
            };
            addTransactionForm.Show();
            this.Hide();
        }
        // Stänger formuläret vid klick -> "Stäng" (X-knappen i windows)
        private async void btnClose_Click(object sender, EventArgs e)
        {
            await mainForm.RefreshDashboard();
            this.Close();
        }
        // Formaterar cellerna i datagriden för att visa "belopp" med röd/grön färg och +- beroende på om det är en utgift eller inkomst
        private void transactionGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Varje transaktionsrad i datagriden
            var transaction = transactionGrid.Rows[e.RowIndex].DataBoundItem as Transaction;

            // Om det inte är Belopp-kolumnen gör metoden inget..
            if (e.RowIndex < 0 || transactionGrid.Columns[e.ColumnIndex].DataPropertyName != "Belopp")
                return;

            // Ändrar beloppets färg samt +- beroende på om transaktionen är utgift/inkomst
            if (transaction?.Typ == "Utgift")
            {
                e.Value = $"-{transaction.Belopp:N2} kr";
                e.CellStyle.ForeColor = Color.Firebrick;
            }
            else
            {
                e.Value = $"+{transaction?.Belopp:N2} kr";
                e.CellStyle.ForeColor = Color.SeaGreen;
            }
            // Formateringen har gjorts
            e.FormattingApplied = true;
        }
        // Döljer id-kolumnen i datagriden och sätter en valfri ordning på resterande kolumner
        private void OrderColumns()
        {
            // Dölj Id-kolumnen
            if (transactionGrid.Columns["Id"] != null)
            {
                transactionGrid.Columns["Id"]?.Visible = false;
            }
            // Sätter ordningen i datagridens resterande kolumner
            if (transactionGrid.Columns["Datum"] != null)
            {
                transactionGrid.Columns?["Datum"]?.DisplayIndex = 0;
                transactionGrid.Columns?["Namn"]?.DisplayIndex = 1;
                transactionGrid.Columns?["Kategori"]?.DisplayIndex = 2;
                transactionGrid.Columns?["Typ"]?.DisplayIndex = 3;
                transactionGrid.Columns?["Belopp"]?.DisplayIndex = 4;
            }
        }

        // Togglar mellan att visa och dölja filterpanelen vid klick -> "Filter" knapp
        private void filterButton_Click(object sender, EventArgs e)
        {
            filterPanel.Visible = !filterPanel.Visible;
        }
        // Stänger filterpanelen vid klick -> "X" knappen inuti panelen
        private void closeFilterPanelButton_Click_1(object sender, EventArgs e)
        {
            filterPanel.Visible = false;
        }
        // Lägger till alternativ i filterpanelen för att filtrera transaktionerna i datagriden
        private async Task AddFilterInfo()
        {
            var categories = await queryService.GetCategoryValues();
            categories.Insert(0, "Alla"); // Lägger till "Alla kategorier" som första alternativ i listan

            var types = await queryService.GetTypeValues();
            types.Insert(0, "Alla"); // Lägger till "Alla typer" som första alternativ i listan
            filterCategoryListBox.DataSource = categories;
            filterTypeComboBox.DataSource = types;
        }
        // Rensar filterpanelen till default-värden vid klick -> "Rensa" knapp
        private void filterResetButton_Click(object sender, EventArgs e)
        {
            filterTypeComboBox.SelectedIndex = 0;
            for (int i = 0; i < filterCategoryListBox.Items.Count; i++)
            {
                filterCategoryListBox.SetItemChecked(i, false); // Avbockar alla kategorier
            }
            // Återställer till deafult-värden
            fromDatePicker.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            toDatePicker.Value = DateTime.Now;
            searchTransactionBox.Text = string.Empty;
            minAmountNumeric.Value = 0;
            maxAmountNumeric.Value = 100000;
            filter.sFras = null; // Sätter sökfrasen till null
            LoadTransactions(); // Hämtar in alla transaktioner igen och visar i datagriden
        }
        // Togglar kategorier vid klick på "Alla" i filterpanelens listbox
        private void filterCategoryListBox_ItemCheck_1(object sender, ItemCheckEventArgs e)
        {

            // Om man inte klickar på "Alla" kategorier -> return
            if (e.Index != 0)
                return;
            {
                BeginInvoke(() =>
                {
                    bool checkState = e.NewValue == CheckState.Checked; // true/false om "Alla" är bockad eller inte

                    for (int i = 1; i < filterCategoryListBox.Items.Count; i++) // Alla kategorier som finns
                    {
                        filterCategoryListBox.SetItemChecked(i, checkState); // Bockar/avbockar alla kategorier, beroende på om "Alla" är bockad eller inte
                    }
                });
            }
        }
        // Skriver ut antalet transaktioner som visas i datagriden
        private void DisplayTotalTransactionsCount()
        {
            var totalTransactions = transaction.GetTransactions().Result; // Alla transaktioner i databasen
            var displayingTransactions = transactionGrid.DataSource as List<Transaction>; // Hämtar in transaktionerna som visas i datagriden just nu
            totalSumTransactions.Text = $"Summa: {displayingTransactions?.Sum(t => t.Typ == "Utgift" ? -t.Belopp : t.Belopp):N2} kr"; // Visar summan av transaktionerna som visas i datagriden, t.ex vid filtrering
            // Beroende på hur många transaktioner som visas i datagriden, skrivs texten ut olika i labeln
            if (displayingTransactions?.Count >= 1)
            {
                totalTransactionsPostLabel.Text = $"Visar {displayingTransactions?.Count} av {totalTransactions.Count} transaktioner";
                totalTransactionsPostLabel.ForeColor = Color.FromArgb(64, 64, 64); // Sätter texten till svart färg om transaktioner hittades
            }
            else
            {
                totalTransactionsPostLabel.Text = "Inga transaktioner hittades";
                totalTransactionsPostLabel.ForeColor = Color.Firebrick; // Sätter texten till röd färg om inga transaktioner hittades
            }
        }
        // Visar de filtrerade transaktionerna i datagriden vid klick -> "Filtrera" knapp
        private async void filterApplyButton_Click(object sender, EventArgs e)
        {
            // Felhantering om man försöker filtrera med ett från-datum som är efter till-datumet, eller tvärtom
            if (fromDatePicker.Value > toDatePicker.Value)
            {
                MessageBox.Show("Från-datumet kan inte vara efter Till-datumet!", "Fel i filtrering", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (toDatePicker.Value < fromDatePicker.Value)
            {
                MessageBox.Show("Till-datumet kan inte vara före Från-datumet!", "Fel i filtrering", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Är min-beloppet större än max-beloppet -> felmeddelande
            if (minAmountNumeric.Value > maxAmountNumeric.Value)
            {
                MessageBox.Show("Minimum-beloppet kan inte vara större än Max-beloppet!", "Fel i filtrering", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Är max-beloppet mindre än min-beloppet -> felmeddelande
            if (maxAmountNumeric.Value < minAmountNumeric.Value)
            {
                MessageBox.Show("Max-beloppet kan inte vara mindre än Min-beloppet!", "Fel i filtrering", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Om det är under 0 som man försöker filtrera på -> felmeddelande
            if (minAmountNumeric.Value < 0 || maxAmountNumeric.Value < 0)
            {
                MessageBox.Show("Beloppet kan inte vara negativt!", "Fel i filtrering", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Hämtar in eventuella filtreringar som gjorts
            filter.Typ = filterTypeComboBox.SelectedItem?.ToString();
            filter.Kategori = filterCategoryListBox.CheckedItems.Cast<string>().ToList();
            filter.fDatum = fromDatePicker.Value.Date;
            filter.tDatum = toDatePicker.Value.Date;
            filter.minBelopp = minAmountNumeric.Value > 0 ? (float?)minAmountNumeric.Value : null; // Om minbeloppet är större än 0 -> skicka med det, annars null
            filter.maxBelopp = maxAmountNumeric.Value > 0 ? (float?)maxAmountNumeric.Value : null;
            // Skickar med de eventuella filtreringarna till queryservicen
            displayingTransactions = await queryService.FilterTransactions(filter);

            // Uppdaterar & återställer datagriden med transaktionerna
            resetTransactionGrid(displayingTransactions);
            DisplayTotalTransactionsCount(); // Uppdaterar label för antalet transaktioner som visas i datagriden
            OrderColumns();
        }
        // Hittar transaktioner i datagriden beroende på sökfras i sökfältet
        private async void searchTransactionBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchTransactionBox.Text))
            {
                filter.sFras = null; // Om sökfältet är tomt -> sätter sökfrasen till null
            }
            else
            {
                filter.sFras = searchTransactionBox.Text; // Det som skrivits in i sökfältet
            }

            displayingTransactions = await queryService.FilterTransactions(filter); // Försöker matcha transaktioner med sökfrasen i sökfältet

            resetTransactionGrid(displayingTransactions); // Uppdaterar & återställer datagriden med de sökta transaktionerna
            DisplayTotalTransactionsCount(); // Uppdaterar label för antalet transaktioner som visas i datagriden
        }

        // Tar bort en transaktion vid klick -> "Radera" knapp
        private async void deleteTransactionBtn_Click(object sender, EventArgs e)
        {
            // Är fler än noll rader markerade i datagriden -> fortsätt
            if (transactionGrid.SelectedRows.Count > 0)
            {
                var selectedRow = transactionGrid.SelectedRows[0]; // Hämtar den markerade raden i datagriden
                var selectedTransaction = selectedRow.DataBoundItem as Transaction; // Hämtar den markerade transaktionen i datagriden
                if (selectedTransaction != null)
                {
                    // Visa en bekräftelse innan användaren går vidare till att radera transaktionen
                    var result = MessageBox.Show($"Är du säker på att du vill radera transaktionen?\nMed namn '{selectedTransaction.Namn}', och beloppet '{selectedTransaction.Belopp}'?", "Bekräfta radering", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    // Om användaren klickar "Ja" -> radera transaktionen
                    if (result == DialogResult.Yes)
                    {
                        await transaction.RemoveTransaction(selectedTransaction.Id);// Radera transaktionen från databasen
                        displayingTransactions = await transaction.GetTransactions(); // Hämtar in de transaktionerna igen efter raderingen
                        resetTransactionGrid(displayingTransactions); // Uppdaterar & återställer datagriden med de inhämtade transaktionerna
                        DisplayTotalTransactionsCount(); // Visar antalet transaktioner som visas i datagriden igen
                        await DisplayNotification(deleteTransactionNotificationLabel, "Transaktionen raderades!", "ForestGreen"); // Visar en notifikation om att transaktionen raderades
                    }
                }
            }

        }
        // Gör knapparna "Radera" och "Uppdatera" inaktiva och ändrar färgen på dem
        private void DisableButton(Button button)
        {
            button.Enabled = false;
            button.ForeColor = Color.DimGray; // Grå färg
            button.BackColor = Color.LightGray; // Bakgrundsfärgen ljusgrå
        }
        // Aktiverar knapparna för "Radera" och "Uppdatera" och ändrar färgen på dem
        private void EnableButton(Button button, Color foreColor, Color backColor)
        {
            button.Enabled = true;
            button.ForeColor = foreColor;
            button.BackColor = backColor;
        }

        // Uppdaterar knapparna "Radera" och "Uppdatera" beroende på om en rad är markerad i datagriden eller inte
        private void ModifyButton()
        {
            // Om ingen rad är markerad i datagriden -> inaktivera knapparna
            if (transactionGrid.SelectedRows.Count == 0)
            {
                DisableButton(deleteTransactionBtn);
                DisableButton(updateTransactionBtn);
                return;
            }
            // Hämtar den markerade transaktionen i datagriden
            var selectedTransaction = transactionGrid.SelectedRows[0].DataBoundItem as Transaction;

            // Inaktiverar knapparna om det är en spar-transaktion som är markerad
            bool protectedTransaction = selectedTransaction?.Kategori == "Sparande" && selectedTransaction.Namn?.Contains("Spar") == true;

            // Om det inte är en spar-transaktion som är markerad -> aktivera knapparna
            if (!protectedTransaction)
            {
                EnableButton(deleteTransactionBtn, Color.Firebrick, Color.White);
                EnableButton(updateTransactionBtn, Color.Black, Color.FromArgb(141, 141, 232));
            }
            // Inaktiverar knapparna om det är en spar-transaktion som är markerad
            else
            {
                DisableButton(deleteTransactionBtn);
                DisableButton(updateTransactionBtn);
            }
        }
        // Visar en notifikation i formuläret som försvinner efter 2 sekunder
        private async Task DisplayNotification(Label label, string message, string color)
        {
            label.ForeColor = Color.FromName(color); // Sätter färgen på texten i labeln
            label.Text = message; // Meddelandet
            label.Visible = true; // Visar labeln
            await Task.Delay(1800); // Väntar i 1,8 sekunder
            label.Visible = false; // Döljer labeln igen
        }
        // Öppnar formuläret för att uppdatera en transaktion vid klick -> "Uppdatera" knapp
        private void updateTransactionBtn_Click_1(object sender, EventArgs e)
        {
            // Är fler än noll rader markerade i datagriden -> fortsätt
            if (transactionGrid.SelectedRows.Count > 0)
            {
                var selectedTransaction = transactionGrid.SelectedRows[0].DataBoundItem as Transaction; // Hämtar den markerade transaktionen i datagriden

                if (selectedTransaction != null)
                {
                    var addTransactionForm = new AddTransactionForm(transaction, this, queryService, mainForm, selectedTransaction);
                    addTransactionForm.FormClosed += (s, args) =>
                    {
                        this.Show(); // Laddar om transaktionerna när formuläret stängs
                        LoadTransactions();
                    }
                    ;
                    addTransactionForm.Show(); // Öppnar formuläret
                    this.Hide();
                }
            }
        }
        // Tillfällig funktion: Tar bort alla transaktioner som innehåller "Sparutmaning"
        /* private async void removeAllSavingsBtn_Click(object sender, EventArgs e)
         {
             await transaction.RemoveChallengeTransactions();
             LoadTransactions();
         }*/

        private void avslutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void omToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm(this);
            aboutForm.Show();
            this.Hide();
        }
    }
}
