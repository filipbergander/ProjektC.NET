namespace Forms
{
    partial class TransactionForm
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
            transactionGrid = new DataGridView();
            transactionsHeaderLabel = new Label();
            transactionFormReturnBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)transactionGrid).BeginInit();
            SuspendLayout();
            // 
            // transactionGrid
            // 
            transactionGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            transactionGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            transactionGrid.Location = new Point(163, 228);
            transactionGrid.Margin = new Padding(4);
            transactionGrid.Name = "transactionGrid";
            transactionGrid.Size = new Size(835, 229);
            transactionGrid.TabIndex = 0;
            // 
            // transactionsHeaderLabel
            // 
            transactionsHeaderLabel.AutoSize = true;
            transactionsHeaderLabel.Location = new Point(529, 108);
            transactionsHeaderLabel.Margin = new Padding(4, 0, 4, 0);
            transactionsHeaderLabel.Name = "transactionsHeaderLabel";
            transactionsHeaderLabel.Size = new Size(109, 18);
            transactionsHeaderLabel.TabIndex = 1;
            transactionsHeaderLabel.Text = "Transaktioner";
            transactionsHeaderLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // transactionFormReturnBtn
            // 
            transactionFormReturnBtn.Anchor = AnchorStyles.Left;
            transactionFormReturnBtn.AutoSize = true;
            transactionFormReturnBtn.Location = new Point(19, 504);
            transactionFormReturnBtn.Margin = new Padding(10);
            transactionFormReturnBtn.Name = "transactionFormReturnBtn";
            transactionFormReturnBtn.Padding = new Padding(5);
            transactionFormReturnBtn.Size = new Size(111, 38);
            transactionFormReturnBtn.TabIndex = 2;
            transactionFormReturnBtn.Text = "Gå tillbaka";
            transactionFormReturnBtn.UseVisualStyleBackColor = true;
            transactionFormReturnBtn.Click += transactionFormReturnBtn_Click;
            // 
            // TransactionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1184, 561);
            Controls.Add(transactionFormReturnBtn);
            Controls.Add(transactionsHeaderLabel);
            Controls.Add(transactionGrid);
            Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "TransactionForm";
            Text = "Transaktioner";
            Load += TransactionForm_Load;
            ((System.ComponentModel.ISupportInitialize)transactionGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView transactionGrid;
        private Label transactionsHeaderLabel;
        private Button transactionFormReturnBtn;
    }
}