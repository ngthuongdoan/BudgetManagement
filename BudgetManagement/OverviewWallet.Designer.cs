namespace BudgetManagement
{
    partial class OverviewWallet
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Categogy = new System.Windows.Forms.PictureBox();
            this.Value = new System.Windows.Forms.Label();
            this.Wallet = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Categogy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Type)).BeginInit();
            this.SuspendLayout();
            // 
            // Categogy
            // 
            this.Categogy.Location = new System.Drawing.Point(25, 4);
            this.Categogy.Margin = new System.Windows.Forms.Padding(6);
            this.Categogy.Name = "Categogy";
            this.Categogy.Size = new System.Drawing.Size(40, 40);
            this.Categogy.TabIndex = 1;
            this.Categogy.TabStop = false;
            // 
            // Value
            // 
            this.Value.AutoSize = true;
            this.Value.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Value.Location = new System.Drawing.Point(81, 3);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(65, 25);
            this.Value.TabIndex = 2;
            this.Value.Text = "label1";
            // 
            // Wallet
            // 
            this.Wallet.AutoSize = true;
            this.Wallet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wallet.Location = new System.Drawing.Point(81, 27);
            this.Wallet.Name = "Wallet";
            this.Wallet.Size = new System.Drawing.Size(41, 17);
            this.Wallet.TabIndex = 3;
            this.Wallet.Text = "label1";
            // 
            // Type
            // 
            this.Type.Location = new System.Drawing.Point(342, 4);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(40, 40);
            this.Type.TabIndex = 5;
            this.Type.TabStop = false;
            // 
            // OverviewWallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Wallet);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.Categogy);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OverviewWallet";
            this.Size = new System.Drawing.Size(400, 50);
            this.Load += new System.EventHandler(this.OverviewWallet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Categogy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Type)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label Value;
        public System.Windows.Forms.Label Wallet;
        private System.Windows.Forms.PictureBox Type;
        public System.Windows.Forms.PictureBox Categogy;
    }
}
