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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            userNameLabel = new Label();
            passwordLabel = new Label();
            loginButton = new Button();
            userNameText = new TextBox();
            passwordText = new TextBox();
            loginFormHeaderLabel = new Label();
            userMsgPanel = new Panel();
            label1 = new Label();
            msgLabel = new Label();
            panel1 = new Panel();
            userMsgPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new Point(13, 17);
            userNameLabel.Margin = new Padding(4, 0, 4, 0);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(125, 18);
            userNameLabel.TabIndex = 0;
            userNameLabel.Text = "Användarnamn:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(13, 95);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(84, 18);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Lösenord:";
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(67, 97, 170);
            loginButton.Cursor = Cursors.Hand;
            loginButton.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(13, 174);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(228, 47);
            loginButton.TabIndex = 3;
            loginButton.Text = "Logga in";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // userNameText
            // 
            userNameText.Location = new Point(13, 38);
            userNameText.Name = "userNameText";
            userNameText.PlaceholderText = "Skriv användarnamn";
            userNameText.Size = new Size(228, 26);
            userNameText.TabIndex = 4;
            // 
            // passwordText
            // 
            passwordText.Location = new Point(13, 116);
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
            userMsgPanel.Location = new Point(179, 131);
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
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(loginButton);
            panel1.Controls.Add(userNameLabel);
            panel1.Controls.Add(passwordLabel);
            panel1.Controls.Add(passwordText);
            panel1.Controls.Add(userNameText);
            panel1.Location = new Point(469, 93);
            panel1.Name = "panel1";
            panel1.Size = new Size(253, 234);
            panel1.TabIndex = 14;
            // 
            // LoginForm
            // 
            AcceptButton = loginButton;
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 245, 245);
            ClientSize = new Size(1184, 561);
            Controls.Add(panel1);
            Controls.Add(userMsgPanel);
            Controls.Add(loginFormHeaderLabel);
            Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Logga in";
            userMsgPanel.ResumeLayout(false);
            userMsgPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
    }
}