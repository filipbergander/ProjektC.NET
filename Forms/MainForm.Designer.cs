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
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // mainFormDashboardLabel
            // 
            mainFormDashboardLabel.AutoSize = true;
            mainFormDashboardLabel.Location = new Point(550, 25);
            mainFormDashboardLabel.Margin = new Padding(4, 0, 4, 0);
            mainFormDashboardLabel.Name = "mainFormDashboardLabel";
            mainFormDashboardLabel.Size = new Size(70, 18);
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
            mainFormTransactionBtn.Cursor = Cursors.Hand;
            mainFormTransactionBtn.Location = new Point(10, 67);
            mainFormTransactionBtn.Name = "mainFormTransactionBtn";
            mainFormTransactionBtn.Size = new Size(157, 40);
            mainFormTransactionBtn.TabIndex = 4;
            mainFormTransactionBtn.Text = "Dina transaktioner";
            mainFormTransactionBtn.UseVisualStyleBackColor = true;
            mainFormTransactionBtn.Click += mainFormTransactionBtn_Click;
            // 
            // mainFormSavingsBtn
            // 
            mainFormSavingsBtn.Cursor = Cursors.Hand;
            mainFormSavingsBtn.Location = new Point(10, 132);
            mainFormSavingsBtn.Name = "mainFormSavingsBtn";
            mainFormSavingsBtn.Size = new Size(157, 40);
            mainFormSavingsBtn.TabIndex = 5;
            mainFormSavingsBtn.Text = "Ditt sparande";
            mainFormSavingsBtn.UseVisualStyleBackColor = true;
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
            tableLayoutPanel1.Location = new Point(206, 95);
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
            mainFormRegisterBtn.Cursor = Cursors.Hand;
            mainFormRegisterBtn.Location = new Point(10, 199);
            mainFormRegisterBtn.Name = "mainFormRegisterBtn";
            mainFormRegisterBtn.Size = new Size(157, 49);
            mainFormRegisterBtn.TabIndex = 8;
            mainFormRegisterBtn.Text = "Skapa ny användare";
            mainFormRegisterBtn.UseVisualStyleBackColor = true;
            mainFormRegisterBtn.Click += mainFormRegisterBtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 477);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(118, 18);
            label2.TabIndex = 12;
            label2.Text = "Inloggad som:";
            // 
            // panel2
            // 
            panel2.Location = new Point(28, 464);
            panel2.Name = "panel2";
            panel2.Size = new Size(139, 74);
            panel2.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(48, 18);
            label1.TabIndex = 10;
            label1.Text = "Meny";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1184, 561);
            Controls.Add(noTransactionsLabel);
            Controls.Add(panel1);
            Controls.Add(chartPanel);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(mainFormDashboardLabel);
            Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Översikt konto";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel2;
        private Label noTransactionsLabel;
    }
}