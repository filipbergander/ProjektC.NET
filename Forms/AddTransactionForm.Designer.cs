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
            saveAddTransactionBtn = new Button();
            addTransactionCancelBtn = new Button();
            addTransactionTypeLabel = new Label();
            addTransactionNameLabel = new Label();
            addTransactionCategoryLabel = new Label();
            addTransactionAmountLabel = new Label();
            addTransactionPanel = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            errorLabel = new Label();
            addTransactionFormReturnBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)addTransactionAmountNum).BeginInit();
            addTransactionPanel.SuspendLayout();
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
            addTransactionTypeComboBox.Size = new Size(315, 26);
            addTransactionTypeComboBox.TabIndex = 1;
            addTransactionTypeComboBox.Tag = "";
            // 
            // addTransactionTitleText
            // 
            addTransactionTitleText.Dock = DockStyle.Fill;
            addTransactionTitleText.Location = new Point(197, 76);
            addTransactionTitleText.Margin = new Padding(10);
            addTransactionTitleText.Name = "addTransactionTitleText";
            addTransactionTitleText.PlaceholderText = "Ange namn";
            addTransactionTitleText.Size = new Size(315, 26);
            addTransactionTitleText.TabIndex = 2;
            // 
            // addTransactionCategoryText
            // 
            addTransactionCategoryText.Dock = DockStyle.Fill;
            addTransactionCategoryText.Location = new Point(197, 122);
            addTransactionCategoryText.Margin = new Padding(10);
            addTransactionCategoryText.Name = "addTransactionCategoryText";
            addTransactionCategoryText.PlaceholderText = "Ange kategori";
            addTransactionCategoryText.Size = new Size(315, 26);
            addTransactionCategoryText.TabIndex = 3;
            // 
            // addTransactionAmountNum
            // 
            addTransactionAmountNum.Dock = DockStyle.Fill;
            addTransactionAmountNum.Location = new Point(197, 168);
            addTransactionAmountNum.Margin = new Padding(10);
            addTransactionAmountNum.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            addTransactionAmountNum.Name = "addTransactionAmountNum";
            addTransactionAmountNum.Size = new Size(315, 26);
            addTransactionAmountNum.TabIndex = 4;
            // 
            // saveAddTransactionBtn
            // 
            saveAddTransactionBtn.Location = new Point(140, 8);
            saveAddTransactionBtn.Name = "saveAddTransactionBtn";
            saveAddTransactionBtn.Size = new Size(120, 46);
            saveAddTransactionBtn.TabIndex = 5;
            saveAddTransactionBtn.Text = "Spara";
            saveAddTransactionBtn.UseVisualStyleBackColor = true;
            saveAddTransactionBtn.Click += SaveAddTransactionBtn_Click;
            // 
            // addTransactionCancelBtn
            // 
            addTransactionCancelBtn.Location = new Point(14, 8);
            addTransactionCancelBtn.Name = "addTransactionCancelBtn";
            addTransactionCancelBtn.Size = new Size(120, 46);
            addTransactionCancelBtn.TabIndex = 6;
            addTransactionCancelBtn.Text = "Avbryt";
            addTransactionCancelBtn.UseVisualStyleBackColor = true;
            addTransactionCancelBtn.Click += addTransactionCancelBtn_Click;
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
            addTransactionCategoryLabel.Size = new Size(128, 18);
            addTransactionCategoryLabel.TabIndex = 9;
            addTransactionCategoryLabel.Text = "Välj en kategori";
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
            addTransactionPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            addTransactionPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.66667F));
            addTransactionPanel.Controls.Add(addTransactionTypeLabel, 0, 0);
            addTransactionPanel.Controls.Add(addTransactionAmountLabel, 0, 3);
            addTransactionPanel.Controls.Add(addTransactionTypeComboBox, 1, 0);
            addTransactionPanel.Controls.Add(addTransactionAmountNum, 1, 3);
            addTransactionPanel.Controls.Add(addTransactionCategoryLabel, 0, 2);
            addTransactionPanel.Controls.Add(addTransactionNameLabel, 0, 1);
            addTransactionPanel.Controls.Add(addTransactionTitleText, 1, 1);
            addTransactionPanel.Controls.Add(addTransactionCategoryText, 1, 2);
            addTransactionPanel.Controls.Add(flowLayoutPanel1, 1, 4);
            addTransactionPanel.Location = new Point(356, 105);
            addTransactionPanel.Name = "addTransactionPanel";
            addTransactionPanel.Padding = new Padding(20);
            addTransactionPanel.RowCount = 5;
            addTransactionPanel.RowStyles.Add(new RowStyle());
            addTransactionPanel.RowStyles.Add(new RowStyle());
            addTransactionPanel.RowStyles.Add(new RowStyle());
            addTransactionPanel.RowStyles.Add(new RowStyle());
            addTransactionPanel.RowStyles.Add(new RowStyle());
            addTransactionPanel.Size = new Size(542, 296);
            addTransactionPanel.TabIndex = 11;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(errorLabel);
            flowLayoutPanel1.Controls.Add(addTransactionCancelBtn);
            flowLayoutPanel1.Controls.Add(saveAddTransactionBtn);
            flowLayoutPanel1.Location = new Point(192, 209);
            flowLayoutPanel1.Margin = new Padding(5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5);
            flowLayoutPanel1.Size = new Size(268, 62);
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
        private Button saveAddTransactionBtn;
        private Button addTransactionCancelBtn;
        private Label addTransactionTypeLabel;
        private Label addTransactionNameLabel;
        private Label addTransactionCategoryLabel;
        private Label addTransactionAmountLabel;
        private TableLayoutPanel addTransactionPanel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button addTransactionFormReturnBtn;
        private Label errorLabel;
    }
}