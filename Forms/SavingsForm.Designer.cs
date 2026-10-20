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
            savingsPanel = new Panel();
            challengePanel = new Panel();
            panel1 = new Panel();
            totalResultLabel = new Label();
            label11 = new Label();
            bestWinLabel = new Label();
            amountPlayedTodayLabel = new Label();
            addTransactionCancelBtn = new Button();
            initiateChallengeBtn = new Button();
            checkBox1 = new CheckBox();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            panel3 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            panelCalculatorHeaderLabel = new Label();
            progressBar = new ProgressBar();
            totalSumSavingsText = new TextBox();
            totalSumSavingsLabel = new Label();
            totalSavingsPanel = new Panel();
            interestSumLabel = new Label();
            interestSumText = new TextBox();
            equityLabel = new Label();
            equityLabelText = new TextBox();
            openToolsSavingBtn = new Button();
            anticipateSavingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)savingsYearGoalNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yearlyInterestNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)monthlyAmountNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)startAmountNum).BeginInit();
            savingsPanel.SuspendLayout();
            challengePanel.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            totalSavingsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // savingsHeaderLabel
            // 
            savingsHeaderLabel.AutoSize = true;
            savingsHeaderLabel.Location = new Point(526, 19);
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
            playChallangeBtn.BackColor = Color.MediumSeaGreen;
            playChallangeBtn.Cursor = Cursors.Hand;
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
            savingsYearGoalLabel.Location = new Point(12, 296);
            savingsYearGoalLabel.Name = "savingsYearGoalLabel";
            savingsYearGoalLabel.Size = new Size(91, 18);
            savingsYearGoalLabel.TabIndex = 8;
            savingsYearGoalLabel.Text = "Spartid (år)";
            // 
            // savingsYearGoalNum
            // 
            savingsYearGoalNum.Location = new Point(12, 317);
            savingsYearGoalNum.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            savingsYearGoalNum.Name = "savingsYearGoalNum";
            savingsYearGoalNum.Size = new Size(138, 26);
            savingsYearGoalNum.TabIndex = 7;
            savingsYearGoalNum.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // yearlyInterestLabel
            // 
            yearlyInterestLabel.AutoSize = true;
            yearlyInterestLabel.Location = new Point(11, 216);
            yearlyInterestLabel.Name = "yearlyInterestLabel";
            yearlyInterestLabel.Size = new Size(129, 18);
            yearlyInterestLabel.TabIndex = 6;
            yearlyInterestLabel.Text = "Årsavkastning %";
            // 
            // yearlyInterestNum
            // 
            yearlyInterestNum.Location = new Point(11, 237);
            yearlyInterestNum.Name = "yearlyInterestNum";
            yearlyInterestNum.Size = new Size(138, 26);
            yearlyInterestNum.TabIndex = 5;
            yearlyInterestNum.Value = new decimal(new int[] { 6, 0, 0, 0 });
            // 
            // monthlyAmountLabel
            // 
            monthlyAmountLabel.AutoSize = true;
            monthlyAmountLabel.Location = new Point(12, 129);
            monthlyAmountLabel.Name = "monthlyAmountLabel";
            monthlyAmountLabel.Size = new Size(137, 18);
            monthlyAmountLabel.TabIndex = 4;
            monthlyAmountLabel.Text = "Månadssparande";
            // 
            // monthlyAmountNum
            // 
            monthlyAmountNum.Location = new Point(12, 150);
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
            // savingsPanel
            // 
            savingsPanel.Anchor = AnchorStyles.None;
            savingsPanel.BackColor = Color.Beige;
            savingsPanel.Controls.Add(challengePanel);
            savingsPanel.Controls.Add(panel3);
            savingsPanel.Controls.Add(panel2);
            savingsPanel.Location = new Point(206, 105);
            savingsPanel.Name = "savingsPanel";
            savingsPanel.Size = new Size(852, 424);
            savingsPanel.TabIndex = 9;
            // 
            // challengePanel
            // 
            challengePanel.BackColor = Color.Honeydew;
            challengePanel.BackgroundImageLayout = ImageLayout.Center;
            challengePanel.BorderStyle = BorderStyle.FixedSingle;
            challengePanel.Controls.Add(panel1);
            challengePanel.Controls.Add(addTransactionCancelBtn);
            challengePanel.Controls.Add(initiateChallengeBtn);
            challengePanel.Controls.Add(checkBox1);
            challengePanel.Controls.Add(label9);
            challengePanel.Controls.Add(label8);
            challengePanel.Controls.Add(label6);
            challengePanel.Location = new Point(202, 30);
            challengePanel.Name = "challengePanel";
            challengePanel.Size = new Size(435, 368);
            challengePanel.TabIndex = 11;
            challengePanel.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Honeydew;
            panel1.Controls.Add(totalResultLabel);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(bestWinLabel);
            panel1.Controls.Add(amountPlayedTodayLabel);
            panel1.Location = new Point(97, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(251, 167);
            panel1.TabIndex = 10;
            // 
            // totalResultLabel
            // 
            totalResultLabel.AutoSize = true;
            totalResultLabel.Location = new Point(3, 121);
            totalResultLabel.Name = "totalResultLabel";
            totalResultLabel.Size = new Size(38, 18);
            totalResultLabel.TabIndex = 14;
            totalResultLabel.Text = "123";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(60, 12);
            label11.Name = "label11";
            label11.Size = new Size(107, 18);
            label11.TabIndex = 0;
            label11.Text = "Din statistik";
            // 
            // bestWinLabel
            // 
            bestWinLabel.AutoSize = true;
            bestWinLabel.Location = new Point(3, 82);
            bestWinLabel.Name = "bestWinLabel";
            bestWinLabel.Size = new Size(38, 18);
            bestWinLabel.TabIndex = 12;
            bestWinLabel.Text = "123";
            // 
            // amountPlayedTodayLabel
            // 
            amountPlayedTodayLabel.AutoSize = true;
            amountPlayedTodayLabel.Location = new Point(3, 43);
            amountPlayedTodayLabel.Name = "amountPlayedTodayLabel";
            amountPlayedTodayLabel.Size = new Size(38, 18);
            amountPlayedTodayLabel.TabIndex = 11;
            amountPlayedTodayLabel.Text = "123";
            // 
            // addTransactionCancelBtn
            // 
            addTransactionCancelBtn.BackColor = Color.White;
            addTransactionCancelBtn.Cursor = Cursors.Hand;
            addTransactionCancelBtn.Location = new Point(10, 326);
            addTransactionCancelBtn.Margin = new Padding(10);
            addTransactionCancelBtn.Name = "addTransactionCancelBtn";
            addTransactionCancelBtn.Size = new Size(71, 32);
            addTransactionCancelBtn.TabIndex = 13;
            addTransactionCancelBtn.Text = "Avbryt";
            addTransactionCancelBtn.UseVisualStyleBackColor = false;
            addTransactionCancelBtn.Click += addTransactionCancelBtn_Click;
            // 
            // initiateChallengeBtn
            // 
            initiateChallengeBtn.BackColor = Color.LightGray;
            initiateChallengeBtn.Cursor = Cursors.Hand;
            initiateChallengeBtn.Enabled = false;
            initiateChallengeBtn.Location = new Point(133, 305);
            initiateChallengeBtn.Name = "initiateChallengeBtn";
            initiateChallengeBtn.Size = new Size(176, 45);
            initiateChallengeBtn.TabIndex = 9;
            initiateChallengeBtn.Text = "Starta utmaningen";
            initiateChallengeBtn.UseVisualStyleBackColor = false;
            initiateChallengeBtn.Click += initiateChallengeBtn_Click_1;
            // 
            // checkBox1
            // 
            checkBox1.Font = new Font("Lucida Sans", 11F);
            checkBox1.Location = new Point(52, 217);
            checkBox1.Name = "checkBox1";
            checkBox1.Padding = new Padding(10, 5, 5, 5);
            checkBox1.Size = new Size(328, 59);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Jag accepterar risken och antar sparutmaningen.";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label9
            // 
            label9.Font = new Font("Lucida Sans", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(114, 8);
            label9.Name = "label9";
            label9.Size = new Size(37, 35);
            label9.TabIndex = 8;
            label9.Text = "🎯";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(76, 147);
            label8.Name = "label8";
            label8.Size = new Size(0, 18);
            label8.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Sans", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(157, 16);
            label6.Name = "label6";
            label6.Size = new Size(153, 22);
            label6.TabIndex = 5;
            label6.Text = "Sparutmaning";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label5);
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
            // progressBar
            // 
            progressBar.Location = new Point(542, 535);
            progressBar.MarqueeAnimationSpeed = 30;
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(149, 23);
            progressBar.Step = 5;
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.TabIndex = 10;
            progressBar.Visible = false;
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
            // openToolsSavingBtn
            // 
            openToolsSavingBtn.Cursor = Cursors.Hand;
            openToolsSavingBtn.Location = new Point(528, 52);
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
            Controls.Add(progressBar);
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
            savingsPanel.ResumeLayout(false);
            challengePanel.ResumeLayout(false);
            challengePanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            totalSavingsPanel.ResumeLayout(false);
            totalSavingsPanel.PerformLayout();
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
        private Panel challengePanel;
        private Label label8;
        private Label label6;
        private Button initiateChallengeBtn;
        private Label label9;
        private Label bestWinLabel;
        private Label amountPlayedTodayLabel;
        private Button addTransactionCancelBtn;
        private Panel panel1;
        private Label label11;
        private Label totalResultLabel;
        private ProgressBar progressBar;
    }
}