namespace BudgetManagement
{
    partial class Wallet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wallet));
            this.WalletIcon = new System.Windows.Forms.PictureBox();
            this.WalletName = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.DeleteWallet = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.WalletIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteWallet)).BeginInit();
            this.SuspendLayout();
            // 
            // WalletIcon
            // 
            this.WalletIcon.Location = new System.Drawing.Point(35, 0);
            this.WalletIcon.Margin = new System.Windows.Forms.Padding(6);
            this.WalletIcon.Name = "WalletIcon";
            this.WalletIcon.Size = new System.Drawing.Size(64, 59);
            this.WalletIcon.TabIndex = 0;
            this.WalletIcon.TabStop = false;
            // 
            // WalletName
            // 
            this.WalletName.AutoSize = true;
            this.WalletName.Location = new System.Drawing.Point(159, 17);
            this.WalletName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.WalletName.Name = "WalletName";
            this.WalletName.Size = new System.Drawing.Size(65, 25);
            this.WalletName.TabIndex = 1;
            this.WalletName.Text = "Wallet";
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.AmountLabel.Location = new System.Drawing.Point(550, 17);
            this.AmountLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(79, 25);
            this.AmountLabel.TabIndex = 2;
            this.AmountLabel.Text = "Amount";
            // 
            // DeleteWallet
            // 
            this.DeleteWallet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteWallet.Image = ((System.Drawing.Image)(resources.GetObject("DeleteWallet.Image")));
            this.DeleteWallet.Location = new System.Drawing.Point(650, 13);
            this.DeleteWallet.Name = "DeleteWallet";
            this.DeleteWallet.Size = new System.Drawing.Size(35, 33);
            this.DeleteWallet.TabIndex = 3;
            this.DeleteWallet.TabStop = false;
            this.DeleteWallet.Click += new System.EventHandler(this.DeleteWallet_Click);
            // 
            // Wallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(222)))), ((int)(((byte)(150)))));
            this.Controls.Add(this.DeleteWallet);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.WalletName);
            this.Controls.Add(this.WalletIcon);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(20, 6, 6, 15);
            this.Name = "Wallet";
            this.Size = new System.Drawing.Size(700, 59);
            ((System.ComponentModel.ISupportInitialize)(this.WalletIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteWallet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox WalletIcon;
        private System.Windows.Forms.Label WalletName;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.PictureBox DeleteWallet;
    }
}
