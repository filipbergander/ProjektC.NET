namespace Projekt.Forms
{
    partial class StatisticsForm
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
            statsHeaderLabel = new Label();
            statsFormReturnBtn = new Button();
            SuspendLayout();
            // 
            // statsHeaderLabel
            // 
            statsHeaderLabel.AutoSize = true;
            statsHeaderLabel.Location = new Point(550, 50);
            statsHeaderLabel.Name = "statsHeaderLabel";
            statsHeaderLabel.Size = new Size(172, 18);
            statsHeaderLabel.TabIndex = 0;
            statsHeaderLabel.Text = "Statistik för ditt konto";
            // 
            // statsFormReturnBtn
            // 
            statsFormReturnBtn.Anchor = AnchorStyles.Left;
            statsFormReturnBtn.AutoSize = true;
            statsFormReturnBtn.Location = new Point(19, 504);
            statsFormReturnBtn.Margin = new Padding(10);
            statsFormReturnBtn.Name = "statsFormReturnBtn";
            statsFormReturnBtn.Padding = new Padding(5);
            statsFormReturnBtn.Size = new Size(111, 38);
            statsFormReturnBtn.TabIndex = 1;
            statsFormReturnBtn.Text = "Gå tillbaka";
            statsFormReturnBtn.UseVisualStyleBackColor = true;
            // 
            // StatisticsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1184, 561);
            Controls.Add(statsFormReturnBtn);
            Controls.Add(statsHeaderLabel);
            Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "StatisticsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Statistik";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label statsHeaderLabel;
        private Button statsFormReturnBtn;
    }
}