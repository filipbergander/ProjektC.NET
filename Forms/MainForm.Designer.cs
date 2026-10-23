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
            tableLayoutPanel1 = new TableLayoutPanel();
            monthQuantityLabel = new Label();
            totalIncomeLabel = new Label();
            monthValueLabel = new Label();
            totalExpenseLabel = new Label();
            mainFormQuantityLabel = new Label();
            chartPanel = new Panel();
            noTransactionsLabel = new Label();
            panel1 = new Panel();
            mainFormRegisterBtn = new FontAwesome.Sharp.IconButton();
            mainFormTransactionBtn = new FontAwesome.Sharp.IconButton();
            mainFormSavingsBtn = new FontAwesome.Sharp.IconButton();
            loggedInPanel = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            roleLabel = new Label();
            usernameLabel = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            loggedInPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
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
            mainFormMonthLabel.Location = new Point(8, 5);
            mainFormMonthLabel.Name = "mainFormMonthLabel";
            mainFormMonthLabel.Size = new Size(127, 18);
            mainFormMonthLabel.TabIndex = 1;
            mainFormMonthLabel.Text = "Denna (månad):";
            // 
            // mainFormIncomeLabel
            // 
            mainFormIncomeLabel.AutoSize = true;
            mainFormIncomeLabel.Location = new Point(8, 35);
            mainFormIncomeLabel.Name = "mainFormIncomeLabel";
            mainFormIncomeLabel.Size = new Size(86, 18);
            mainFormIncomeLabel.TabIndex = 2;
            mainFormIncomeLabel.Text = "Inkomster:";
            // 
            // mainFormExpenseLabel
            // 
            mainFormExpenseLabel.AutoSize = true;
            mainFormExpenseLabel.Location = new Point(8, 65);
            mainFormExpenseLabel.Name = "mainFormExpenseLabel";
            mainFormExpenseLabel.Size = new Size(69, 18);
            mainFormExpenseLabel.TabIndex = 3;
            mainFormExpenseLabel.Text = "Utgifter:";
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
            tableLayoutPanel1.ImeMode = ImeMode.Disable;
            tableLayoutPanel1.Location = new Point(208, 95);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(5);
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
            monthQuantityLabel.Location = new Point(168, 95);
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
            totalIncomeLabel.Location = new Point(168, 35);
            totalIncomeLabel.Name = "totalIncomeLabel";
            totalIncomeLabel.Size = new Size(56, 18);
            totalIncomeLabel.TabIndex = 8;
            totalIncomeLabel.Text = "label1";
            // 
            // monthValueLabel
            // 
            monthValueLabel.AutoSize = true;
            monthValueLabel.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            monthValueLabel.Location = new Point(168, 5);
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
            totalExpenseLabel.Location = new Point(168, 65);
            totalExpenseLabel.Name = "totalExpenseLabel";
            totalExpenseLabel.Size = new Size(56, 18);
            totalExpenseLabel.TabIndex = 9;
            totalExpenseLabel.Text = "label1";
            // 
            // mainFormQuantityLabel
            // 
            mainFormQuantityLabel.AutoSize = true;
            mainFormQuantityLabel.Location = new Point(8, 95);
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
            chartPanel.TabStop = true;
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
            // panel1
            // 
            panel1.BackColor = SystemColors.Menu;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(mainFormRegisterBtn);
            panel1.Controls.Add(mainFormTransactionBtn);
            panel1.Controls.Add(mainFormSavingsBtn);
            panel1.Controls.Add(loggedInPanel);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(185, 561);
            panel1.TabIndex = 9;
            // 
            // mainFormRegisterBtn
            // 
            mainFormRegisterBtn.BackColor = Color.FromArgb(72, 202, 228);
            mainFormRegisterBtn.Cursor = Cursors.Hand;
            mainFormRegisterBtn.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            mainFormRegisterBtn.IconColor = Color.Black;
            mainFormRegisterBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            mainFormRegisterBtn.IconSize = 30;
            mainFormRegisterBtn.ImageAlign = ContentAlignment.MiddleLeft;
            mainFormRegisterBtn.Location = new Point(22, 225);
            mainFormRegisterBtn.Name = "mainFormRegisterBtn";
            mainFormRegisterBtn.Padding = new Padding(5, 0, 0, 0);
            mainFormRegisterBtn.Size = new Size(147, 57);
            mainFormRegisterBtn.TabIndex = 3;
            mainFormRegisterBtn.Text = "Skapa ny användare";
            mainFormRegisterBtn.UseVisualStyleBackColor = false;
            mainFormRegisterBtn.Click += mainFormRegisterBtn_Click;
            // 
            // mainFormTransactionBtn
            // 
            mainFormTransactionBtn.BackColor = Color.FromArgb(227, 150, 100);
            mainFormTransactionBtn.Cursor = Cursors.Hand;
            mainFormTransactionBtn.IconChar = FontAwesome.Sharp.IconChar.ExchangeAlt;
            mainFormTransactionBtn.IconColor = Color.Black;
            mainFormTransactionBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            mainFormTransactionBtn.IconSize = 30;
            mainFormTransactionBtn.ImageAlign = ContentAlignment.TopLeft;
            mainFormTransactionBtn.Location = new Point(22, 80);
            mainFormTransactionBtn.Name = "mainFormTransactionBtn";
            mainFormTransactionBtn.Padding = new Padding(5, 0, 0, 0);
            mainFormTransactionBtn.Size = new Size(147, 51);
            mainFormTransactionBtn.TabIndex = 1;
            mainFormTransactionBtn.Text = "Dina transaktioner";
            mainFormTransactionBtn.UseVisualStyleBackColor = false;
            mainFormTransactionBtn.Click += mainFormTransactionBtn_Click;
            // 
            // mainFormSavingsBtn
            // 
            mainFormSavingsBtn.BackColor = Color.FromArgb(1, 170, 50);
            mainFormSavingsBtn.Cursor = Cursors.Hand;
            mainFormSavingsBtn.IconChar = FontAwesome.Sharp.IconChar.PiggyBank;
            mainFormSavingsBtn.IconColor = Color.Black;
            mainFormSavingsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            mainFormSavingsBtn.IconSize = 30;
            mainFormSavingsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            mainFormSavingsBtn.Location = new Point(22, 150);
            mainFormSavingsBtn.Name = "mainFormSavingsBtn";
            mainFormSavingsBtn.Padding = new Padding(5, 0, 0, 0);
            mainFormSavingsBtn.Size = new Size(147, 54);
            mainFormSavingsBtn.TabIndex = 2;
            mainFormSavingsBtn.Text = "Ditt sparande";
            mainFormSavingsBtn.TextAlign = ContentAlignment.MiddleRight;
            mainFormSavingsBtn.UseVisualStyleBackColor = false;
            mainFormSavingsBtn.Click += mainFormSavingsBtn_Click;
            // 
            // loggedInPanel
            // 
            loggedInPanel.BackColor = Color.Gainsboro;
            loggedInPanel.Controls.Add(iconPictureBox1);
            loggedInPanel.Controls.Add(roleLabel);
            loggedInPanel.Controls.Add(usernameLabel);
            loggedInPanel.Controls.Add(label2);
            loggedInPanel.Location = new Point(12, 456);
            loggedInPanel.Name = "loggedInPanel";
            loggedInPanel.Size = new Size(157, 78);
            loggedInPanel.TabIndex = 11;
            loggedInPanel.Visible = false;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Gainsboro;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserSecret;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 21;
            iconPictureBox1.Location = new Point(3, 6);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(21, 23);
            iconPictureBox1.TabIndex = 15;
            iconPictureBox1.TabStop = false;
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
            pictureBox1.Location = new Point(221, 462);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(352, 87);
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
            Text = "BudgetKoll - Översikt";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            loggedInPanel.ResumeLayout(false);
            loggedInPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mainFormDashboardLabel;
        private Label mainFormMonthLabel;
        private Label mainFormIncomeLabel;
        private Label mainFormExpenseLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private Label monthValueLabel;
        private Label totalIncomeLabel;
        private Label totalExpenseLabel;
        private Panel chartPanel;
        private Label mainFormQuantityLabel;
        private Label monthQuantityLabel;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel loggedInPanel;
        private Label noTransactionsLabel;
        private Label usernameLabel;
        private Label roleLabel;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton mainFormSavingsBtn;
        private FontAwesome.Sharp.IconButton mainFormTransactionBtn;
        private FontAwesome.Sharp.IconButton mainFormRegisterBtn;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}