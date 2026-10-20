namespace Projekt.Forms
{
    partial class SavingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SavingsForm));
            savingsHeaderLabel = new Label();
            savingsFormReturnBtn = new Button();
            anticipateSavingsBtn = new Button();
            playChallangeBtn = new Button();
            anticipateSavingsPanel = new Panel();
            closeCalculatorPanelBtn = new Button();
            calculateSavingsButton = new Button();
            savingsYearGoalLabel = new Label();
            savingsYearGoalNum = new NumericUpDown();
            yearlyInterestLabel = new Label();
            yearlyInterestNum = new NumericUpDown();
            monthlyAmountLabel = new Label();
            monthlyAmountNum = new NumericUpDown();
            startAmountLabel = new Label();
            startAmountNum = new NumericUpDown();
            anticipateSavingsLabel = new Label();
            totalSumSavingsText = new TextBox();
            totalSumSavingsLabel = new Label();
            totalSavingsPanel = new Panel();
            interestSumLabel = new Label();
            interestSumText = new TextBox();
            equityLabel = new Label();
            equityLabelText = new TextBox();
            savingsPanel = new Panel();
            panel3 = new Panel();
            label5 = new Label();
            checkBox1 = new CheckBox();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            panelCalculatorHeaderLabel = new Label();
            openToolsSavingBtn = new Button();
            anticipateSavingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)savingsYearGoalNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yearlyInterestNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)monthlyAmountNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)startAmountNum).BeginInit();
            totalSavingsPanel.SuspendLayout();
            savingsPanel.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // savingsHeaderLabel
            // 
            savingsHeaderLabel.AutoSize = true;
            savingsHeaderLabel.Location = new Point(556, 20);
            savingsHeaderLabel.Name = "savingsHeaderLabel";
            savingsHeaderLabel.Size = new Size(197, 18);
            savingsHeaderLabel.TabIndex = 0;
            savingsHeaderLabel.Text = "Verktyg för ditt sparande";
            // 
            // savingsFormReturnBtn
            // 
            savingsFormReturnBtn.Anchor = AnchorStyles.Left;
            savingsFormReturnBtn.AutoSize = true;
            savingsFormReturnBtn.Cursor = Cursors.Hand;
            savingsFormReturnBtn.Location = new Point(19, 504);
            savingsFormReturnBtn.Margin = new Padding(10);
            savingsFormReturnBtn.Name = "savingsFormReturnBtn";
            savingsFormReturnBtn.Padding = new Padding(5);
            savingsFormReturnBtn.Size = new Size(111, 38);
            savingsFormReturnBtn.TabIndex = 1;
            savingsFormReturnBtn.Text = "Gå tillbaka";
            savingsFormReturnBtn.UseVisualStyleBackColor = true;
            savingsFormReturnBtn.Click += savingsFormReturnBtn_Click;
            // 
            // anticipateSavingsBtn
            // 
            anticipateSavingsBtn.BackColor = SystemColors.ActiveCaption;
            anticipateSavingsBtn.Cursor = Cursors.Hand;
            anticipateSavingsBtn.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            anticipateSavingsBtn.Location = new Point(77, 293);
            anticipateSavingsBtn.Name = "anticipateSavingsBtn";
            anticipateSavingsBtn.Size = new Size(195, 48);
            anticipateSavingsBtn.TabIndex = 2;
            anticipateSavingsBtn.Text = "Öppna sparkalkylator";
            anticipateSavingsBtn.UseVisualStyleBackColor = false;
            anticipateSavingsBtn.Click += anticipateSavingsBtn_Click;
            // 
            // playChallangeBtn
            // 
            playChallangeBtn.BackColor = Color.LightGray;
            playChallangeBtn.Cursor = Cursors.Hand;
            playChallangeBtn.Enabled = false;
            playChallangeBtn.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            playChallangeBtn.Location = new Point(103, 293);
            playChallangeBtn.Name = "playChallangeBtn";
            playChallangeBtn.Size = new Size(154, 48);
            playChallangeBtn.TabIndex = 3;
            playChallangeBtn.Text = "Spela nu";
            playChallangeBtn.UseVisualStyleBackColor = false;
            playChallangeBtn.Click += playChallangeBtn_Click;
            // 
            // anticipateSavingsPanel
            // 
            anticipateSavingsPanel.BackColor = SystemColors.ActiveCaption;
            anticipateSavingsPanel.Controls.Add(closeCalculatorPanelBtn);
            anticipateSavingsPanel.Controls.Add(calculateSavingsButton);
            anticipateSavingsPanel.Controls.Add(savingsYearGoalLabel);
            anticipateSavingsPanel.Controls.Add(savingsYearGoalNum);
            anticipateSavingsPanel.Controls.Add(yearlyInterestLabel);
            anticipateSavingsPanel.Controls.Add(yearlyInterestNum);
            anticipateSavingsPanel.Controls.Add(monthlyAmountLabel);
            anticipateSavingsPanel.Controls.Add(monthlyAmountNum);
            anticipateSavingsPanel.Controls.Add(startAmountLabel);
            anticipateSavingsPanel.Controls.Add(startAmountNum);
            anticipateSavingsPanel.Controls.Add(anticipateSavingsLabel);
            anticipateSavingsPanel.Location = new Point(0, 3);
            anticipateSavingsPanel.Name = "anticipateSavingsPanel";
            anticipateSavingsPanel.Size = new Size(200, 488);
            anticipateSavingsPanel.TabIndex = 4;
            anticipateSavingsPanel.Visible = false;
            // 
            // closeCalculatorPanelBtn
            // 
            closeCalculatorPanelBtn.Cursor = Cursors.Hand;
            closeCalculatorPanelBtn.Font = new Font("Lucida Sans", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeCalculatorPanelBtn.ForeColor = Color.Black;
            closeCalculatorPanelBtn.Location = new Point(169, 3);
            closeCalculatorPanelBtn.Name = "closeCalculatorPanelBtn";
            closeCalculatorPanelBtn.Size = new Size(28, 31);
            closeCalculatorPanelBtn.TabIndex = 19;
            closeCalculatorPanelBtn.Text = "X";
            closeCalculatorPanelBtn.UseVisualStyleBackColor = true;
            closeCalculatorPanelBtn.Click += closeCalculatorPanelBtn_Click;
            // 
            // calculateSavingsButton
            // 
            calculateSavingsButton.BackColor = Color.FromArgb(0, 192, 0);
            calculateSavingsButton.Cursor = Cursors.Hand;
            calculateSavingsButton.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            calculateSavingsButton.Location = new Point(19, 421);
            calculateSavingsButton.Name = "calculateSavingsButton";
            calculateSavingsButton.Padding = new Padding(2);
            calculateSavingsButton.Size = new Size(156, 52);
            calculateSavingsButton.TabIndex = 9;
            calculateSavingsButton.Text = "Starta beräkning";
            calculateSavingsButton.UseVisualStyleBackColor = false;
            calculateSavingsButton.Click += calculateSavingsButton_Click;
            // 
            // savingsYearGoalLabel
            // 
            savingsYearGoalLabel.AutoSize = true;
            savingsYearGoalLabel.Location = new Point(12, 315);
            savingsYearGoalLabel.Name = "savingsYearGoalLabel";
            savingsYearGoalLabel.Size = new Size(91, 18);
            savingsYearGoalLabel.TabIndex = 8;
            savingsYearGoalLabel.Text = "Spartid (år)";
            // 
            // savingsYearGoalNum
            // 
            savingsYearGoalNum.Location = new Point(12, 336);
            savingsYearGoalNum.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            savingsYearGoalNum.Name = "savingsYearGoalNum";
            savingsYearGoalNum.Size = new Size(138, 26);
            savingsYearGoalNum.TabIndex = 7;
            savingsYearGoalNum.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // yearlyInterestLabel
            // 
            yearlyInterestLabel.AutoSize = true;
            yearlyInterestLabel.Location = new Point(12, 232);
            yearlyInterestLabel.Name = "yearlyInterestLabel";
            yearlyInterestLabel.Size = new Size(129, 18);
            yearlyInterestLabel.TabIndex = 6;
            yearlyInterestLabel.Text = "Årsavkastning %";
            // 
            // yearlyInterestNum
            // 
            yearlyInterestNum.Location = new Point(12, 253);
            yearlyInterestNum.Name = "yearlyInterestNum";
            yearlyInterestNum.Size = new Size(138, 26);
            yearlyInterestNum.TabIndex = 5;
            yearlyInterestNum.Value = new decimal(new int[] { 6, 0, 0, 0 });
            // 
            // monthlyAmountLabel
            // 
            monthlyAmountLabel.AutoSize = true;
            monthlyAmountLabel.Location = new Point(11, 140);
            monthlyAmountLabel.Name = "monthlyAmountLabel";
            monthlyAmountLabel.Size = new Size(137, 18);
            monthlyAmountLabel.TabIndex = 4;
            monthlyAmountLabel.Text = "Månadssparande";
            // 
            // monthlyAmountNum
            // 
            monthlyAmountNum.Location = new Point(11, 161);
            monthlyAmountNum.Maximum = new decimal(new int[] { 20000, 0, 0, 0 });
            monthlyAmountNum.Name = "monthlyAmountNum";
            monthlyAmountNum.Size = new Size(138, 26);
            monthlyAmountNum.TabIndex = 3;
            monthlyAmountNum.Value = new decimal(new int[] { 500, 0, 0, 0 });
            // 
            // startAmountLabel
            // 
            startAmountLabel.AutoSize = true;
            startAmountLabel.Location = new Point(12, 49);
            startAmountLabel.Name = "startAmountLabel";
            startAmountLabel.Size = new Size(95, 18);
            startAmountLabel.TabIndex = 2;
            startAmountLabel.Text = "Startbelopp";
            // 
            // startAmountNum
            // 
            startAmountNum.Location = new Point(12, 70);
            startAmountNum.Maximum = new decimal(new int[] { 1500000, 0, 0, 0 });
            startAmountNum.Name = "startAmountNum";
            startAmountNum.Size = new Size(138, 26);
            startAmountNum.TabIndex = 1;
            startAmountNum.Value = new decimal(new int[] { 5000, 0, 0, 0 });
            // 
            // anticipateSavingsLabel
            // 
            anticipateSavingsLabel.AutoSize = true;
            anticipateSavingsLabel.Location = new Point(34, 6);
            anticipateSavingsLabel.Name = "anticipateSavingsLabel";
            anticipateSavingsLabel.Size = new Size(116, 18);
            anticipateSavingsLabel.TabIndex = 0;
            anticipateSavingsLabel.Text = "Sparkalkylator";
            // 
            // totalSumSavingsText
            // 
            totalSumSavingsText.Location = new Point(16, 39);
            totalSumSavingsText.Name = "totalSumSavingsText";
            totalSumSavingsText.Size = new Size(181, 26);
            totalSumSavingsText.TabIndex = 5;
            // 
            // totalSumSavingsLabel
            // 
            totalSumSavingsLabel.AutoSize = true;
            totalSumSavingsLabel.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalSumSavingsLabel.Location = new Point(14, 13);
            totalSumSavingsLabel.Name = "totalSumSavingsLabel";
            totalSumSavingsLabel.Size = new Size(196, 18);
            totalSumSavingsLabel.TabIndex = 7;
            totalSumSavingsLabel.Text = "Total summa sparande:";
            // 
            // totalSavingsPanel
            // 
            totalSavingsPanel.BackColor = Color.DarkSeaGreen;
            totalSavingsPanel.Controls.Add(interestSumLabel);
            totalSavingsPanel.Controls.Add(interestSumText);
            totalSavingsPanel.Controls.Add(equityLabel);
            totalSavingsPanel.Controls.Add(equityLabelText);
            totalSavingsPanel.Controls.Add(totalSumSavingsLabel);
            totalSavingsPanel.Controls.Add(totalSumSavingsText);
            totalSavingsPanel.Location = new Point(206, 240);
            totalSavingsPanel.Name = "totalSavingsPanel";
            totalSavingsPanel.Size = new Size(216, 251);
            totalSavingsPanel.TabIndex = 8;
            totalSavingsPanel.Visible = false;
            // 
            // interestSumLabel
            // 
            interestSumLabel.AutoSize = true;
            interestSumLabel.Location = new Point(18, 154);
            interestSumLabel.Name = "interestSumLabel";
            interestSumLabel.Size = new Size(163, 18);
            interestSumLabel.TabIndex = 11;
            interestSumLabel.Text = "Ränta på ränta vinst:";
            // 
            // interestSumText
            // 
            interestSumText.Location = new Point(20, 180);
            interestSumText.Name = "interestSumText";
            interestSumText.Size = new Size(181, 26);
            interestSumText.TabIndex = 10;
            // 
            // equityLabel
            // 
            equityLabel.AutoSize = true;
            equityLabel.Location = new Point(16, 80);
            equityLabel.Name = "equityLabel";
            equityLabel.Size = new Size(139, 18);
            equityLabel.TabIndex = 9;
            equityLabel.Text = "Eget bidragande:";
            // 
            // equityLabelText
            // 
            equityLabelText.Location = new Point(18, 106);
            equityLabelText.Name = "equityLabelText";
            equityLabelText.Size = new Size(181, 26);
            equityLabelText.TabIndex = 8;
            // 
            // savingsPanel
            // 
            savingsPanel.Anchor = AnchorStyles.None;
            savingsPanel.BackColor = Color.Beige;
            savingsPanel.Controls.Add(panel3);
            savingsPanel.Controls.Add(panel2);
            savingsPanel.Location = new Point(226, 108);
            savingsPanel.Name = "savingsPanel";
            savingsPanel.Size = new Size(852, 424);
            savingsPanel.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label5);
            panel3.Controls.Add(checkBox1);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(playChallangeBtn);
            panel3.Location = new Point(429, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(371, 373);
            panel3.TabIndex = 5;
            // 
            // label5
            // 
            label5.Font = new Font("Lucida Sans", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(39, 3);
            label5.Name = "label5";
            label5.Size = new Size(37, 35);
            label5.TabIndex = 6;
            label5.Text = "🎯";
            // 
            // checkBox1
            // 
            checkBox1.Font = new Font("Lucida Sans", 11F);
            checkBox1.Location = new Point(15, 219);
            checkBox1.Name = "checkBox1";
            checkBox1.Padding = new Padding(10, 5, 5, 5);
            checkBox1.Size = new Size(279, 68);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Jag accepterar risken och antar sparutmaningen.";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label4
            // 
            label4.Location = new Point(15, 46);
            label4.Name = "label4";
            label4.Size = new Size(345, 181);
            label4.TabIndex = 5;
            label4.Text = resources.GetString("label4.Text");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(82, 14);
            label3.Name = "label3";
            label3.Size = new Size(212, 22);
            label3.TabIndex = 4;
            label3.Text = "Utmana ditt sparande";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(panelCalculatorHeaderLabel);
            panel2.Controls.Add(anticipateSavingsBtn);
            panel2.Location = new Point(45, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(347, 373);
            panel2.TabIndex = 4;
            // 
            // label1
            // 
            label1.Font = new Font("Lucida Sans", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(62, 3);
            label1.Name = "label1";
            label1.Size = new Size(37, 35);
            label1.TabIndex = 5;
            label1.Text = "💰";
            // 
            // label2
            // 
            label2.Location = new Point(24, 46);
            label2.Name = "label2";
            label2.Size = new Size(303, 181);
            label2.TabIndex = 4;
            label2.Text = "Beräkna hur ditt sparande kan växa över tid med hjälp av ränta på ränta-effekten.\r\n\r\nKalkylen baseras på:\r\n• Startbelopp\r\n• Månadssparande\r\n• Avkastning per år (%)\r\n• Spartid (år)\r\n";
            // 
            // panelCalculatorHeaderLabel
            // 
            panelCalculatorHeaderLabel.Anchor = AnchorStyles.None;
            panelCalculatorHeaderLabel.AutoSize = true;
            panelCalculatorHeaderLabel.Font = new Font("Lucida Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelCalculatorHeaderLabel.Location = new Point(105, 14);
            panelCalculatorHeaderLabel.Name = "panelCalculatorHeaderLabel";
            panelCalculatorHeaderLabel.Size = new Size(143, 22);
            panelCalculatorHeaderLabel.TabIndex = 3;
            panelCalculatorHeaderLabel.Text = "Sparkalkylator";
            // 
            // openToolsSavingBtn
            // 
            openToolsSavingBtn.Cursor = Cursors.Hand;
            openToolsSavingBtn.Location = new Point(556, 54);
            openToolsSavingBtn.Name = "openToolsSavingBtn";
            openToolsSavingBtn.Size = new Size(195, 48);
            openToolsSavingBtn.TabIndex = 5;
            openToolsSavingBtn.Text = "Öppna verktygspanelen";
            openToolsSavingBtn.UseVisualStyleBackColor = true;
            openToolsSavingBtn.Visible = false;
            openToolsSavingBtn.Click += openToolsSavingBtn_Click;
            // 
            // SavingsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1184, 561);
            Controls.Add(openToolsSavingBtn);
            Controls.Add(savingsPanel);
            Controls.Add(totalSavingsPanel);
            Controls.Add(savingsHeaderLabel);
            Controls.Add(anticipateSavingsPanel);
            Controls.Add(savingsFormReturnBtn);
            Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "SavingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sparande";
            anticipateSavingsPanel.ResumeLayout(false);
            anticipateSavingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)savingsYearGoalNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)yearlyInterestNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)monthlyAmountNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)startAmountNum).EndInit();
            totalSavingsPanel.ResumeLayout(false);
            totalSavingsPanel.PerformLayout();
            savingsPanel.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label savingsHeaderLabel;
        private Button savingsFormReturnBtn;
        private Button anticipateSavingsBtn;
        private Button playChallangeBtn;
        private Panel anticipateSavingsPanel;
        private Label anticipateSavingsLabel;
        private Label monthlyAmountLabel;
        private NumericUpDown monthlyAmountNum;
        private Label startAmountLabel;
        private NumericUpDown startAmountNum;
        private Label yearlyInterestLabel;
        private NumericUpDown yearlyInterestNum;
        private Label savingsYearGoalLabel;
        private NumericUpDown savingsYearGoalNum;
        private Button calculateSavingsButton;
        private TextBox totalSumSavingsText;
        private TextBox textBox2;
        private Label totalSumSavingsLabel;
        private Panel totalSavingsPanel;
        private Label equityLabel;
        private TextBox equityLabelText;
        private Label interestSumLabel;
        private TextBox interestSumText;
        private Panel savingsPanel;
        private Panel panel3;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label panelCalculatorHeaderLabel;
        private CheckBox checkBox1;
        private Button closeCalculatorPanelBtn;
        private Button openToolsSavingBtn;
        private Label label1;
        private Label label5;
    }
}