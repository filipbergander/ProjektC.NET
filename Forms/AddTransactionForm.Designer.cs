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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTransactionForm));
            addTransactionLabel = new Label();
            addTransactionTypeComboBox = new ComboBox();
            addTransactionTitleText = new TextBox();
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
            msgLabel = new Label();
            addTransactionCategoryCombo = new ComboBox();
            AddTransactionFormReturnBtn = new FontAwesome.Sharp.IconButton();
            menuStrip1 = new MenuStrip();
            appToolStripMenuItem = new ToolStripMenuItem();
            avslutaToolStripMenuItem = new ToolStripMenuItem();
            hjälpToolStripMenuItem = new ToolStripMenuItem();
            omToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)addTransactionAmountNum).BeginInit();
            addTransactionPanel.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // addTransactionLabel
            // 
            addTransactionLabel.AutoSize = true;
            addTransactionLabel.Font = new Font("Lucida Sans", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addTransactionLabel.Location = new Point(519, 24);
            addTransactionLabel.Name = "addTransactionLabel";
            addTransactionLabel.Size = new Size(247, 22);
            addTransactionLabel.TabIndex = 0;
            addTransactionLabel.Text = "Lägg till en transaktion";
            // 
            // addTransactionTypeComboBox
            // 
            addTransactionTypeComboBox.AccessibleDescription = "Typ av transaktion";
            addTransactionTypeComboBox.Dock = DockStyle.Fill;
            addTransactionTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
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
            addTransactionCategoryLabel.Size = new Size(114, 18);
            addTransactionCategoryLabel.TabIndex = 9;
            addTransactionCategoryLabel.Text = "Ange kategori";
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
            addTransactionPanel.BackColor = Color.White;
            addTransactionPanel.ColumnCount = 2;
            addTransactionPanel.ColumnStyles.Add(new ColumnStyle());
            addTransactionPanel.ColumnStyles.Add(new ColumnStyle());
            addTransactionPanel.Controls.Add(addTransactionTypeLabel, 0, 0);
            addTransactionPanel.Controls.Add(addTransactionAmountLabel, 0, 3);
            addTransactionPanel.Controls.Add(addTransactionTypeComboBox, 1, 0);
            addTransactionPanel.Controls.Add(addTransactionCategoryLabel, 0, 2);
            addTransactionPanel.Controls.Add(addTransactionNameLabel, 0, 1);
            addTransactionPanel.Controls.Add(addTransactionTitleText, 1, 1);
            addTransactionPanel.Controls.Add(addTransactionAmountNum, 1, 3);
            addTransactionPanel.Controls.Add(addTransactionDatePicker, 1, 4);
            addTransactionPanel.Controls.Add(addTransactionDateLabel, 0, 4);
            addTransactionPanel.Controls.Add(flowLayoutPanel2, 1, 6);
            addTransactionPanel.Controls.Add(flowLayoutPanel1, 1, 5);
            addTransactionPanel.Controls.Add(addTransactionCategoryCombo, 1, 2);
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
            addTransactionDatePicker.Size = new Size(345, 26);
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
            saveAddTransactionBtn.BackColor = Color.FromArgb(1, 170, 50);
            saveAddTransactionBtn.Cursor = Cursors.Hand;
            saveAddTransactionBtn.Location = new Point(10, 10);
            saveAddTransactionBtn.Margin = new Padding(10);
            saveAddTransactionBtn.Name = "saveAddTransactionBtn";
            saveAddTransactionBtn.Size = new Size(167, 46);
            saveAddTransactionBtn.TabIndex = 5;
            saveAddTransactionBtn.Text = "Spara transaktionen";
            saveAddTransactionBtn.UseVisualStyleBackColor = false;
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
            addTransactionCancelBtn.Text = "Återställ";
            addTransactionCancelBtn.UseVisualStyleBackColor = true;
            addTransactionCancelBtn.Click += addTransactionCancelBtn_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(msgLabel);
            flowLayoutPanel1.Location = new Point(192, 255);
            flowLayoutPanel1.Margin = new Padding(5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5);
            flowLayoutPanel1.Size = new Size(16, 28);
            flowLayoutPanel1.TabIndex = 12;
            // 
            // msgLabel
            // 
            msgLabel.AutoSize = true;
            msgLabel.Location = new Point(8, 5);
            msgLabel.Name = "msgLabel";
            msgLabel.Size = new Size(0, 18);
            msgLabel.TabIndex = 7;
            // 
            // addTransactionCategoryCombo
            // 
            addTransactionCategoryCombo.AutoCompleteMode = AutoCompleteMode.Suggest;
            addTransactionCategoryCombo.AutoCompleteSource = AutoCompleteSource.ListItems;
            addTransactionCategoryCombo.FormattingEnabled = true;
            addTransactionCategoryCombo.Location = new Point(197, 122);
            addTransactionCategoryCombo.Margin = new Padding(10);
            addTransactionCategoryCombo.MaxDropDownItems = 20;
            addTransactionCategoryCombo.Name = "addTransactionCategoryCombo";
            addTransactionCategoryCombo.Size = new Size(345, 26);
            addTransactionCategoryCombo.TabIndex = 3;
            // 
            // AddTransactionFormReturnBtn
            // 
            AddTransactionFormReturnBtn.BackColor = Color.FromArgb(230, 128, 0);
            AddTransactionFormReturnBtn.Cursor = Cursors.Hand;
            AddTransactionFormReturnBtn.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            AddTransactionFormReturnBtn.IconColor = Color.Black;
            AddTransactionFormReturnBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AddTransactionFormReturnBtn.IconSize = 30;
            AddTransactionFormReturnBtn.ImageAlign = ContentAlignment.MiddleLeft;
            AddTransactionFormReturnBtn.Location = new Point(0, 500);
            AddTransactionFormReturnBtn.Name = "AddTransactionFormReturnBtn";
            AddTransactionFormReturnBtn.Size = new Size(147, 58);
            AddTransactionFormReturnBtn.TabIndex = 12;
            AddTransactionFormReturnBtn.Text = "Transaktioner";
            AddTransactionFormReturnBtn.TextAlign = ContentAlignment.MiddleRight;
            AddTransactionFormReturnBtn.UseVisualStyleBackColor = false;
            AddTransactionFormReturnBtn.Click += AddTransactionFormReturnBtn_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            menuStrip1.BackColor = Color.FromArgb(192, 255, 192);
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { appToolStripMenuItem, hjälpToolStripMenuItem });
            menuStrip1.Location = new Point(1079, 9);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(96, 24);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // appToolStripMenuItem
            // 
            appToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { avslutaToolStripMenuItem });
            appToolStripMenuItem.Name = "appToolStripMenuItem";
            appToolStripMenuItem.Size = new Size(41, 20);
            appToolStripMenuItem.Text = "&App";
            // 
            // avslutaToolStripMenuItem
            // 
            avslutaToolStripMenuItem.Name = "avslutaToolStripMenuItem";
            avslutaToolStripMenuItem.Size = new Size(113, 22);
            avslutaToolStripMenuItem.Text = "A&vsluta";
            avslutaToolStripMenuItem.Click += avslutaToolStripMenuItem_Click;
            // 
            // hjälpToolStripMenuItem
            // 
            hjälpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { omToolStripMenuItem });
            hjälpToolStripMenuItem.Name = "hjälpToolStripMenuItem";
            hjälpToolStripMenuItem.Size = new Size(47, 20);
            hjälpToolStripMenuItem.Text = "&Hjälp";
            // 
            // omToolStripMenuItem
            // 
            omToolStripMenuItem.Name = "omToolStripMenuItem";
            omToolStripMenuItem.Size = new Size(94, 22);
            omToolStripMenuItem.Text = "&Om";
            omToolStripMenuItem.Click += omToolStripMenuItem_Click;
            // 
            // AddTransactionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 245, 247);
            ClientSize = new Size(1184, 561);
            Controls.Add(menuStrip1);
            Controls.Add(AddTransactionFormReturnBtn);
            Controls.Add(addTransactionPanel);
            Controls.Add(addTransactionLabel);
            Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "AddTransactionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ny transaktion";
            Load += AddTransactionForm_Load;
            ((System.ComponentModel.ISupportInitialize)addTransactionAmountNum).EndInit();
            addTransactionPanel.ResumeLayout(false);
            addTransactionPanel.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label addTransactionLabel;
        private ComboBox addTransactionTypeComboBox;
        private TextBox addTransactionTitleText;
        private NumericUpDown addTransactionAmountNum;
        private Label addTransactionTypeLabel;
        private Label addTransactionNameLabel;
        private Label addTransactionCategoryLabel;
        private Label addTransactionAmountLabel;
        private TableLayoutPanel addTransactionPanel;
        private Label addTransactionDateLabel;
        private DateTimePicker addTransactionDatePicker;
        private Button addTransactionCancelBtn;
        private Button saveAddTransactionBtn;
        private Label msgLabel;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FontAwesome.Sharp.IconButton AddTransactionFormReturnBtn;
        private ComboBox addTransactionCategoryCombo;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem appToolStripMenuItem;
        private ToolStripMenuItem avslutaToolStripMenuItem;
        private ToolStripMenuItem hjälpToolStripMenuItem;
        private ToolStripMenuItem omToolStripMenuItem;
    }
}