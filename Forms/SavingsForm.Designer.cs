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
            savingsHeaderLabel = new Label();
            savingsFormReturnBtn = new Button();
            playButton = new Button();
            SuspendLayout();
            // 
            // savingsHeaderLabel
            // 
            savingsHeaderLabel.AutoSize = true;
            savingsHeaderLabel.Location = new Point(550, 50);
            savingsHeaderLabel.Name = "savingsHeaderLabel";
            savingsHeaderLabel.Size = new Size(110, 18);
            savingsHeaderLabel.TabIndex = 0;
            savingsHeaderLabel.Text = "Ditt sparande";
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
            // playButton
            // 
            playButton.Cursor = Cursors.Hand;
            playButton.Location = new Point(54, 158);
            playButton.Name = "playButton";
            playButton.Size = new Size(154, 48);
            playButton.TabIndex = 2;
            playButton.Text = "Utmana ditt sparande";
            playButton.UseVisualStyleBackColor = true;
            playButton.Click += playButton_Click;
            // 
            // SavingsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1184, 561);
            Controls.Add(playButton);
            Controls.Add(savingsFormReturnBtn);
            Controls.Add(savingsHeaderLabel);
            Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "SavingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sparande";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label savingsHeaderLabel;
        private Button savingsFormReturnBtn;
        private Button playButton;
    }
}