namespace Forms
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
            SuspendLayout();
            // 
            // statsHeaderLabel
            // 
            statsHeaderLabel.AutoSize = true;
            statsHeaderLabel.Location = new Point(503, 102);
            statsHeaderLabel.Name = "statsHeaderLabel";
            statsHeaderLabel.Size = new Size(172, 18);
            statsHeaderLabel.TabIndex = 0;
            statsHeaderLabel.Text = "Statistik för ditt konto";
            // 
            // StatisticsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1184, 561);
            Controls.Add(statsHeaderLabel);
            Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "StatisticsForm";
            Text = "Statistik";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label statsHeaderLabel;
    }
}