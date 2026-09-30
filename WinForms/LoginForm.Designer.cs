namespace ProjektC_.NET.WinForms
{
    partial class loginForm
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
            newUserButton = new Button();
            loginButton = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new Point(490, 164);
            userNameLabel.Margin = new Padding(4, 0, 4, 0);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(125, 18);
            userNameLabel.TabIndex = 0;
            userNameLabel.Text = "Användarnamn:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(490, 242);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(84, 18);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Lösenord:";
            passwordLabel.Click += passwordLabel_Click;
            // 
            // newUserButton
            // 
            newUserButton.BackColor = SystemColors.ActiveCaption;
            newUserButton.Location = new Point(469, 331);
            newUserButton.Name = "newUserButton";
            newUserButton.Size = new Size(128, 44);
            newUserButton.TabIndex = 2;
            newUserButton.Text = "Ny användare";
            newUserButton.UseVisualStyleBackColor = false;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.DarkSeaGreen;
            loginButton.Location = new Point(619, 331);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(128, 44);
            loginButton.TabIndex = 3;
            loginButton.Text = "Logga in";
            loginButton.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(490, 185);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Skriv användarnamn";
            textBox1.Size = new Size(228, 26);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(490, 263);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Skriv lösenord";
            textBox2.Size = new Size(228, 26);
            textBox2.TabIndex = 5;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1184, 561);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(loginButton);
            Controls.Add(newUserButton);
            Controls.Add(passwordLabel);
            Controls.Add(userNameLabel);
            Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "loginForm";
            Text = "Logga in";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userNameLabel;
        private Label passwordLabel;
        private Button newUserButton;
        private Button loginButton;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}