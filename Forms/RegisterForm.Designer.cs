namespace Projekt.Forms
{
    partial class newUserRegisterForm
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
            newUserNameLabel = new Label();
            newUserPasswordLabel = new Label();
            newUserConfirmPasswordLabel = new Label();
            newUsernameText = new TextBox();
            newUserPasswordText = new TextBox();
            newUserConfirmPasswordText = new TextBox();
            createUserButton = new Button();
            addNewUserHeaderLabel = new Label();
            newUserRoleLabel = new Label();
            newUserRoleCombo = new ComboBox();
            addTransactionFormReturnBtn = new Button();
            userMsgPanel = new Panel();
            label1 = new Label();
            msgLabel = new Label();
            progressBar = new ProgressBar();
            userMsgPanel.SuspendLayout();
            SuspendLayout();
            // 
            // newUserNameLabel
            // 
            newUserNameLabel.AutoSize = true;
            newUserNameLabel.Location = new Point(489, 77);
            newUserNameLabel.Margin = new Padding(4, 0, 4, 0);
            newUserNameLabel.Name = "newUserNameLabel";
            newUserNameLabel.Size = new Size(125, 18);
            newUserNameLabel.TabIndex = 0;
            newUserNameLabel.Text = "Användarnamn:";
            // 
            // newUserPasswordLabel
            // 
            newUserPasswordLabel.AutoSize = true;
            newUserPasswordLabel.Location = new Point(489, 214);
            newUserPasswordLabel.Margin = new Padding(4, 0, 4, 0);
            newUserPasswordLabel.Name = "newUserPasswordLabel";
            newUserPasswordLabel.Size = new Size(84, 18);
            newUserPasswordLabel.TabIndex = 1;
            newUserPasswordLabel.Text = "Lösenord:";
            // 
            // newUserConfirmPasswordLabel
            // 
            newUserConfirmPasswordLabel.AutoSize = true;
            newUserConfirmPasswordLabel.Location = new Point(489, 288);
            newUserConfirmPasswordLabel.Margin = new Padding(4, 0, 4, 0);
            newUserConfirmPasswordLabel.Name = "newUserConfirmPasswordLabel";
            newUserConfirmPasswordLabel.Size = new Size(146, 18);
            newUserConfirmPasswordLabel.TabIndex = 3;
            newUserConfirmPasswordLabel.Text = "Bekräfta lösenord:";
            // 
            // newUsernameText
            // 
            newUsernameText.Location = new Point(489, 99);
            newUsernameText.Margin = new Padding(4);
            newUsernameText.Name = "newUsernameText";
            newUsernameText.PlaceholderText = "Skriv användarnamn";
            newUsernameText.Size = new Size(228, 26);
            newUsernameText.TabIndex = 4;
            // 
            // newUserPasswordText
            // 
            newUserPasswordText.Location = new Point(489, 236);
            newUserPasswordText.Margin = new Padding(4);
            newUserPasswordText.Name = "newUserPasswordText";
            newUserPasswordText.PlaceholderText = "Skriv lösenord";
            newUserPasswordText.Size = new Size(228, 26);
            newUserPasswordText.TabIndex = 5;
            // 
            // newUserConfirmPasswordText
            // 
            newUserConfirmPasswordText.Location = new Point(489, 310);
            newUserConfirmPasswordText.Margin = new Padding(4);
            newUserConfirmPasswordText.Name = "newUserConfirmPasswordText";
            newUserConfirmPasswordText.PlaceholderText = "Bekräfta lösenordet";
            newUserConfirmPasswordText.Size = new Size(228, 26);
            newUserConfirmPasswordText.TabIndex = 6;
            // 
            // createUserButton
            // 
            createUserButton.BackColor = SystemColors.GradientActiveCaption;
            createUserButton.Cursor = Cursors.Hand;
            createUserButton.ForeColor = SystemColors.WindowText;
            createUserButton.Location = new Point(489, 376);
            createUserButton.Margin = new Padding(4);
            createUserButton.Name = "createUserButton";
            createUserButton.Size = new Size(228, 48);
            createUserButton.TabIndex = 7;
            createUserButton.Text = "Skapa användare";
            createUserButton.UseVisualStyleBackColor = false;
            createUserButton.Click += createUserButton_Click;
            // 
            // addNewUserHeaderLabel
            // 
            addNewUserHeaderLabel.Location = new Point(515, 25);
            addNewUserHeaderLabel.Name = "addNewUserHeaderLabel";
            addNewUserHeaderLabel.Size = new Size(178, 18);
            addNewUserHeaderLabel.TabIndex = 8;
            addNewUserHeaderLabel.Text = "Lägg till ny användare";
            addNewUserHeaderLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // newUserRoleLabel
            // 
            newUserRoleLabel.AutoSize = true;
            newUserRoleLabel.Location = new Point(489, 144);
            newUserRoleLabel.Margin = new Padding(4, 0, 4, 0);
            newUserRoleLabel.Name = "newUserRoleLabel";
            newUserRoleLabel.Size = new Size(44, 18);
            newUserRoleLabel.TabIndex = 9;
            newUserRoleLabel.Text = "Roll:";
            // 
            // newUserRoleCombo
            // 
            newUserRoleCombo.Cursor = Cursors.Hand;
            newUserRoleCombo.DisplayMember = "Admin";
            newUserRoleCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            newUserRoleCombo.FormattingEnabled = true;
            newUserRoleCombo.Location = new Point(489, 165);
            newUserRoleCombo.Name = "newUserRoleCombo";
            newUserRoleCombo.Size = new Size(228, 26);
            newUserRoleCombo.TabIndex = 10;
            newUserRoleCombo.ValueMember = "Admin";
            // 
            // addTransactionFormReturnBtn
            // 
            addTransactionFormReturnBtn.Anchor = AnchorStyles.Left;
            addTransactionFormReturnBtn.AutoSize = true;
            addTransactionFormReturnBtn.Cursor = Cursors.Hand;
            addTransactionFormReturnBtn.Location = new Point(19, 514);
            addTransactionFormReturnBtn.Margin = new Padding(10);
            addTransactionFormReturnBtn.Name = "addTransactionFormReturnBtn";
            addTransactionFormReturnBtn.Padding = new Padding(5);
            addTransactionFormReturnBtn.Size = new Size(111, 38);
            addTransactionFormReturnBtn.TabIndex = 11;
            addTransactionFormReturnBtn.Text = "Gå tillbaka";
            addTransactionFormReturnBtn.UseVisualStyleBackColor = true;
            addTransactionFormReturnBtn.Click += addTransactionFormReturnBtn_Click;
            // 
            // userMsgPanel
            // 
            userMsgPanel.BackColor = SystemColors.Info;
            userMsgPanel.Controls.Add(label1);
            userMsgPanel.Controls.Add(msgLabel);
            userMsgPanel.Location = new Point(221, 99);
            userMsgPanel.Name = "userMsgPanel";
            userMsgPanel.Size = new Size(244, 237);
            userMsgPanel.TabIndex = 12;
            userMsgPanel.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(56, 13);
            label1.Name = "label1";
            label1.Size = new Size(129, 18);
            label1.TabIndex = 1;
            label1.Text = "Felmeddelande";
            // 
            // msgLabel
            // 
            msgLabel.AutoSize = true;
            msgLabel.Font = new Font("Lucida Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            msgLabel.Location = new Point(12, 49);
            msgLabel.Name = "msgLabel";
            msgLabel.Size = new Size(53, 17);
            msgLabel.TabIndex = 0;
            msgLabel.Text = "label1";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(542, 535);
            progressBar.MarqueeAnimationSpeed = 30;
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(149, 23);
            progressBar.Step = 5;
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.TabIndex = 13;
            progressBar.Visible = false;
            // 
            // newUserRegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1184, 561);
            Controls.Add(progressBar);
            Controls.Add(userMsgPanel);
            Controls.Add(addTransactionFormReturnBtn);
            Controls.Add(newUserRoleCombo);
            Controls.Add(newUserRoleLabel);
            Controls.Add(addNewUserHeaderLabel);
            Controls.Add(createUserButton);
            Controls.Add(newUserConfirmPasswordText);
            Controls.Add(newUserPasswordText);
            Controls.Add(newUsernameText);
            Controls.Add(newUserConfirmPasswordLabel);
            Controls.Add(newUserPasswordLabel);
            Controls.Add(newUserNameLabel);
            Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "newUserRegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Skapa ny användare";
            Load += newUserRegisterForm_Load;
            userMsgPanel.ResumeLayout(false);
            userMsgPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label newUserNameLabel;
        private Label newUserPasswordLabel;
        private Label newUserConfirmPasswordLabel;
        private TextBox newUsernameText;
        private TextBox newUserPasswordText;
        private TextBox newUserConfirmPasswordText;
        private Button createUserButton;
        private Label addNewUserHeaderLabel;
        private Label newUserRoleLabel;
        private ComboBox newUserRoleCombo;
        private Button addTransactionFormReturnBtn;
        private Panel userMsgPanel;
        private Label msgLabel;
        private ProgressBar progressBar;
        private Label label1;
    }
}