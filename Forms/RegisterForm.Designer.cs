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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newUserRegisterForm));
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
            userMsgPanel = new Panel();
            label1 = new Label();
            msgLabel = new Label();
            progressBar = new ProgressBar();
            panel1 = new Panel();
            addTransactionFormReturnBtn = new FontAwesome.Sharp.IconButton();
            menuStrip1 = new MenuStrip();
            appToolStripMenuItem = new ToolStripMenuItem();
            avslutaToolStripMenuItem = new ToolStripMenuItem();
            hjälpToolStripMenuItem = new ToolStripMenuItem();
            omToolStripMenuItem = new ToolStripMenuItem();
            userMsgPanel.SuspendLayout();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // newUserNameLabel
            // 
            newUserNameLabel.AutoSize = true;
            newUserNameLabel.Location = new Point(45, 14);
            newUserNameLabel.Margin = new Padding(4, 0, 4, 0);
            newUserNameLabel.Name = "newUserNameLabel";
            newUserNameLabel.Size = new Size(125, 18);
            newUserNameLabel.TabIndex = 0;
            newUserNameLabel.Text = "Användarnamn:";
            // 
            // newUserPasswordLabel
            // 
            newUserPasswordLabel.AutoSize = true;
            newUserPasswordLabel.Location = new Point(45, 151);
            newUserPasswordLabel.Margin = new Padding(4, 0, 4, 0);
            newUserPasswordLabel.Name = "newUserPasswordLabel";
            newUserPasswordLabel.Size = new Size(84, 18);
            newUserPasswordLabel.TabIndex = 1;
            newUserPasswordLabel.Text = "Lösenord:";
            // 
            // newUserConfirmPasswordLabel
            // 
            newUserConfirmPasswordLabel.AutoSize = true;
            newUserConfirmPasswordLabel.Location = new Point(45, 225);
            newUserConfirmPasswordLabel.Margin = new Padding(4, 0, 4, 0);
            newUserConfirmPasswordLabel.Name = "newUserConfirmPasswordLabel";
            newUserConfirmPasswordLabel.Size = new Size(146, 18);
            newUserConfirmPasswordLabel.TabIndex = 3;
            newUserConfirmPasswordLabel.Text = "Bekräfta lösenord:";
            // 
            // newUsernameText
            // 
            newUsernameText.Location = new Point(45, 36);
            newUsernameText.Margin = new Padding(4);
            newUsernameText.Name = "newUsernameText";
            newUsernameText.PlaceholderText = "Skriv användarnamn";
            newUsernameText.Size = new Size(228, 26);
            newUsernameText.TabIndex = 4;
            // 
            // newUserPasswordText
            // 
            newUserPasswordText.Location = new Point(45, 173);
            newUserPasswordText.Margin = new Padding(4);
            newUserPasswordText.Name = "newUserPasswordText";
            newUserPasswordText.PlaceholderText = "Skriv lösenord";
            newUserPasswordText.Size = new Size(228, 26);
            newUserPasswordText.TabIndex = 6;
            newUserPasswordText.UseSystemPasswordChar = true;
            // 
            // newUserConfirmPasswordText
            // 
            newUserConfirmPasswordText.Location = new Point(45, 247);
            newUserConfirmPasswordText.Margin = new Padding(4);
            newUserConfirmPasswordText.Name = "newUserConfirmPasswordText";
            newUserConfirmPasswordText.PlaceholderText = "Bekräfta lösenordet";
            newUserConfirmPasswordText.Size = new Size(228, 26);
            newUserConfirmPasswordText.TabIndex = 7;
            newUserConfirmPasswordText.UseSystemPasswordChar = true;
            // 
            // createUserButton
            // 
            createUserButton.BackColor = Color.FromArgb(67, 97, 170);
            createUserButton.Cursor = Cursors.Hand;
            createUserButton.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createUserButton.ForeColor = Color.White;
            createUserButton.Location = new Point(45, 313);
            createUserButton.Margin = new Padding(4);
            createUserButton.Name = "createUserButton";
            createUserButton.Size = new Size(228, 48);
            createUserButton.TabIndex = 8;
            createUserButton.Text = "Skapa användare";
            createUserButton.UseVisualStyleBackColor = false;
            createUserButton.Click += createUserButton_Click;
            // 
            // addNewUserHeaderLabel
            // 
            addNewUserHeaderLabel.Font = new Font("Lucida Sans", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addNewUserHeaderLabel.Location = new Point(457, 25);
            addNewUserHeaderLabel.Name = "addNewUserHeaderLabel";
            addNewUserHeaderLabel.Size = new Size(257, 28);
            addNewUserHeaderLabel.TabIndex = 8;
            addNewUserHeaderLabel.Text = "Lägg till ny användare";
            addNewUserHeaderLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // newUserRoleLabel
            // 
            newUserRoleLabel.AutoSize = true;
            newUserRoleLabel.Location = new Point(45, 81);
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
            newUserRoleCombo.Location = new Point(45, 102);
            newUserRoleCombo.Name = "newUserRoleCombo";
            newUserRoleCombo.Size = new Size(228, 26);
            newUserRoleCombo.TabIndex = 5;
            newUserRoleCombo.ValueMember = "Admin";
            // 
            // userMsgPanel
            // 
            userMsgPanel.BackColor = SystemColors.Info;
            userMsgPanel.Controls.Add(label1);
            userMsgPanel.Controls.Add(msgLabel);
            userMsgPanel.Location = new Point(142, 99);
            userMsgPanel.Name = "userMsgPanel";
            userMsgPanel.Size = new Size(284, 237);
            userMsgPanel.TabIndex = 12;
            userMsgPanel.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(77, 8);
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
            progressBar.Location = new Point(515, 529);
            progressBar.MarqueeAnimationSpeed = 30;
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(149, 23);
            progressBar.Step = 5;
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.TabIndex = 13;
            progressBar.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(newUserNameLabel);
            panel1.Controls.Add(newUserPasswordLabel);
            panel1.Controls.Add(newUserConfirmPasswordLabel);
            panel1.Controls.Add(newUsernameText);
            panel1.Controls.Add(newUserRoleCombo);
            panel1.Controls.Add(newUserPasswordText);
            panel1.Controls.Add(newUserRoleLabel);
            panel1.Controls.Add(newUserConfirmPasswordText);
            panel1.Controls.Add(createUserButton);
            panel1.Location = new Point(432, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(318, 374);
            panel1.TabIndex = 14;
            // 
            // addTransactionFormReturnBtn
            // 
            addTransactionFormReturnBtn.Cursor = Cursors.Hand;
            addTransactionFormReturnBtn.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            addTransactionFormReturnBtn.IconColor = Color.Black;
            addTransactionFormReturnBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            addTransactionFormReturnBtn.IconSize = 30;
            addTransactionFormReturnBtn.ImageAlign = ContentAlignment.MiddleLeft;
            addTransactionFormReturnBtn.Location = new Point(0, 520);
            addTransactionFormReturnBtn.Name = "addTransactionFormReturnBtn";
            addTransactionFormReturnBtn.Size = new Size(107, 38);
            addTransactionFormReturnBtn.TabIndex = 15;
            addTransactionFormReturnBtn.Text = "Översikt";
            addTransactionFormReturnBtn.TextAlign = ContentAlignment.MiddleRight;
            addTransactionFormReturnBtn.UseVisualStyleBackColor = true;
            addTransactionFormReturnBtn.Click += addTransactionFormReturnBtn_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            menuStrip1.BackColor = Color.FromArgb(244, 245, 247);
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { appToolStripMenuItem, hjälpToolStripMenuItem });
            menuStrip1.Location = new Point(959, 9);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(216, 24);
            menuStrip1.TabIndex = 16;
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
            avslutaToolStripMenuItem.Size = new Size(180, 22);
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
            omToolStripMenuItem.Size = new Size(180, 22);
            omToolStripMenuItem.Text = "&Om";
            omToolStripMenuItem.Click += omToolStripMenuItem_Click;
            // 
            // newUserRegisterForm
            // 
            AcceptButton = createUserButton;
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 245, 245);
            ClientSize = new Size(1184, 561);
            Controls.Add(menuStrip1);
            Controls.Add(addTransactionFormReturnBtn);
            Controls.Add(panel1);
            Controls.Add(progressBar);
            Controls.Add(userMsgPanel);
            Controls.Add(addNewUserHeaderLabel);
            Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "newUserRegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ny användare";
            Load += newUserRegisterForm_Load;
            userMsgPanel.ResumeLayout(false);
            userMsgPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private Panel userMsgPanel;
        private Label msgLabel;
        private ProgressBar progressBar;
        private Label label1;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton addTransactionFormReturnBtn;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem appToolStripMenuItem;
        private ToolStripMenuItem avslutaToolStripMenuItem;
        private ToolStripMenuItem hjälpToolStripMenuItem;
        private ToolStripMenuItem omToolStripMenuItem;
    }
}