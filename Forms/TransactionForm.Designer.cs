namespace Projekt.Forms
{
    partial class TransactionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            transactionGrid = new DataGridView();
            transactionsHeaderLabel = new Label();
            transactionFormReturnBtn = new Button();
            AddNewTransactionBtn = new Button();
            totalTransactionsPostLabel = new Label();
            filterLabel = new Label();
            filterSearchLabel = new Label();
            searchTransactionBox = new TextBox();
            filterCategoryLabel = new Label();
            filterTypeLabel = new Label();
            filterFromDateLabel = new Label();
            filterToDateLabel = new Label();
            fromDatePicker = new DateTimePicker();
            toDatePicker = new DateTimePicker();
            filterButton = new Button();
            filterPanel = new Panel();
            maxAmountNumeric = new NumericUpDown();
            maxAmountLabel = new Label();
            minAmountLabel = new Label();
            minAmountNumeric = new NumericUpDown();
            closeFilterPanelButton = new Button();
            filterCategoryListBox = new CheckedListBox();
            filterApplyButton = new Button();
            filterResetButton = new Button();
            filterTypeComboBox = new ComboBox();
            deleteTransactionBtn = new Button();
            updateTransactionBtn = new Button();
            modifyTransactionsLabel = new Label();
            deleteTransactionNotificationLabel = new Label();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            removeAllSavingsBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)transactionGrid).BeginInit();
            filterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)maxAmountNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minAmountNumeric).BeginInit();
            SuspendLayout();
            // 
            // transactionGrid
            // 
            transactionGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(245, 246, 250);
            transactionGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            transactionGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            transactionGrid.BackgroundColor = Color.White;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle5.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            transactionGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            transactionGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            transactionGrid.DefaultCellStyle = dataGridViewCellStyle6;
            transactionGrid.EnableHeadersVisualStyles = false;
            transactionGrid.GridColor = SystemColors.ActiveCaption;
            transactionGrid.Location = new Point(195, 102);
            transactionGrid.Margin = new Padding(4);
            transactionGrid.Name = "transactionGrid";
            transactionGrid.Size = new Size(835, 250);
            transactionGrid.TabIndex = 0;
            transactionGrid.CellFormatting += transactionGrid_CellFormatting;
            transactionGrid.CellMouseEnter += transactionGrid_CellMouseEnter;
            transactionGrid.ColumnHeaderMouseClick += transactionGrid_ColumnHeaderMouseClick_1;
            transactionGrid.SelectionChanged += transactionGrid_SelectionChanged;
            // 
            // transactionsHeaderLabel
            // 
            transactionsHeaderLabel.AutoSize = true;
            transactionsHeaderLabel.Location = new Point(550, 25);
            transactionsHeaderLabel.Margin = new Padding(4, 0, 4, 0);
            transactionsHeaderLabel.Name = "transactionsHeaderLabel";
            transactionsHeaderLabel.Size = new Size(109, 18);
            transactionsHeaderLabel.TabIndex = 1;
            transactionsHeaderLabel.Text = "Transaktioner";
            transactionsHeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // transactionFormReturnBtn
            // 
            transactionFormReturnBtn.Anchor = AnchorStyles.Left;
            transactionFormReturnBtn.AutoSize = true;
            transactionFormReturnBtn.Cursor = Cursors.Hand;
            transactionFormReturnBtn.Location = new Point(19, 504);
            transactionFormReturnBtn.Margin = new Padding(10);
            transactionFormReturnBtn.Name = "transactionFormReturnBtn";
            transactionFormReturnBtn.Padding = new Padding(5);
            transactionFormReturnBtn.Size = new Size(111, 38);
            transactionFormReturnBtn.TabIndex = 2;
            transactionFormReturnBtn.Text = "Gå tillbaka";
            transactionFormReturnBtn.UseVisualStyleBackColor = true;
            transactionFormReturnBtn.Click += transactionFormReturnBtn_Click;
            // 
            // AddNewTransactionBtn
            // 
            AddNewTransactionBtn.BackColor = Color.LimeGreen;
            AddNewTransactionBtn.Cursor = Cursors.Hand;
            AddNewTransactionBtn.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddNewTransactionBtn.Location = new Point(447, 435);
            AddNewTransactionBtn.Name = "AddNewTransactionBtn";
            AddNewTransactionBtn.Size = new Size(97, 46);
            AddNewTransactionBtn.TabIndex = 3;
            AddNewTransactionBtn.Text = "Lägg till";
            AddNewTransactionBtn.UseVisualStyleBackColor = false;
            AddNewTransactionBtn.Click += AddNewTransactionBtn_Click;
            // 
            // totalTransactionsPostLabel
            // 
            totalTransactionsPostLabel.AutoSize = true;
            totalTransactionsPostLabel.Font = new Font("Lucida Sans", 11F);
            totalTransactionsPostLabel.ForeColor = Color.FromArgb(64, 64, 64);
            totalTransactionsPostLabel.Location = new Point(194, 356);
            totalTransactionsPostLabel.Name = "totalTransactionsPostLabel";
            totalTransactionsPostLabel.Size = new Size(145, 17);
            totalTransactionsPostLabel.TabIndex = 4;
            totalTransactionsPostLabel.Text = "Antal transaktioner";
            // 
            // filterLabel
            // 
            filterLabel.AutoSize = true;
            filterLabel.Font = new Font("Lucida Sans", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            filterLabel.Location = new Point(66, 21);
            filterLabel.Name = "filterLabel";
            filterLabel.Size = new Size(64, 22);
            filterLabel.TabIndex = 5;
            filterLabel.Text = "Filter";
            // 
            // filterSearchLabel
            // 
            filterSearchLabel.AutoSize = true;
            filterSearchLabel.Location = new Point(458, 72);
            filterSearchLabel.Name = "filterSearchLabel";
            filterSearchLabel.Size = new Size(46, 18);
            filterSearchLabel.TabIndex = 6;
            filterSearchLabel.Text = "Sök: ";
            // 
            // searchTransactionBox
            // 
            searchTransactionBox.Cursor = Cursors.IBeam;
            searchTransactionBox.Location = new Point(498, 69);
            searchTransactionBox.Name = "searchTransactionBox";
            searchTransactionBox.PlaceholderText = "Skriv det du söker efter";
            searchTransactionBox.Size = new Size(246, 26);
            searchTransactionBox.TabIndex = 7;
            searchTransactionBox.TextChanged += searchTransactionBox_TextChanged;
            // 
            // filterCategoryLabel
            // 
            filterCategoryLabel.AutoSize = true;
            filterCategoryLabel.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            filterCategoryLabel.Location = new Point(5, 102);
            filterCategoryLabel.Name = "filterCategoryLabel";
            filterCategoryLabel.Size = new Size(103, 18);
            filterCategoryLabel.TabIndex = 8;
            filterCategoryLabel.Text = "Kategorier: ";
            // 
            // filterTypeLabel
            // 
            filterTypeLabel.AutoSize = true;
            filterTypeLabel.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            filterTypeLabel.Location = new Point(5, 46);
            filterTypeLabel.Name = "filterTypeLabel";
            filterTypeLabel.Size = new Size(41, 18);
            filterTypeLabel.TabIndex = 9;
            filterTypeLabel.Text = "Typ:";
            // 
            // filterFromDateLabel
            // 
            filterFromDateLabel.AutoSize = true;
            filterFromDateLabel.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            filterFromDateLabel.Location = new Point(3, 377);
            filterFromDateLabel.Name = "filterFromDateLabel";
            filterFromDateLabel.Size = new Size(47, 18);
            filterFromDateLabel.TabIndex = 10;
            filterFromDateLabel.Text = "Från:";
            // 
            // filterToDateLabel
            // 
            filterToDateLabel.AutoSize = true;
            filterToDateLabel.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            filterToDateLabel.Location = new Point(9, 435);
            filterToDateLabel.Name = "filterToDateLabel";
            filterToDateLabel.Size = new Size(34, 18);
            filterToDateLabel.TabIndex = 11;
            filterToDateLabel.Text = "Till:";
            // 
            // fromDatePicker
            // 
            fromDatePicker.Cursor = Cursors.Hand;
            fromDatePicker.CustomFormat = "yyyy-MM-dd";
            fromDatePicker.Font = new Font("Lucida Sans", 10F);
            fromDatePicker.Format = DateTimePickerFormat.Short;
            fromDatePicker.Location = new Point(3, 398);
            fromDatePicker.Name = "fromDatePicker";
            fromDatePicker.Size = new Size(151, 23);
            fromDatePicker.TabIndex = 12;
            // 
            // toDatePicker
            // 
            toDatePicker.Cursor = Cursors.Hand;
            toDatePicker.CustomFormat = "yyyy-MM-dd";
            toDatePicker.Font = new Font("Lucida Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toDatePicker.Format = DateTimePickerFormat.Short;
            toDatePicker.Location = new Point(3, 456);
            toDatePicker.Name = "toDatePicker";
            toDatePicker.Size = new Size(151, 23);
            toDatePicker.TabIndex = 13;
            // 
            // filterButton
            // 
            filterButton.Cursor = Cursors.Hand;
            filterButton.Location = new Point(195, 59);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(97, 36);
            filterButton.TabIndex = 17;
            filterButton.Text = "Filter";
            filterButton.UseVisualStyleBackColor = true;
            filterButton.Click += filterButton_Click;
            // 
            // filterPanel
            // 
            filterPanel.BackColor = Color.FromArgb(44, 62, 80);
            filterPanel.Controls.Add(maxAmountNumeric);
            filterPanel.Controls.Add(maxAmountLabel);
            filterPanel.Controls.Add(minAmountLabel);
            filterPanel.Controls.Add(minAmountNumeric);
            filterPanel.Controls.Add(closeFilterPanelButton);
            filterPanel.Controls.Add(filterCategoryListBox);
            filterPanel.Controls.Add(filterApplyButton);
            filterPanel.Controls.Add(filterResetButton);
            filterPanel.Controls.Add(filterTypeComboBox);
            filterPanel.Controls.Add(filterLabel);
            filterPanel.Controls.Add(filterTypeLabel);
            filterPanel.Controls.Add(filterCategoryLabel);
            filterPanel.Controls.Add(toDatePicker);
            filterPanel.Controls.Add(filterFromDateLabel);
            filterPanel.Controls.Add(filterToDateLabel);
            filterPanel.Controls.Add(fromDatePicker);
            filterPanel.Dock = DockStyle.Left;
            filterPanel.ForeColor = Color.White;
            filterPanel.Location = new Point(0, 0);
            filterPanel.Name = "filterPanel";
            filterPanel.Size = new Size(188, 561);
            filterPanel.TabIndex = 18;
            filterPanel.Visible = false;
            // 
            // maxAmountNumeric
            // 
            maxAmountNumeric.Cursor = Cursors.Hand;
            maxAmountNumeric.Location = new Point(5, 335);
            maxAmountNumeric.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            maxAmountNumeric.Name = "maxAmountNumeric";
            maxAmountNumeric.Size = new Size(151, 26);
            maxAmountNumeric.TabIndex = 22;
            maxAmountNumeric.Value = new decimal(new int[] { 100000, 0, 0, 0 });
            // 
            // maxAmountLabel
            // 
            maxAmountLabel.AutoSize = true;
            maxAmountLabel.Font = new Font("Lucida Sans", 12F, FontStyle.Bold);
            maxAmountLabel.Location = new Point(2, 314);
            maxAmountLabel.Name = "maxAmountLabel";
            maxAmountLabel.Size = new Size(103, 18);
            maxAmountLabel.TabIndex = 21;
            maxAmountLabel.Text = "Max belopp";
            // 
            // minAmountLabel
            // 
            minAmountLabel.AutoSize = true;
            minAmountLabel.Font = new Font("Lucida Sans", 12F, FontStyle.Bold);
            minAmountLabel.Location = new Point(5, 260);
            minAmountLabel.Name = "minAmountLabel";
            minAmountLabel.Size = new Size(98, 18);
            minAmountLabel.TabIndex = 20;
            minAmountLabel.Text = "Min belopp";
            // 
            // minAmountNumeric
            // 
            minAmountNumeric.Cursor = Cursors.Hand;
            minAmountNumeric.Location = new Point(2, 281);
            minAmountNumeric.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            minAmountNumeric.Name = "minAmountNumeric";
            minAmountNumeric.Size = new Size(154, 26);
            minAmountNumeric.TabIndex = 19;
            // 
            // closeFilterPanelButton
            // 
            closeFilterPanelButton.Cursor = Cursors.Hand;
            closeFilterPanelButton.Font = new Font("Lucida Sans", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeFilterPanelButton.ForeColor = Color.Black;
            closeFilterPanelButton.Location = new Point(137, 12);
            closeFilterPanelButton.Name = "closeFilterPanelButton";
            closeFilterPanelButton.Size = new Size(28, 31);
            closeFilterPanelButton.TabIndex = 18;
            closeFilterPanelButton.Text = "X";
            closeFilterPanelButton.UseVisualStyleBackColor = true;
            closeFilterPanelButton.Click += closeFilterPanelButton_Click_1;
            // 
            // filterCategoryListBox
            // 
            filterCategoryListBox.CheckOnClick = true;
            filterCategoryListBox.Cursor = Cursors.Hand;
            filterCategoryListBox.FormattingEnabled = true;
            filterCategoryListBox.Location = new Point(2, 123);
            filterCategoryListBox.Name = "filterCategoryListBox";
            filterCategoryListBox.Size = new Size(176, 130);
            filterCategoryListBox.TabIndex = 17;
            filterCategoryListBox.ItemCheck += filterCategoryListBox_ItemCheck_1;
            // 
            // filterApplyButton
            // 
            filterApplyButton.Cursor = Cursors.Hand;
            filterApplyButton.Font = new Font("Lucida Sans", 12F, FontStyle.Bold);
            filterApplyButton.ForeColor = Color.Black;
            filterApplyButton.Location = new Point(104, 504);
            filterApplyButton.Name = "filterApplyButton";
            filterApplyButton.Size = new Size(75, 31);
            filterApplyButton.TabIndex = 15;
            filterApplyButton.Text = "Filtrera";
            filterApplyButton.UseVisualStyleBackColor = true;
            filterApplyButton.Click += filterApplyButton_Click;
            // 
            // filterResetButton
            // 
            filterResetButton.Cursor = Cursors.Hand;
            filterResetButton.Font = new Font("Lucida Sans", 12F, FontStyle.Bold);
            filterResetButton.ForeColor = Color.Black;
            filterResetButton.Location = new Point(8, 504);
            filterResetButton.Name = "filterResetButton";
            filterResetButton.Size = new Size(80, 31);
            filterResetButton.TabIndex = 14;
            filterResetButton.Text = "Rensa";
            filterResetButton.UseVisualStyleBackColor = true;
            filterResetButton.Click += filterResetButton_Click;
            // 
            // filterTypeComboBox
            // 
            filterTypeComboBox.FormattingEnabled = true;
            filterTypeComboBox.Location = new Point(5, 67);
            filterTypeComboBox.Name = "filterTypeComboBox";
            filterTypeComboBox.Size = new Size(151, 26);
            filterTypeComboBox.TabIndex = 6;
            // 
            // deleteTransactionBtn
            // 
            deleteTransactionBtn.BackColor = Color.LightGray;
            deleteTransactionBtn.Cursor = Cursors.Hand;
            deleteTransactionBtn.Font = new Font("Lucida Sans", 12F, FontStyle.Bold);
            deleteTransactionBtn.Location = new Point(550, 435);
            deleteTransactionBtn.Name = "deleteTransactionBtn";
            deleteTransactionBtn.Size = new Size(97, 46);
            deleteTransactionBtn.TabIndex = 19;
            deleteTransactionBtn.Text = "Radera";
            deleteTransactionBtn.UseVisualStyleBackColor = false;
            deleteTransactionBtn.Click += deleteTransactionBtn_Click;
            // 
            // updateTransactionBtn
            // 
            updateTransactionBtn.BackColor = Color.LightGray;
            updateTransactionBtn.Cursor = Cursors.Hand;
            updateTransactionBtn.Font = new Font("Lucida Sans", 12F, FontStyle.Bold);
            updateTransactionBtn.Location = new Point(653, 435);
            updateTransactionBtn.Name = "updateTransactionBtn";
            updateTransactionBtn.Size = new Size(106, 46);
            updateTransactionBtn.TabIndex = 20;
            updateTransactionBtn.Text = "Uppdatera";
            updateTransactionBtn.UseVisualStyleBackColor = false;
            updateTransactionBtn.Click += updateTransactionBtn_Click_1;
            // 
            // modifyTransactionsLabel
            // 
            modifyTransactionsLabel.AutoSize = true;
            modifyTransactionsLabel.Location = new Point(501, 399);
            modifyTransactionsLabel.Name = "modifyTransactionsLabel";
            modifyTransactionsLabel.Size = new Size(208, 18);
            modifyTransactionsLabel.TabIndex = 21;
            modifyTransactionsLabel.Text = "Hantera dina transaktioner";
            // 
            // deleteTransactionNotificationLabel
            // 
            deleteTransactionNotificationLabel.AutoSize = true;
            deleteTransactionNotificationLabel.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteTransactionNotificationLabel.ForeColor = Color.ForestGreen;
            deleteTransactionNotificationLabel.Location = new Point(500, 367);
            deleteTransactionNotificationLabel.Name = "deleteTransactionNotificationLabel";
            deleteTransactionNotificationLabel.Size = new Size(0, 18);
            deleteTransactionNotificationLabel.TabIndex = 22;
            deleteTransactionNotificationLabel.Visible = false;
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // removeAllSavingsBtn
            // 
            removeAllSavingsBtn.Location = new Point(825, 389);
            removeAllSavingsBtn.Name = "removeAllSavingsBtn";
            removeAllSavingsBtn.Size = new Size(133, 64);
            removeAllSavingsBtn.TabIndex = 23;
            removeAllSavingsBtn.Text = "ta bort sparposter";
            removeAllSavingsBtn.UseVisualStyleBackColor = true;
            removeAllSavingsBtn.Click += removeAllSavingsBtn_Click;
            // 
            // TransactionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1184, 561);
            Controls.Add(removeAllSavingsBtn);
            Controls.Add(deleteTransactionNotificationLabel);
            Controls.Add(modifyTransactionsLabel);
            Controls.Add(updateTransactionBtn);
            Controls.Add(deleteTransactionBtn);
            Controls.Add(filterPanel);
            Controls.Add(filterButton);
            Controls.Add(searchTransactionBox);
            Controls.Add(filterSearchLabel);
            Controls.Add(totalTransactionsPostLabel);
            Controls.Add(AddNewTransactionBtn);
            Controls.Add(transactionFormReturnBtn);
            Controls.Add(transactionsHeaderLabel);
            Controls.Add(transactionGrid);
            Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "TransactionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transaktioner";
            ((System.ComponentModel.ISupportInitialize)transactionGrid).EndInit();
            filterPanel.ResumeLayout(false);
            filterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)maxAmountNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)minAmountNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView transactionGrid;
        private Label transactionsHeaderLabel;
        private Button transactionFormReturnBtn;
        private Button AddNewTransactionBtn;
        private Label totalTransactionsPostLabel;
        private Label filterLabel;
        private Label filterSearchLabel;
        private TextBox searchTransactionBox;
        private Label filterCategoryLabel;
        private Label filterTypeLabel;
        private Label filterFromDateLabel;
        private Label filterToDateLabel;
        private DateTimePicker fromDatePicker;
        private DateTimePicker toDatePicker;
        private Button filterApplyButton;
        private Button filterButton;
        private Panel filterPanel;
        private ComboBox filterTypeComboBox;
        private Button filterResetButton;
        private CheckedListBox filterCategoryListBox;
        private Button closeFilterPanelButton;
        private Button deleteTransactionBtn;
        private Button updateTransactionBtn;
        private Label modifyTransactionsLabel;
        private NumericUpDown minAmountNumeric;
        private NumericUpDown maxAmountNumeric;
        private Label maxAmountLabel;
        private Label minAmountLabel;
        private Label deleteTransactionNotificationLabel;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private Button removeAllSavingsBtn;
    }
}