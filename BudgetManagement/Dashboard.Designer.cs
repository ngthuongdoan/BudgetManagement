namespace BudgetManagement
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.Label();
            this.WalletMenu = new System.Windows.Forms.Button();
            this.TransactionMenu = new System.Windows.Forms.Button();
            this.DebtMenu = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.WalletTab = new System.Windows.Forms.TabPage();
            this.TransactionTab = new System.Windows.Forms.TabPage();
            this.DebtTab = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.Avatar = new BudgetManagement.OvalPictureBox();
            this.MenuPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.WalletTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.MenuPanel.Controls.Add(this.DebtMenu);
            this.MenuPanel.Controls.Add(this.TransactionMenu);
            this.MenuPanel.Controls.Add(this.WalletMenu);
            this.MenuPanel.Controls.Add(this.LogOutBtn);
            this.MenuPanel.Controls.Add(this.ExitBtn);
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(200, 569);
            this.MenuPanel.TabIndex = 0;
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.FlatAppearance.BorderSize = 0;
            this.LogOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutBtn.Image = ((System.Drawing.Image)(resources.GetObject("LogOutBtn.Image")));
            this.LogOutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogOutBtn.Location = new System.Drawing.Point(0, 473);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.LogOutBtn.Size = new System.Drawing.Size(197, 40);
            this.LogOutBtn.TabIndex = 1;
            this.LogOutBtn.Text = "LOG OUT";
            this.LogOutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogOutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LogOutBtn.UseVisualStyleBackColor = true;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click_1);
            // 
            // ExitBtn
            // 
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitBtn.Location = new System.Drawing.Point(3, 519);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.ExitBtn.Size = new System.Drawing.Size(197, 40);
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.Text = "EXIT";
            this.ExitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(245, 40);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(81, 21);
            this.Username.TabIndex = 2;
            this.Username.Text = "username";
            // 
            // WalletMenu
            // 
            this.WalletMenu.FlatAppearance.BorderSize = 0;
            this.WalletMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(170)))), ((int)(((byte)(59)))));
            this.WalletMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(212)))), ((int)(((byte)(37)))));
            this.WalletMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WalletMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WalletMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WalletMenu.Location = new System.Drawing.Point(2, 181);
            this.WalletMenu.Name = "WalletMenu";
            this.WalletMenu.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.WalletMenu.Size = new System.Drawing.Size(197, 40);
            this.WalletMenu.TabIndex = 2;
            this.WalletMenu.Text = "Wallets";
            this.WalletMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WalletMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.WalletMenu.UseVisualStyleBackColor = true;
            this.WalletMenu.Click += new System.EventHandler(this.WalletMenu_Click);
            // 
            // TransactionMenu
            // 
            this.TransactionMenu.FlatAppearance.BorderSize = 0;
            this.TransactionMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(170)))), ((int)(((byte)(59)))));
            this.TransactionMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(212)))), ((int)(((byte)(37)))));
            this.TransactionMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransactionMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TransactionMenu.Location = new System.Drawing.Point(2, 228);
            this.TransactionMenu.Name = "TransactionMenu";
            this.TransactionMenu.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.TransactionMenu.Size = new System.Drawing.Size(197, 40);
            this.TransactionMenu.TabIndex = 3;
            this.TransactionMenu.Text = "Transactions";
            this.TransactionMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TransactionMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TransactionMenu.UseVisualStyleBackColor = true;
            this.TransactionMenu.Click += new System.EventHandler(this.TransactionMenu_Click);
            // 
            // DebtMenu
            // 
            this.DebtMenu.FlatAppearance.BorderSize = 0;
            this.DebtMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(170)))), ((int)(((byte)(59)))));
            this.DebtMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(212)))), ((int)(((byte)(37)))));
            this.DebtMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DebtMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DebtMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DebtMenu.Location = new System.Drawing.Point(2, 275);
            this.DebtMenu.Name = "DebtMenu";
            this.DebtMenu.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.DebtMenu.Size = new System.Drawing.Size(197, 40);
            this.DebtMenu.TabIndex = 4;
            this.DebtMenu.Text = "Debts";
            this.DebtMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DebtMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DebtMenu.UseVisualStyleBackColor = true;
            this.DebtMenu.Click += new System.EventHandler(this.DebtMenu_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Controls.Add(this.WalletTab);
            this.tabControl1.Controls.Add(this.TransactionTab);
            this.tabControl1.Controls.Add(this.DebtTab);
            this.tabControl1.Location = new System.Drawing.Point(196, -33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(793, 675);
            this.tabControl1.TabIndex = 4;
            // 
            // WalletTab
            // 
            this.WalletTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.WalletTab.Controls.Add(this.button1);
            this.WalletTab.Location = new System.Drawing.Point(4, 34);
            this.WalletTab.Name = "WalletTab";
            this.WalletTab.Padding = new System.Windows.Forms.Padding(3);
            this.WalletTab.Size = new System.Drawing.Size(785, 637);
            this.WalletTab.TabIndex = 0;
            this.WalletTab.Text = "Wallet";
            // 
            // TransactionTab
            // 
            this.TransactionTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.TransactionTab.Location = new System.Drawing.Point(4, 22);
            this.TransactionTab.Name = "TransactionTab";
            this.TransactionTab.Padding = new System.Windows.Forms.Padding(3);
            this.TransactionTab.Size = new System.Drawing.Size(785, 649);
            this.TransactionTab.TabIndex = 1;
            this.TransactionTab.Text = "tabPage2";
            // 
            // DebtTab
            // 
            this.DebtTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.DebtTab.Location = new System.Drawing.Point(4, 22);
            this.DebtTab.Name = "DebtTab";
            this.DebtTab.Size = new System.Drawing.Size(785, 649);
            this.DebtTab.TabIndex = 2;
            this.DebtTab.Text = "tabPage3";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(170)))), ((int)(((byte)(59)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(212)))), ((int)(((byte)(37)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(614, 29);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(158, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add Wallet";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Avatar
            // 
            this.Avatar.BackColor = System.Drawing.Color.DarkGray;
            this.Avatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Avatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Avatar.Location = new System.Drawing.Point(159, 40);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(80, 80);
            this.Avatar.TabIndex = 1;
            this.Avatar.TabStop = false;
            this.Avatar.Click += new System.EventHandler(this.Avatar_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.ControlBox = false;
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Avatar);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.MenuPanel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.WalletTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button ExitBtn;
        private OvalPictureBox Avatar;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Button DebtMenu;
        private System.Windows.Forms.Button TransactionMenu;
        private System.Windows.Forms.Button WalletMenu;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage WalletTab;
        private System.Windows.Forms.TabPage TransactionTab;
        private System.Windows.Forms.TabPage DebtTab;
        private System.Windows.Forms.Button button1;
    }
}