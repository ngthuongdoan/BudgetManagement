namespace BudgetManagement
{
    partial class Transaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaction));
            this.Categogy = new System.Windows.Forms.PictureBox();
            this.Value = new System.Windows.Forms.Label();
            this.Wallet = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Categogy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Type)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Categogy
            // 
            this.Categogy.Location = new System.Drawing.Point(23, 3);
            this.Categogy.Name = "Categogy";
            this.Categogy.Size = new System.Drawing.Size(55, 55);
            this.Categogy.TabIndex = 0;
            this.Categogy.TabStop = false;
            // 
            // Value
            // 
            this.Value.AutoSize = true;
            this.Value.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Value.Location = new System.Drawing.Point(93, 8);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(65, 25);
            this.Value.TabIndex = 1;
            this.Value.Text = "label1";
            // 
            // Wallet
            // 
            this.Wallet.AutoSize = true;
            this.Wallet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wallet.Location = new System.Drawing.Point(93, 38);
            this.Wallet.Name = "Wallet";
            this.Wallet.Size = new System.Drawing.Size(41, 17);
            this.Wallet.TabIndex = 2;
            this.Wallet.Text = "label1";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(320, 18);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(63, 25);
            this.Time.TabIndex = 3;
            this.Time.Text = "label1";
            // 
            // Type
            // 
            this.Type.Location = new System.Drawing.Point(590, 3);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(55, 55);
            this.Type.TabIndex = 4;
            this.Type.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(662, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 34);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Wallet);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.Categogy);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(20, 6, 6, 15);
            this.Name = "Transaction";
            this.Size = new System.Drawing.Size(700, 59);
            this.Load += new System.EventHandler(this.Transaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Categogy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Type)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Type;
        public System.Windows.Forms.PictureBox Categogy;
        public System.Windows.Forms.Label Value;
        public System.Windows.Forms.Label Wallet;
        public System.Windows.Forms.Label Time;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
