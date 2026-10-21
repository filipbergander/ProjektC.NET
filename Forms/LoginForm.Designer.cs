using Projekt.Forms;

namespace Projekt.Forms
{
    partial class LoginForm
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
            userNameLabel = new Label();
            passwordLabel = new Label();
            loginButton = new Button();
            userNameText = new TextBox();
            passwordText = new TextBox();
            loginFormHeaderLabel = new Label();
            userMsgPanel = new Panel();
            label1 = new Label();
            msgLabel = new Label();
            progressBar = new ProgressBar();
            userMsgPanel.SuspendLayout();
            SuspendLayout();
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new Point(481, 107);
            userNameLabel.Margin = new Padding(4, 0, 4, 0);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(125, 18);
            userNameLabel.TabIndex = 0;
            userNameLabel.Text = "Användarnamn:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(481, 185);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(84, 18);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Lösenord:";
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.DarkSeaGreen;
            loginButton.Location = new Point(481, 264);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(228, 47);
            loginButton.TabIndex = 3;
            loginButton.Text = "Logga in";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // userNameText
            // 
            userNameText.Location = new Point(481, 128);
            userNameText.Name = "userNameText";
            userNameText.PlaceholderText = "Skriv användarnamn";
            userNameText.Size = new Size(228, 26);
            userNameText.TabIndex = 4;
            // 
            // passwordText
            // 
            passwordText.Location = new Point(481, 206);
            passwordText.Name = "passwordText";
            passwordText.PlaceholderText = "Skriv lösenord";
            passwordText.Size = new Size(228, 26);
            passwordText.TabIndex = 5;
            passwordText.UseSystemPasswordChar = true;
            // 
            // loginFormHeaderLabel
            // 
            loginFormHeaderLabel.AutoSize = true;
            loginFormHeaderLabel.Location = new Point(559, 24);
            loginFormHeaderLabel.Name = "loginFormHeaderLabel";
            loginFormHeaderLabel.Size = new Size(75, 18);
            loginFormHeaderLabel.TabIndex = 6;
            loginFormHeaderLabel.Text = "Logga in";
            // 
            // userMsgPanel
            // 
            userMsgPanel.BackColor = SystemColors.Info;
            userMsgPanel.Controls.Add(label1);
            userMsgPanel.Controls.Add(msgLabel);
            userMsgPanel.Location = new Point(191, 107);
            userMsgPanel.Name = "userMsgPanel";
            userMsgPanel.Size = new Size(284, 125);
            userMsgPanel.TabIndex = 13;
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
            progressBar.Location = new Point(520, 535);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(149, 23);
            progressBar.TabIndex = 14;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1184, 561);
            Controls.Add(progressBar);
            Controls.Add(userMsgPanel);
            Controls.Add(loginFormHeaderLabel);
            Controls.Add(passwordText);
            Controls.Add(userNameText);
            Controls.Add(loginButton);
            Controls.Add(passwordLabel);
            Controls.Add(userNameLabel);
            Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Logga in";
            Load += LoginForm_Load;
            userMsgPanel.ResumeLayout(false);
            userMsgPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userNameLabel;
        private Label passwordLabel;
        private Button loginButton;
        private TextBox userNameText;
        private TextBox passwordText;
        private Label loginFormHeaderLabel;
        private Panel userMsgPanel;
        private Label label1;
        private Label msgLabel;
        private ProgressBar progressBar;
    }
}