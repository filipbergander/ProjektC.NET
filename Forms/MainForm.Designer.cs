namespace Projekt.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            mainFormDashboardLabel = new Label();
            mainFormMonthLabel = new Label();
            mainFormIncomeLabel = new Label();
            mainFormExpenseLabel = new Label();
            mainFormTransactionBtn = new Button();
            mainFormSavingsBtn = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            monthQuantityLabel = new Label();
            totalIncomeLabel = new Label();
            monthValueLabel = new Label();
            totalExpenseLabel = new Label();
            mainFormQuantityLabel = new Label();
            chartPanel = new Panel();
            noTransactionsLabel = new Label();
            mainFormRegisterBtn = new Button();
            panel1 = new Panel();
            loggedInPanel = new Panel();
            roleLabel = new Label();
            usernameLabel = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            loggedInPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // mainFormDashboardLabel
            // 
            mainFormDashboardLabel.AutoSize = true;
            mainFormDashboardLabel.Font = new Font("Lucida Sans", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mainFormDashboardLabel.ForeColor = Color.FromArgb(43, 45, 66);
            mainFormDashboardLabel.Location = new Point(550, 25);
            mainFormDashboardLabel.Margin = new Padding(4, 0, 4, 0);
            mainFormDashboardLabel.Name = "mainFormDashboardLabel";
            mainFormDashboardLabel.Size = new Size(102, 23);
            mainFormDashboardLabel.TabIndex = 0;
            mainFormDashboardLabel.Text = "Översikt";
            // 
            // mainFormMonthLabel
            // 
            mainFormMonthLabel.AutoSize = true;
            mainFormMonthLabel.Font = new Font("Lucida Sans", 12F);
            mainFormMonthLabel.ForeColor = SystemColors.ControlText;
            mainFormMonthLabel.Location = new Point(13, 10);
            mainFormMonthLabel.Name = "mainFormMonthLabel";
            mainFormMonthLabel.Size = new Size(127, 18);
            mainFormMonthLabel.TabIndex = 1;
            mainFormMonthLabel.Text = "Denna (månad):";
            // 
            // mainFormIncomeLabel
            // 
            mainFormIncomeLabel.AutoSize = true;
            mainFormIncomeLabel.Location = new Point(13, 37);
            mainFormIncomeLabel.Name = "mainFormIncomeLabel";
            mainFormIncomeLabel.Size = new Size(86, 18);
            mainFormIncomeLabel.TabIndex = 2;
            mainFormIncomeLabel.Text = "Inkomster:";
            // 
            // mainFormExpenseLabel
            // 
            mainFormExpenseLabel.AutoSize = true;
            mainFormExpenseLabel.Location = new Point(13, 64);
            mainFormExpenseLabel.Name = "mainFormExpenseLabel";
            mainFormExpenseLabel.Size = new Size(69, 18);
            mainFormExpenseLabel.TabIndex = 3;
            mainFormExpenseLabel.Text = "Utgifter:";
            // 
            // mainFormTransactionBtn
            // 
            mainFormTransactionBtn.BackColor = Color.FromArgb(227, 150, 100);
            mainFormTransactionBtn.Cursor = Cursors.Hand;
            mainFormTransactionBtn.Location = new Point(10, 80);
            mainFormTransactionBtn.Name = "mainFormTransactionBtn";
            mainFormTransactionBtn.Size = new Size(157, 43);
            mainFormTransactionBtn.TabIndex = 4;
            mainFormTransactionBtn.Text = "Dina transaktioner";
            mainFormTransactionBtn.UseVisualStyleBackColor = false;
            mainFormTransactionBtn.Click += mainFormTransactionBtn_Click;
            // 
            // mainFormSavingsBtn
            // 
            mainFormSavingsBtn.BackColor = Color.FromArgb(1, 170, 50);
            mainFormSavingsBtn.Cursor = Cursors.Hand;
            mainFormSavingsBtn.Location = new Point(10, 132);
            mainFormSavingsBtn.Name = "mainFormSavingsBtn";
            mainFormSavingsBtn.Size = new Size(157, 43);
            mainFormSavingsBtn.TabIndex = 5;
            mainFormSavingsBtn.Text = "Ditt sparande";
            mainFormSavingsBtn.UseVisualStyleBackColor = false;
            mainFormSavingsBtn.Click += mainFormSavingsBtn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.None;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(monthQuantityLabel, 1, 3);
            tableLayoutPanel1.Controls.Add(totalIncomeLabel, 1, 1);
            tableLayoutPanel1.Controls.Add(monthValueLabel, 1, 0);
            tableLayoutPanel1.Controls.Add(mainFormIncomeLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(mainFormExpenseLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(mainFormMonthLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(totalExpenseLabel, 1, 2);
            tableLayoutPanel1.Controls.Add(mainFormQuantityLabel, 0, 3);
            tableLayoutPanel1.Location = new Point(208, 95);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(422, 130);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // monthQuantityLabel
            // 
            monthQuantityLabel.AutoSize = true;
            monthQuantityLabel.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            monthQuantityLabel.Location = new Point(173, 91);
            monthQuantityLabel.Name = "monthQuantityLabel";
            monthQuantityLabel.Size = new Size(56, 18);
            monthQuantityLabel.TabIndex = 11;
            monthQuantityLabel.Text = "label1";
            // 
            // totalIncomeLabel
            // 
            totalIncomeLabel.AutoSize = true;
            totalIncomeLabel.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalIncomeLabel.ForeColor = Color.SeaGreen;
            totalIncomeLabel.Location = new Point(173, 37);
            totalIncomeLabel.Name = "totalIncomeLabel";
            totalIncomeLabel.Size = new Size(56, 18);
            totalIncomeLabel.TabIndex = 8;
            totalIncomeLabel.Text = "label1";
            // 
            // monthValueLabel
            // 
            monthValueLabel.AutoSize = true;
            monthValueLabel.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            monthValueLabel.Location = new Point(173, 10);
            monthValueLabel.Name = "monthValueLabel";
            monthValueLabel.Size = new Size(56, 18);
            monthValueLabel.TabIndex = 7;
            monthValueLabel.Text = "label1";
            // 
            // totalExpenseLabel
            // 
            totalExpenseLabel.AutoSize = true;
            totalExpenseLabel.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalExpenseLabel.ForeColor = Color.Firebrick;
            totalExpenseLabel.Location = new Point(173, 64);
            totalExpenseLabel.Name = "totalExpenseLabel";
            totalExpenseLabel.Size = new Size(56, 18);
            totalExpenseLabel.TabIndex = 9;
            totalExpenseLabel.Text = "label1";
            // 
            // mainFormQuantityLabel
            // 
            mainFormQuantityLabel.AutoSize = true;
            mainFormQuantityLabel.Location = new Point(13, 91);
            mainFormQuantityLabel.Name = "mainFormQuantityLabel";
            mainFormQuantityLabel.Size = new Size(154, 18);
            mainFormQuantityLabel.TabIndex = 10;
            mainFormQuantityLabel.Text = "Antal transaktioner:";
            // 
            // chartPanel
            // 
            chartPanel.BackColor = SystemColors.ButtonFace;
            chartPanel.Location = new Point(636, 95);
            chartPanel.Name = "chartPanel";
            chartPanel.Size = new Size(536, 454);
            chartPanel.TabIndex = 7;
            // 
            // noTransactionsLabel
            // 
            noTransactionsLabel.AutoSize = true;
            noTransactionsLabel.Font = new Font("Lucida Sans", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            noTransactionsLabel.ForeColor = Color.Red;
            noTransactionsLabel.Location = new Point(823, 67);
            noTransactionsLabel.Name = "noTransactionsLabel";
            noTransactionsLabel.Size = new Size(197, 17);
            noTransactionsLabel.TabIndex = 8;
            noTransactionsLabel.Text = "Inga utgifter är tillagda..";
            noTransactionsLabel.Visible = false;
            // 
            // mainFormRegisterBtn
            // 
            mainFormRegisterBtn.BackColor = Color.FromArgb(72, 202, 228);
            mainFormRegisterBtn.Cursor = Cursors.Hand;
            mainFormRegisterBtn.Location = new Point(10, 186);
            mainFormRegisterBtn.Name = "mainFormRegisterBtn";
            mainFormRegisterBtn.Size = new Size(157, 57);
            mainFormRegisterBtn.TabIndex = 8;
            mainFormRegisterBtn.Text = "Skapa ny användare";
            mainFormRegisterBtn.UseVisualStyleBackColor = false;
            mainFormRegisterBtn.Click += mainFormRegisterBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(loggedInPanel);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(mainFormRegisterBtn);
            panel1.Controls.Add(mainFormSavingsBtn);
            panel1.Controls.Add(mainFormTransactionBtn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(185, 561);
            panel1.TabIndex = 9;
            // 
            // loggedInPanel
            // 
            loggedInPanel.BackColor = Color.Gainsboro;
            loggedInPanel.Controls.Add(roleLabel);
            loggedInPanel.Controls.Add(usernameLabel);
            loggedInPanel.Controls.Add(label2);
            loggedInPanel.Location = new Point(12, 456);
            loggedInPanel.Name = "loggedInPanel";
            loggedInPanel.Size = new Size(157, 78);
            loggedInPanel.TabIndex = 11;
            loggedInPanel.Visible = false;
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Font = new Font("Lucida Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roleLabel.ForeColor = Color.FromArgb(43, 45, 66);
            roleLabel.Location = new Point(20, 55);
            roleLabel.Margin = new Padding(4, 0, 4, 0);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(46, 15);
            roleLabel.TabIndex = 14;
            roleLabel.Text = "Admin";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Lucida Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameLabel.ForeColor = Color.FromArgb(43, 45, 66);
            usernameLabel.Location = new Point(20, 31);
            usernameLabel.Margin = new Padding(4, 0, 4, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(36, 15);
            usernameLabel.TabIndex = 13;
            usernameLabel.Text = "User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(43, 45, 66);
            label2.Location = new Point(20, 9);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(107, 17);
            label2.TabIndex = 12;
            label2.Text = "Inloggad som";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(43, 45, 66);
            label1.Location = new Point(59, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 22);
            label1.TabIndex = 10;
            label1.Text = "Meny";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(191, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 58);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 245, 247);
            ClientSize = new Size(1184, 561);
            Controls.Add(pictureBox1);
            Controls.Add(noTransactionsLabel);
            Controls.Add(panel1);
            Controls.Add(chartPanel);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(mainFormDashboardLabel);
            Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fickan - Översikt";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            loggedInPanel.ResumeLayout(false);
            loggedInPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mainFormDashboardLabel;
        private Label mainFormMonthLabel;
        private Label mainFormIncomeLabel;
        private Label mainFormExpenseLabel;
        private Button mainFormTransactionBtn;
        private Button mainFormSavingsBtn;
        private TableLayoutPanel tableLayoutPanel1;
        private Label monthValueLabel;
        private Label totalIncomeLabel;
        private Label totalExpenseLabel;
        private Panel chartPanel;
        private Label mainFormQuantityLabel;
        private Label monthQuantityLabel;
        private Button mainFormRegisterBtn;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel loggedInPanel;
        private Label noTransactionsLabel;
        private Label usernameLabel;
        private Label roleLabel;
        private PictureBox pictureBox1;
    }
}