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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionForm));
            transactionGrid = new DataGridView();
            transactionsHeaderLabel = new Label();
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
            modifyTransactionsLabel = new Label();
            deleteTransactionNotificationLabel = new Label();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            removeAllSavingsBtn = new Button();
            AddNewTransactionBtn = new FontAwesome.Sharp.IconButton();
            deleteTransactionBtn = new FontAwesome.Sharp.IconButton();
            updateTransactionBtn = new FontAwesome.Sharp.IconButton();
            filterButton = new FontAwesome.Sharp.IconButton();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            transactionFormReturnBtn = new FontAwesome.Sharp.IconButton();
            totalSumTransactions = new Label();
            ((System.ComponentModel.ISupportInitialize)transactionGrid).BeginInit();
            filterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)maxAmountNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minAmountNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // transactionGrid
            // 
            transactionGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 246, 250);
            transactionGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            transactionGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            transactionGrid.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle2.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            transactionGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            transactionGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            transactionGrid.DefaultCellStyle = dataGridViewCellStyle3;
            transactionGrid.EnableHeadersVisualStyles = false;
            transactionGrid.GridColor = SystemColors.ActiveCaption;
            transactionGrid.Location = new Point(195, 102);
            transactionGrid.Margin = new Padding(4);
            transactionGrid.MultiSelect = false;
            transactionGrid.Name = "transactionGrid";
            transactionGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            transactionGrid.Size = new Size(835, 250);
            transactionGrid.TabIndex = 0;
            transactionGrid.TabStop = false;
            transactionGrid.CellFormatting += transactionGrid_CellFormatting;
            transactionGrid.CellMouseEnter += transactionGrid_CellMouseEnter;
            transactionGrid.ColumnHeaderMouseClick += transactionGrid_ColumnHeaderMouseClick_1;
            transactionGrid.SelectionChanged += transactionGrid_SelectionChanged;
            // 
            // transactionsHeaderLabel
            // 
            transactionsHeaderLabel.AutoSize = true;
            transactionsHeaderLabel.Font = new Font("Lucida Sans", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            transactionsHeaderLabel.Location = new Point(521, 21);
            transactionsHeaderLabel.Margin = new Padding(4, 0, 4, 0);
            transactionsHeaderLabel.Name = "transactionsHeaderLabel";
            transactionsHeaderLabel.Size = new Size(152, 22);
            transactionsHeaderLabel.TabIndex = 1;
            transactionsHeaderLabel.Text = "Transaktioner";
            transactionsHeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
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
            filterLabel.Location = new Point(56, 16);
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
            filterResetButton.BackColor = Color.White;
            filterResetButton.Cursor = Cursors.Hand;
            filterResetButton.Font = new Font("Lucida Sans", 12F, FontStyle.Bold);
            filterResetButton.ForeColor = Color.Black;
            filterResetButton.Location = new Point(8, 504);
            filterResetButton.Name = "filterResetButton";
            filterResetButton.Size = new Size(80, 31);
            filterResetButton.TabIndex = 14;
            filterResetButton.Text = "Rensa";
            filterResetButton.UseVisualStyleBackColor = false;
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
            // modifyTransactionsLabel
            // 
            modifyTransactionsLabel.AutoSize = true;
            modifyTransactionsLabel.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            modifyTransactionsLabel.Location = new Point(481, 399);
            modifyTransactionsLabel.Name = "modifyTransactionsLabel";
            modifyTransactionsLabel.Size = new Size(229, 18);
            modifyTransactionsLabel.TabIndex = 21;
            modifyTransactionsLabel.Text = "Hantera dina transaktioner";
            // 
            // deleteTransactionNotificationLabel
            // 
            deleteTransactionNotificationLabel.AutoSize = true;
            deleteTransactionNotificationLabel.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteTransactionNotificationLabel.ForeColor = Color.ForestGreen;
            deleteTransactionNotificationLabel.Location = new Point(480, 367);
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
            removeAllSavingsBtn.Location = new Point(956, 399);
            removeAllSavingsBtn.Name = "removeAllSavingsBtn";
            removeAllSavingsBtn.Size = new Size(133, 64);
            removeAllSavingsBtn.TabIndex = 23;
            removeAllSavingsBtn.Text = "ta bort sparposter";
            removeAllSavingsBtn.UseVisualStyleBackColor = true;
            removeAllSavingsBtn.Click += removeAllSavingsBtn_Click;
            // 
            // AddNewTransactionBtn
            // 
            AddNewTransactionBtn.BackColor = Color.FromArgb(1, 170, 51);
            AddNewTransactionBtn.Cursor = Cursors.Hand;
            AddNewTransactionBtn.IconChar = FontAwesome.Sharp.IconChar.Add;
            AddNewTransactionBtn.IconColor = Color.Black;
            AddNewTransactionBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AddNewTransactionBtn.IconSize = 24;
            AddNewTransactionBtn.Location = new Point(395, 424);
            AddNewTransactionBtn.Name = "AddNewTransactionBtn";
            AddNewTransactionBtn.Size = new Size(140, 55);
            AddNewTransactionBtn.TabIndex = 24;
            AddNewTransactionBtn.Text = "Lägg till transaktion";
            AddNewTransactionBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            AddNewTransactionBtn.UseVisualStyleBackColor = false;
            AddNewTransactionBtn.Click += AddNewTransactionBtn_Click;
            // 
            // deleteTransactionBtn
            // 
            deleteTransactionBtn.BackColor = Color.LightGray;
            deleteTransactionBtn.Cursor = Cursors.Hand;
            deleteTransactionBtn.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            deleteTransactionBtn.IconColor = Color.Black;
            deleteTransactionBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            deleteTransactionBtn.IconSize = 24;
            deleteTransactionBtn.Location = new Point(550, 424);
            deleteTransactionBtn.Name = "deleteTransactionBtn";
            deleteTransactionBtn.Size = new Size(110, 55);
            deleteTransactionBtn.TabIndex = 25;
            deleteTransactionBtn.Text = "Ta bort";
            deleteTransactionBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            deleteTransactionBtn.UseVisualStyleBackColor = false;
            deleteTransactionBtn.Click += deleteTransactionBtn_Click;
            // 
            // updateTransactionBtn
            // 
            updateTransactionBtn.BackColor = Color.LightGray;
            updateTransactionBtn.Cursor = Cursors.Hand;
            updateTransactionBtn.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            updateTransactionBtn.IconColor = Color.Black;
            updateTransactionBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            updateTransactionBtn.IconSize = 24;
            updateTransactionBtn.Location = new Point(687, 424);
            updateTransactionBtn.Name = "updateTransactionBtn";
            updateTransactionBtn.Size = new Size(134, 55);
            updateTransactionBtn.TabIndex = 26;
            updateTransactionBtn.Text = "Uppdatera";
            updateTransactionBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            updateTransactionBtn.UseVisualStyleBackColor = false;
            updateTransactionBtn.Click += updateTransactionBtn_Click_1;
            // 
            // filterButton
            // 
            filterButton.Cursor = Cursors.Hand;
            filterButton.IconChar = FontAwesome.Sharp.IconChar.Filter;
            filterButton.IconColor = Color.Black;
            filterButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            filterButton.IconSize = 25;
            filterButton.ImageAlign = ContentAlignment.MiddleLeft;
            filterButton.Location = new Point(195, 61);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(103, 34);
            filterButton.TabIndex = 28;
            filterButton.Text = "Filter";
            filterButton.UseVisualStyleBackColor = true;
            filterButton.Click += filterButton_Click;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(244, 245, 247);
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 23;
            iconPictureBox1.Location = new Point(438, 69);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(23, 26);
            iconPictureBox1.TabIndex = 29;
            iconPictureBox1.TabStop = false;
            // 
            // transactionFormReturnBtn
            // 
            transactionFormReturnBtn.Cursor = Cursors.Hand;
            transactionFormReturnBtn.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            transactionFormReturnBtn.IconColor = Color.Black;
            transactionFormReturnBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            transactionFormReturnBtn.IconSize = 30;
            transactionFormReturnBtn.ImageAlign = ContentAlignment.MiddleLeft;
            transactionFormReturnBtn.Location = new Point(0, 520);
            transactionFormReturnBtn.Name = "transactionFormReturnBtn";
            transactionFormReturnBtn.Size = new Size(127, 38);
            transactionFormReturnBtn.TabIndex = 31;
            transactionFormReturnBtn.Text = "Gå tillbaka";
            transactionFormReturnBtn.TextAlign = ContentAlignment.MiddleRight;
            transactionFormReturnBtn.UseVisualStyleBackColor = true;
            transactionFormReturnBtn.Click += transactionFormReturnBtn_Click;
            // 
            // totalSumTransactions
            // 
            totalSumTransactions.AutoSize = true;
            totalSumTransactions.Font = new Font("Lucida Sans", 11F);
            totalSumTransactions.ForeColor = Color.FromArgb(64, 64, 64);
            totalSumTransactions.Location = new Point(866, 356);
            totalSumTransactions.Name = "totalSumTransactions";
            totalSumTransactions.Size = new Size(64, 17);
            totalSumTransactions.TabIndex = 32;
            totalSumTransactions.Text = "Summa:";
            // 
            // TransactionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 245, 247);
            ClientSize = new Size(1184, 561);
            Controls.Add(totalSumTransactions);
            Controls.Add(iconPictureBox1);
            Controls.Add(filterButton);
            Controls.Add(updateTransactionBtn);
            Controls.Add(deleteTransactionBtn);
            Controls.Add(AddNewTransactionBtn);
            Controls.Add(removeAllSavingsBtn);
            Controls.Add(deleteTransactionNotificationLabel);
            Controls.Add(modifyTransactionsLabel);
            Controls.Add(filterPanel);
            Controls.Add(searchTransactionBox);
            Controls.Add(filterSearchLabel);
            Controls.Add(totalTransactionsPostLabel);
            Controls.Add(transactionsHeaderLabel);
            Controls.Add(transactionGrid);
            Controls.Add(transactionFormReturnBtn);
            Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "TransactionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transaktioner";
            ((System.ComponentModel.ISupportInitialize)transactionGrid).EndInit();
            filterPanel.ResumeLayout(false);
            filterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)maxAmountNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)minAmountNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView transactionGrid;
        private Label transactionsHeaderLabel;
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
        private Panel filterPanel;
        private ComboBox filterTypeComboBox;
        private Button filterResetButton;
        private CheckedListBox filterCategoryListBox;
        private Button closeFilterPanelButton;
        private Label modifyTransactionsLabel;
        private NumericUpDown minAmountNumeric;
        private NumericUpDown maxAmountNumeric;
        private Label maxAmountLabel;
        private Label minAmountLabel;
        private Label deleteTransactionNotificationLabel;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private Button removeAllSavingsBtn;
        private FontAwesome.Sharp.IconButton AddNewTransactionBtn;
        private FontAwesome.Sharp.IconButton deleteTransactionBtn;
        private FontAwesome.Sharp.IconButton updateTransactionBtn;
        private FontAwesome.Sharp.IconButton filterButton;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton transactionFormReturnBtn;
        private Label totalSumTransactions;
    }
}