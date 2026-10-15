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
            transactionGrid = new DataGridView();
            transactionsHeaderLabel = new Label();
            transactionFormReturnBtn = new Button();
            AddNewTransactionBtn = new Button();
            totalTransactionsPostLabel = new Label();
            filterLabel = new Label();
            filterSearchLabel = new Label();
            textBox1 = new TextBox();
            filterCategoryLabel = new Label();
            filterTypeLabel = new Label();
            filterFromDateLabel = new Label();
            filterToDateLabel = new Label();
            fromDatePicker = new DateTimePicker();
            toDatePicker = new DateTimePicker();
            filterButton = new Button();
            filterPanel = new Panel();
            closeFilterPanelButton = new Button();
            filterCategoryListBox = new CheckedListBox();
            filterApplyButton = new Button();
            filterResetButton = new Button();
            filterTypeComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)transactionGrid).BeginInit();
            filterPanel.SuspendLayout();
            SuspendLayout();
            // 
            // transactionGrid
            // 
            transactionGrid.AllowUserToResizeColumns = false;
            transactionGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 246, 250);
            transactionGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            transactionGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            transactionGrid.Location = new Point(185, 166);
            transactionGrid.Margin = new Padding(4);
            transactionGrid.Name = "transactionGrid";
            transactionGrid.Size = new Size(835, 205);
            transactionGrid.TabIndex = 0;
            transactionGrid.CellFormatting += transactionGrid_CellFormatting;
            transactionGrid.CellMouseEnter += transactionGrid_CellMouseEnter;
            transactionGrid.ColumnHeaderMouseClick += transactionGrid_ColumnHeaderMouseClick_1;
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
            AddNewTransactionBtn.Location = new Point(286, 409);
            AddNewTransactionBtn.Name = "AddNewTransactionBtn";
            AddNewTransactionBtn.Size = new Size(97, 46);
            AddNewTransactionBtn.TabIndex = 3;
            AddNewTransactionBtn.Text = "Lägg till";
            AddNewTransactionBtn.UseVisualStyleBackColor = true;
            AddNewTransactionBtn.Click += AddNewTransactionBtn_Click;
            // 
            // totalTransactionsPostLabel
            // 
            totalTransactionsPostLabel.AutoSize = true;
            totalTransactionsPostLabel.Font = new Font("Lucida Sans", 11F);
            totalTransactionsPostLabel.ForeColor = Color.FromArgb(64, 64, 64);
            totalTransactionsPostLabel.Location = new Point(185, 375);
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
            filterSearchLabel.Location = new Point(448, 136);
            filterSearchLabel.Name = "filterSearchLabel";
            filterSearchLabel.Size = new Size(46, 18);
            filterSearchLabel.TabIndex = 6;
            filterSearchLabel.Text = "Sök: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(488, 133);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(246, 26);
            textBox1.TabIndex = 7;
            // 
            // filterCategoryLabel
            // 
            filterCategoryLabel.AutoSize = true;
            filterCategoryLabel.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            filterCategoryLabel.Location = new Point(6, 123);
            filterCategoryLabel.Name = "filterCategoryLabel";
            filterCategoryLabel.Size = new Size(103, 18);
            filterCategoryLabel.TabIndex = 8;
            filterCategoryLabel.Text = "Kategorier: ";
            // 
            // filterTypeLabel
            // 
            filterTypeLabel.AutoSize = true;
            filterTypeLabel.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            filterTypeLabel.Location = new Point(6, 67);
            filterTypeLabel.Name = "filterTypeLabel";
            filterTypeLabel.Size = new Size(41, 18);
            filterTypeLabel.TabIndex = 9;
            filterTypeLabel.Text = "Typ:";
            // 
            // filterFromDateLabel
            // 
            filterFromDateLabel.AutoSize = true;
            filterFromDateLabel.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            filterFromDateLabel.Location = new Point(6, 305);
            filterFromDateLabel.Name = "filterFromDateLabel";
            filterFromDateLabel.Size = new Size(47, 18);
            filterFromDateLabel.TabIndex = 10;
            filterFromDateLabel.Text = "Från:";
            // 
            // filterToDateLabel
            // 
            filterToDateLabel.AutoSize = true;
            filterToDateLabel.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            filterToDateLabel.Location = new Point(12, 363);
            filterToDateLabel.Name = "filterToDateLabel";
            filterToDateLabel.Size = new Size(34, 18);
            filterToDateLabel.TabIndex = 11;
            filterToDateLabel.Text = "Till:";
            // 
            // fromDatePicker
            // 
            fromDatePicker.CustomFormat = "yyyy-MM-dd";
            fromDatePicker.Font = new Font("Lucida Sans", 10F);
            fromDatePicker.Format = DateTimePickerFormat.Short;
            fromDatePicker.Location = new Point(6, 326);
            fromDatePicker.Name = "fromDatePicker";
            fromDatePicker.Size = new Size(151, 23);
            fromDatePicker.TabIndex = 12;
            // 
            // toDatePicker
            // 
            toDatePicker.CustomFormat = "yyyy-MM-dd";
            toDatePicker.Font = new Font("Lucida Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toDatePicker.Format = DateTimePickerFormat.Short;
            toDatePicker.Location = new Point(6, 384);
            toDatePicker.Name = "toDatePicker";
            toDatePicker.Size = new Size(151, 23);
            toDatePicker.TabIndex = 13;
            // 
            // filterButton
            // 
            filterButton.Location = new Point(185, 123);
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
            filterPanel.Size = new Size(211, 561);
            filterPanel.TabIndex = 18;
            filterPanel.Visible = false;
            // 
            // closeFilterPanelButton
            // 
            closeFilterPanelButton.Font = new Font("Lucida Sans", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeFilterPanelButton.ForeColor = Color.Black;
            closeFilterPanelButton.Location = new Point(171, 18);
            closeFilterPanelButton.Name = "closeFilterPanelButton";
            closeFilterPanelButton.Size = new Size(28, 28);
            closeFilterPanelButton.TabIndex = 18;
            closeFilterPanelButton.Text = "X";
            closeFilterPanelButton.UseVisualStyleBackColor = true;
            closeFilterPanelButton.Click += closeFilterPanelButton_Click_1;
            // 
            // filterCategoryListBox
            // 
            filterCategoryListBox.CheckOnClick = true;
            filterCategoryListBox.FormattingEnabled = true;
            filterCategoryListBox.Location = new Point(3, 144);
            filterCategoryListBox.Name = "filterCategoryListBox";
            filterCategoryListBox.Size = new Size(196, 130);
            filterCategoryListBox.TabIndex = 17;
            filterCategoryListBox.ItemCheck += filterCategoryListBox_ItemCheck_1;
            // 
            // filterApplyButton
            // 
            filterApplyButton.Font = new Font("Lucida Sans", 12F, FontStyle.Bold);
            filterApplyButton.ForeColor = Color.Black;
            filterApplyButton.Location = new Point(114, 460);
            filterApplyButton.Name = "filterApplyButton";
            filterApplyButton.Size = new Size(75, 31);
            filterApplyButton.TabIndex = 15;
            filterApplyButton.Text = "Filtrera";
            filterApplyButton.UseVisualStyleBackColor = true;
            // 
            // filterResetButton
            // 
            filterResetButton.Font = new Font("Lucida Sans", 12F, FontStyle.Bold);
            filterResetButton.ForeColor = Color.Black;
            filterResetButton.Location = new Point(18, 460);
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
            filterTypeComboBox.Location = new Point(6, 88);
            filterTypeComboBox.Name = "filterTypeComboBox";
            filterTypeComboBox.Size = new Size(151, 26);
            filterTypeComboBox.TabIndex = 6;
            filterTypeComboBox.SelectedIndexChanged += filterComboBox_SelectedIndexChanged;
            // 
            // TransactionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1184, 561);
            Controls.Add(filterPanel);
            Controls.Add(filterButton);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private Label filterCategoryLabel;
        private Label filterTypeLabel;
        private Label filterFromDateLabel;
        private Label filterToDateLabel;
        private DateTimePicker fromDatePicker;
        private DateTimePicker toDatePicker;
        private TextBox textBox3;
        private Button filterApplyButton;
        private Button filterButton;
        private Panel filterPanel;
        private ComboBox filterTypeComboBox;
        private Button filterResetButton;
        private CheckedListBox filterCategoryListBox;
        private Button closeFilterPanelButton;
    }
}