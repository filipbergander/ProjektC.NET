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
            SuspendLayout();
            // 
            // newUserNameLabel
            // 
            newUserNameLabel.AutoSize = true;
            newUserNameLabel.Location = new Point(524, 118);
            newUserNameLabel.Margin = new Padding(4, 0, 4, 0);
            newUserNameLabel.Name = "newUserNameLabel";
            newUserNameLabel.Size = new Size(125, 18);
            newUserNameLabel.TabIndex = 0;
            newUserNameLabel.Text = "Användarnamn:";
            // 
            // newUserPasswordLabel
            // 
            newUserPasswordLabel.AutoSize = true;
            newUserPasswordLabel.Location = new Point(524, 195);
            newUserPasswordLabel.Margin = new Padding(4, 0, 4, 0);
            newUserPasswordLabel.Name = "newUserPasswordLabel";
            newUserPasswordLabel.Size = new Size(84, 18);
            newUserPasswordLabel.TabIndex = 1;
            newUserPasswordLabel.Text = "Lösenord:";
            // 
            // newUserConfirmPasswordLabel
            // 
            newUserConfirmPasswordLabel.AutoSize = true;
            newUserConfirmPasswordLabel.Location = new Point(524, 277);
            newUserConfirmPasswordLabel.Margin = new Padding(4, 0, 4, 0);
            newUserConfirmPasswordLabel.Name = "newUserConfirmPasswordLabel";
            newUserConfirmPasswordLabel.Size = new Size(146, 18);
            newUserConfirmPasswordLabel.TabIndex = 3;
            newUserConfirmPasswordLabel.Text = "Bekräfta lösenord:";
            // 
            // newUsernameText
            // 
            newUsernameText.Location = new Point(524, 140);
            newUsernameText.Margin = new Padding(4);
            newUsernameText.Name = "newUsernameText";
            newUsernameText.PlaceholderText = "Skriv användarnamn";
            newUsernameText.Size = new Size(228, 26);
            newUsernameText.TabIndex = 4;
            // 
            // newUserPasswordText
            // 
            newUserPasswordText.Location = new Point(524, 217);
            newUserPasswordText.Margin = new Padding(4);
            newUserPasswordText.Name = "newUserPasswordText";
            newUserPasswordText.PlaceholderText = "Skriv lösenord";
            newUserPasswordText.Size = new Size(228, 26);
            newUserPasswordText.TabIndex = 5;
            // 
            // newUserConfirmPasswordText
            // 
            newUserConfirmPasswordText.Location = new Point(524, 299);
            newUserConfirmPasswordText.Margin = new Padding(4);
            newUserConfirmPasswordText.Name = "newUserConfirmPasswordText";
            newUserConfirmPasswordText.PlaceholderText = "Bekräfta lösenordet";
            newUserConfirmPasswordText.Size = new Size(228, 26);
            newUserConfirmPasswordText.TabIndex = 6;
            // 
            // createUserButton
            // 
            createUserButton.BackColor = SystemColors.GradientActiveCaption;
            createUserButton.ForeColor = SystemColors.WindowText;
            createUserButton.Location = new Point(524, 365);
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
            addNewUserHeaderLabel.Location = new Point(550, 50);
            addNewUserHeaderLabel.Name = "addNewUserHeaderLabel";
            addNewUserHeaderLabel.Size = new Size(178, 18);
            addNewUserHeaderLabel.TabIndex = 8;
            addNewUserHeaderLabel.Text = "Lägg till ny användare";
            addNewUserHeaderLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // newUserRegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1691, 673);
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
    }
}