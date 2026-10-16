namespace Projekt.Forms
{
    partial class AddTransactionForm
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
            addTransactionLabel = new Label();
            addTransactionTypeComboBox = new ComboBox();
            addTransactionTitleText = new TextBox();
            addTransactionCategoryText = new TextBox();
            addTransactionAmountNum = new NumericUpDown();
            addTransactionTypeLabel = new Label();
            addTransactionNameLabel = new Label();
            addTransactionCategoryLabel = new Label();
            addTransactionAmountLabel = new Label();
            addTransactionPanel = new TableLayoutPanel();
            addTransactionDatePicker = new DateTimePicker();
            addTransactionDateLabel = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            saveAddTransactionBtn = new Button();
            addTransactionCancelBtn = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            errorLabel = new Label();
            addTransactionFormReturnBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)addTransactionAmountNum).BeginInit();
            addTransactionPanel.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // addTransactionLabel
            // 
            addTransactionLabel.AutoSize = true;
            addTransactionLabel.Location = new Point(550, 50);
            addTransactionLabel.Name = "addTransactionLabel";
            addTransactionLabel.Size = new Size(182, 18);
            addTransactionLabel.TabIndex = 0;
            addTransactionLabel.Text = "Lägg till en transaktion";
            // 
            // addTransactionTypeComboBox
            // 
            addTransactionTypeComboBox.AccessibleDescription = "Typ av transaktion";
            addTransactionTypeComboBox.Dock = DockStyle.Fill;
            addTransactionTypeComboBox.FormattingEnabled = true;
            addTransactionTypeComboBox.Location = new Point(197, 30);
            addTransactionTypeComboBox.Margin = new Padding(10);
            addTransactionTypeComboBox.Name = "addTransactionTypeComboBox";
            addTransactionTypeComboBox.Size = new Size(345, 26);
            addTransactionTypeComboBox.TabIndex = 1;
            addTransactionTypeComboBox.Tag = "";
            // 
            // addTransactionTitleText
            // 
            addTransactionTitleText.Dock = DockStyle.Fill;
            addTransactionTitleText.Location = new Point(197, 76);
            addTransactionTitleText.Margin = new Padding(10);
            addTransactionTitleText.Name = "addTransactionTitleText";
            addTransactionTitleText.PlaceholderText = "Skriv namn";
            addTransactionTitleText.Size = new Size(345, 26);
            addTransactionTitleText.TabIndex = 2;
            // 
            // addTransactionCategoryText
            // 
            addTransactionCategoryText.Dock = DockStyle.Fill;
            addTransactionCategoryText.Location = new Point(197, 122);
            addTransactionCategoryText.Margin = new Padding(10);
            addTransactionCategoryText.Name = "addTransactionCategoryText";
            addTransactionCategoryText.PlaceholderText = "Skriv kategori";
            addTransactionCategoryText.Size = new Size(345, 26);
            addTransactionCategoryText.TabIndex = 3;
            // 
            // addTransactionAmountNum
            // 
            addTransactionAmountNum.Dock = DockStyle.Fill;
            addTransactionAmountNum.Location = new Point(197, 168);
            addTransactionAmountNum.Margin = new Padding(10);
            addTransactionAmountNum.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            addTransactionAmountNum.Name = "addTransactionAmountNum";
            addTransactionAmountNum.Size = new Size(345, 26);
            addTransactionAmountNum.TabIndex = 4;
            // 
            // addTransactionTypeLabel
            // 
            addTransactionTypeLabel.Anchor = AnchorStyles.Left;
            addTransactionTypeLabel.AutoSize = true;
            addTransactionTypeLabel.Location = new Point(30, 34);
            addTransactionTypeLabel.Margin = new Padding(10);
            addTransactionTypeLabel.Name = "addTransactionTypeLabel";
            addTransactionTypeLabel.Size = new Size(67, 18);
            addTransactionTypeLabel.TabIndex = 7;
            addTransactionTypeLabel.Text = "Välj typ";
            // 
            // addTransactionNameLabel
            // 
            addTransactionNameLabel.Anchor = AnchorStyles.Left;
            addTransactionNameLabel.AutoSize = true;
            addTransactionNameLabel.Location = new Point(30, 80);
            addTransactionNameLabel.Margin = new Padding(10);
            addTransactionNameLabel.Name = "addTransactionNameLabel";
            addTransactionNameLabel.Size = new Size(116, 18);
            addTransactionNameLabel.TabIndex = 8;
            addTransactionNameLabel.Text = "Lägg till namn";
            // 
            // addTransactionCategoryLabel
            // 
            addTransactionCategoryLabel.Anchor = AnchorStyles.Left;
            addTransactionCategoryLabel.AutoSize = true;
            addTransactionCategoryLabel.Location = new Point(30, 126);
            addTransactionCategoryLabel.Margin = new Padding(10);
            addTransactionCategoryLabel.Name = "addTransactionCategoryLabel";
            addTransactionCategoryLabel.Size = new Size(137, 18);
            addTransactionCategoryLabel.TabIndex = 9;
            addTransactionCategoryLabel.Text = "Ange en kategori";
            // 
            // addTransactionAmountLabel
            // 
            addTransactionAmountLabel.Anchor = AnchorStyles.Left;
            addTransactionAmountLabel.AutoSize = true;
            addTransactionAmountLabel.Location = new Point(30, 172);
            addTransactionAmountLabel.Margin = new Padding(10);
            addTransactionAmountLabel.Name = "addTransactionAmountLabel";
            addTransactionAmountLabel.Size = new Size(147, 18);
            addTransactionAmountLabel.TabIndex = 10;
            addTransactionAmountLabel.Text = "Ange belopp (sek)";
            // 
            // addTransactionPanel
            // 
            addTransactionPanel.AutoSize = true;
            addTransactionPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addTransactionPanel.BackColor = Color.Khaki;
            addTransactionPanel.ColumnCount = 2;
            addTransactionPanel.ColumnStyles.Add(new ColumnStyle());
            addTransactionPanel.ColumnStyles.Add(new ColumnStyle());
            addTransactionPanel.Controls.Add(addTransactionTypeLabel, 0, 0);
            addTransactionPanel.Controls.Add(addTransactionAmountLabel, 0, 3);
            addTransactionPanel.Controls.Add(addTransactionTypeComboBox, 1, 0);
            addTransactionPanel.Controls.Add(addTransactionCategoryLabel, 0, 2);
            addTransactionPanel.Controls.Add(addTransactionNameLabel, 0, 1);
            addTransactionPanel.Controls.Add(addTransactionTitleText, 1, 1);
            addTransactionPanel.Controls.Add(addTransactionCategoryText, 1, 2);
            addTransactionPanel.Controls.Add(addTransactionAmountNum, 1, 3);
            addTransactionPanel.Controls.Add(addTransactionDatePicker, 1, 4);
            addTransactionPanel.Controls.Add(addTransactionDateLabel, 0, 4);
            addTransactionPanel.Controls.Add(flowLayoutPanel2, 1, 6);
            addTransactionPanel.Controls.Add(flowLayoutPanel1, 1, 5);
            addTransactionPanel.Location = new Point(352, 88);
            addTransactionPanel.Name = "addTransactionPanel";
            addTransactionPanel.Padding = new Padding(20);
            addTransactionPanel.RowCount = 7;
            addTransactionPanel.RowStyles.Add(new RowStyle());
            addTransactionPanel.RowStyles.Add(new RowStyle());
            addTransactionPanel.RowStyles.Add(new RowStyle());
            addTransactionPanel.RowStyles.Add(new RowStyle());
            addTransactionPanel.RowStyles.Add(new RowStyle());
            addTransactionPanel.RowStyles.Add(new RowStyle());
            addTransactionPanel.RowStyles.Add(new RowStyle());
            addTransactionPanel.Size = new Size(572, 382);
            addTransactionPanel.TabIndex = 11;
            // 
            // addTransactionDatePicker
            // 
            addTransactionDatePicker.Format = DateTimePickerFormat.Short;
            addTransactionDatePicker.Location = new Point(197, 214);
            addTransactionDatePicker.Margin = new Padding(10);
            addTransactionDatePicker.Name = "addTransactionDatePicker";
            addTransactionDatePicker.Size = new Size(315, 26);
            addTransactionDatePicker.TabIndex = 4;
            // 
            // addTransactionDateLabel
            // 
            addTransactionDateLabel.AutoSize = true;
            addTransactionDateLabel.Location = new Point(30, 214);
            addTransactionDateLabel.Margin = new Padding(10);
            addTransactionDateLabel.Name = "addTransactionDateLabel";
            addTransactionDateLabel.Size = new Size(90, 18);
            addTransactionDateLabel.TabIndex = 11;
            addTransactionDateLabel.Text = "Välj datum";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(saveAddTransactionBtn);
            flowLayoutPanel2.Controls.Add(addTransactionCancelBtn);
            flowLayoutPanel2.Location = new Point(190, 291);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(345, 68);
            flowLayoutPanel2.TabIndex = 13;
            // 
            // saveAddTransactionBtn
            // 
            saveAddTransactionBtn.Cursor = Cursors.Hand;
            saveAddTransactionBtn.Location = new Point(10, 10);
            saveAddTransactionBtn.Margin = new Padding(10);
            saveAddTransactionBtn.Name = "saveAddTransactionBtn";
            saveAddTransactionBtn.Size = new Size(167, 46);
            saveAddTransactionBtn.TabIndex = 5;
            saveAddTransactionBtn.Text = "Spara transaktionen";
            saveAddTransactionBtn.UseVisualStyleBackColor = true;
            saveAddTransactionBtn.Click += SaveAddTransactionBtn_Click;
            // 
            // addTransactionCancelBtn
            // 
            addTransactionCancelBtn.Cursor = Cursors.Hand;
            addTransactionCancelBtn.Location = new Point(197, 10);
            addTransactionCancelBtn.Margin = new Padding(10);
            addTransactionCancelBtn.Name = "addTransactionCancelBtn";
            addTransactionCancelBtn.Size = new Size(132, 46);
            addTransactionCancelBtn.TabIndex = 6;
            addTransactionCancelBtn.Text = "Avbryt";
            addTransactionCancelBtn.UseVisualStyleBackColor = true;
            addTransactionCancelBtn.Click += addTransactionCancelBtn_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(errorLabel);
            flowLayoutPanel1.Location = new Point(192, 255);
            flowLayoutPanel1.Margin = new Padding(5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5);
            flowLayoutPanel1.Size = new Size(16, 28);
            flowLayoutPanel1.TabIndex = 12;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Location = new Point(8, 5);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(0, 18);
            errorLabel.TabIndex = 7;
            // 
            // addTransactionFormReturnBtn
            // 
            addTransactionFormReturnBtn.Anchor = AnchorStyles.Left;
            addTransactionFormReturnBtn.AutoSize = true;
            addTransactionFormReturnBtn.Location = new Point(19, 514);
            addTransactionFormReturnBtn.Margin = new Padding(10);
            addTransactionFormReturnBtn.Name = "addTransactionFormReturnBtn";
            addTransactionFormReturnBtn.Padding = new Padding(5);
            addTransactionFormReturnBtn.Size = new Size(111, 38);
            addTransactionFormReturnBtn.TabIndex = 0;
            addTransactionFormReturnBtn.Text = "Gå tillbaka";
            addTransactionFormReturnBtn.UseVisualStyleBackColor = true;
            addTransactionFormReturnBtn.Click += AddTransactionFormReturnBtn_Click;
            // 
            // AddTransactionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1184, 561);
            Controls.Add(addTransactionFormReturnBtn);
            Controls.Add(addTransactionPanel);
            Controls.Add(addTransactionLabel);
            Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "AddTransactionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lägg till transaktion";
            Load += AddTransactionForm_Load;
            ((System.ComponentModel.ISupportInitialize)addTransactionAmountNum).EndInit();
            addTransactionPanel.ResumeLayout(false);
            addTransactionPanel.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label addTransactionLabel;
        private ComboBox addTransactionTypeComboBox;
        private TextBox addTransactionTitleText;
        private TextBox addTransactionCategoryText;
        private NumericUpDown addTransactionAmountNum;
        private Label addTransactionTypeLabel;
        private Label addTransactionNameLabel;
        private Label addTransactionCategoryLabel;
        private Label addTransactionAmountLabel;
        private TableLayoutPanel addTransactionPanel;
        private Button addTransactionFormReturnBtn;
        private Label addTransactionDateLabel;
        private DateTimePicker addTransactionDatePicker;
        private Button addTransactionCancelBtn;
        private Button saveAddTransactionBtn;
        private Label errorLabel;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}