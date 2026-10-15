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
            mainFormStatsBtn = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            totalIncomeLabel = new Label();
            monthValueLabel = new Label();
            totalExpenseLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // mainFormDashboardLabel
            // 
            mainFormDashboardLabel.AutoSize = true;
            mainFormDashboardLabel.Location = new Point(550, 97);
            mainFormDashboardLabel.Margin = new Padding(4, 0, 4, 0);
            mainFormDashboardLabel.Name = "mainFormDashboardLabel";
            mainFormDashboardLabel.Size = new Size(70, 18);
            mainFormDashboardLabel.TabIndex = 0;
            mainFormDashboardLabel.Text = "Översikt";
            // 
            // mainFormMonthLabel
            // 
            mainFormMonthLabel.AutoSize = true;
            mainFormMonthLabel.Font = new Font("Lucida Sans", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mainFormMonthLabel.ForeColor = Color.Gray;
            mainFormMonthLabel.Location = new Point(13, 10);
            mainFormMonthLabel.Name = "mainFormMonthLabel";
            mainFormMonthLabel.Size = new Size(119, 17);
            mainFormMonthLabel.TabIndex = 1;
            mainFormMonthLabel.Text = "Denna (månad):";
            // 
            // mainFormIncomeLabel
            // 
            mainFormIncomeLabel.AutoSize = true;
            mainFormIncomeLabel.Location = new Point(13, 57);
            mainFormIncomeLabel.Name = "mainFormIncomeLabel";
            mainFormIncomeLabel.Size = new Size(86, 18);
            mainFormIncomeLabel.TabIndex = 2;
            mainFormIncomeLabel.Text = "Inkomster:";
            // 
            // mainFormExpenseLabel
            // 
            mainFormExpenseLabel.AutoSize = true;
            mainFormExpenseLabel.Location = new Point(13, 104);
            mainFormExpenseLabel.Name = "mainFormExpenseLabel";
            mainFormExpenseLabel.Size = new Size(69, 18);
            mainFormExpenseLabel.TabIndex = 3;
            mainFormExpenseLabel.Text = "Utgifter:";
            // 
            // mainFormTransactionBtn
            // 
            mainFormTransactionBtn.Location = new Point(423, 410);
            mainFormTransactionBtn.Name = "mainFormTransactionBtn";
            mainFormTransactionBtn.Size = new Size(125, 40);
            mainFormTransactionBtn.TabIndex = 4;
            mainFormTransactionBtn.Text = "Transaktioner";
            mainFormTransactionBtn.UseVisualStyleBackColor = true;
            mainFormTransactionBtn.Click += mainFormTransactionBtn_Click;
            // 
            // mainFormStatsBtn
            // 
            mainFormStatsBtn.Location = new Point(617, 410);
            mainFormStatsBtn.Name = "mainFormStatsBtn";
            mainFormStatsBtn.Size = new Size(125, 40);
            mainFormStatsBtn.TabIndex = 5;
            mainFormStatsBtn.Text = "Statistik";
            mainFormStatsBtn.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.BackColor = Color.Khaki;
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.None;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(totalIncomeLabel, 1, 1);
            tableLayoutPanel1.Controls.Add(monthValueLabel, 1, 0);
            tableLayoutPanel1.Controls.Add(mainFormIncomeLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(mainFormExpenseLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(mainFormMonthLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(totalExpenseLabel, 1, 2);
            tableLayoutPanel1.Location = new Point(372, 172);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(422, 162);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // totalIncomeLabel
            // 
            totalIncomeLabel.AutoSize = true;
            totalIncomeLabel.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalIncomeLabel.ForeColor = Color.SeaGreen;
            totalIncomeLabel.Location = new Point(138, 57);
            totalIncomeLabel.Name = "totalIncomeLabel";
            totalIncomeLabel.Size = new Size(56, 18);
            totalIncomeLabel.TabIndex = 8;
            totalIncomeLabel.Text = "label1";
            // 
            // monthValueLabel
            // 
            monthValueLabel.AutoSize = true;
            monthValueLabel.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            monthValueLabel.Location = new Point(138, 10);
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
            totalExpenseLabel.Location = new Point(138, 104);
            totalExpenseLabel.Name = "totalExpenseLabel";
            totalExpenseLabel.Size = new Size(56, 18);
            totalExpenseLabel.TabIndex = 9;
            totalExpenseLabel.Text = "label1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1184, 561);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(mainFormStatsBtn);
            Controls.Add(mainFormTransactionBtn);
            Controls.Add(mainFormDashboardLabel);
            Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Översikt konto";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mainFormDashboardLabel;
        private Label mainFormMonthLabel;
        private Label mainFormIncomeLabel;
        private Label mainFormExpenseLabel;
        private Button mainFormTransactionBtn;
        private Button mainFormStatsBtn;
        private TableLayoutPanel tableLayoutPanel1;
        private Label monthValueLabel;
        private Label totalIncomeLabel;
        private Label totalExpenseLabel;
    }
}