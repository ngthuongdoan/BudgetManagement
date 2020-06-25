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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.OverviewMenu = new System.Windows.Forms.Button();
            this.TransactionMenu = new System.Windows.Forms.Button();
            this.WalletMenu = new System.Windows.Forms.Button();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.WalletTab = new System.Windows.Forms.TabPage();
            this.WalletContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.AddWalletBtn = new System.Windows.Forms.Button();
            this.TransactionTab = new System.Windows.Forms.TabPage();
            this.AddTransactionBtn = new System.Windows.Forms.Button();
            this.TransactionContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.OverviewTab = new System.Windows.Forms.TabPage();
            this.TodayTransactionPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.CategogyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.IncomeExpenseChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.FilterAllBtn = new System.Windows.Forms.RadioButton();
            this.FilterMonthlyBtn = new System.Windows.Forms.RadioButton();
            this.FilterYearlyBtn = new System.Windows.Forms.RadioButton();
            this.FilterDailyBtn = new System.Windows.Forms.RadioButton();
            this.Avatar = new BudgetManagement.OvalPictureBox();
            this.MenuPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.WalletTab.SuspendLayout();
            this.TransactionTab.SuspendLayout();
            this.OverviewTab.SuspendLayout();
            this.TodayTransactionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategogyChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeExpenseChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.MenuPanel.Controls.Add(this.OverviewMenu);
            this.MenuPanel.Controls.Add(this.TransactionMenu);
            this.MenuPanel.Controls.Add(this.WalletMenu);
            this.MenuPanel.Controls.Add(this.LogOutBtn);
            this.MenuPanel.Controls.Add(this.ExitBtn);
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(200, 569);
            this.MenuPanel.TabIndex = 0;
            // 
            // OverviewMenu
            // 
            this.OverviewMenu.FlatAppearance.BorderSize = 0;
            this.OverviewMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(170)))), ((int)(((byte)(59)))));
            this.OverviewMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(212)))), ((int)(((byte)(37)))));
            this.OverviewMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OverviewMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverviewMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OverviewMenu.Location = new System.Drawing.Point(3, 212);
            this.OverviewMenu.Name = "OverviewMenu";
            this.OverviewMenu.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.OverviewMenu.Size = new System.Drawing.Size(197, 40);
            this.OverviewMenu.TabIndex = 4;
            this.OverviewMenu.Text = "Overview";
            this.OverviewMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OverviewMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OverviewMenu.UseVisualStyleBackColor = true;
            this.OverviewMenu.Click += new System.EventHandler(this.OverviewMenu_Click);
            // 
            // TransactionMenu
            // 
            this.TransactionMenu.FlatAppearance.BorderSize = 0;
            this.TransactionMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(170)))), ((int)(((byte)(59)))));
            this.TransactionMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(212)))), ((int)(((byte)(37)))));
            this.TransactionMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransactionMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TransactionMenu.Location = new System.Drawing.Point(3, 292);
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
            // WalletMenu
            // 
            this.WalletMenu.FlatAppearance.BorderSize = 0;
            this.WalletMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(170)))), ((int)(((byte)(59)))));
            this.WalletMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(212)))), ((int)(((byte)(37)))));
            this.WalletMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WalletMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WalletMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WalletMenu.Location = new System.Drawing.Point(3, 252);
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
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
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
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Controls.Add(this.WalletTab);
            this.tabControl1.Controls.Add(this.TransactionTab);
            this.tabControl1.Controls.Add(this.OverviewTab);
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
            this.WalletTab.Controls.Add(this.WalletContainer);
            this.WalletTab.Controls.Add(this.AddWalletBtn);
            this.WalletTab.Location = new System.Drawing.Point(4, 34);
            this.WalletTab.Name = "WalletTab";
            this.WalletTab.Padding = new System.Windows.Forms.Padding(3);
            this.WalletTab.Size = new System.Drawing.Size(785, 637);
            this.WalletTab.TabIndex = 0;
            this.WalletTab.Text = "Wallet";
            // 
            // WalletContainer
            // 
            this.WalletContainer.Location = new System.Drawing.Point(0, 167);
            this.WalletContainer.Name = "WalletContainer";
            this.WalletContainer.Size = new System.Drawing.Size(782, 391);
            this.WalletContainer.TabIndex = 7;
            // 
            // AddWalletBtn
            // 
            this.AddWalletBtn.FlatAppearance.BorderSize = 0;
            this.AddWalletBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(170)))), ((int)(((byte)(59)))));
            this.AddWalletBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(212)))), ((int)(((byte)(37)))));
            this.AddWalletBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddWalletBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddWalletBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddWalletBtn.Image")));
            this.AddWalletBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddWalletBtn.Location = new System.Drawing.Point(592, 61);
            this.AddWalletBtn.Name = "AddWalletBtn";
            this.AddWalletBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.AddWalletBtn.Size = new System.Drawing.Size(158, 40);
            this.AddWalletBtn.TabIndex = 5;
            this.AddWalletBtn.Text = "Add Wallet";
            this.AddWalletBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddWalletBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddWalletBtn.UseVisualStyleBackColor = true;
            this.AddWalletBtn.Click += new System.EventHandler(this.AddWalletBtn_Click);
            // 
            // TransactionTab
            // 
            this.TransactionTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.TransactionTab.Controls.Add(this.AddTransactionBtn);
            this.TransactionTab.Controls.Add(this.TransactionContainer);
            this.TransactionTab.Location = new System.Drawing.Point(4, 22);
            this.TransactionTab.Name = "TransactionTab";
            this.TransactionTab.Padding = new System.Windows.Forms.Padding(3);
            this.TransactionTab.Size = new System.Drawing.Size(785, 649);
            this.TransactionTab.TabIndex = 1;
            this.TransactionTab.Text = "tabPage2";
            // 
            // AddTransactionBtn
            // 
            this.AddTransactionBtn.FlatAppearance.BorderSize = 0;
            this.AddTransactionBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(170)))), ((int)(((byte)(59)))));
            this.AddTransactionBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(212)))), ((int)(((byte)(37)))));
            this.AddTransactionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTransactionBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTransactionBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddTransactionBtn.Image")));
            this.AddTransactionBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddTransactionBtn.Location = new System.Drawing.Point(549, 61);
            this.AddTransactionBtn.Name = "AddTransactionBtn";
            this.AddTransactionBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.AddTransactionBtn.Size = new System.Drawing.Size(201, 40);
            this.AddTransactionBtn.TabIndex = 10;
            this.AddTransactionBtn.Text = "Add Transaction";
            this.AddTransactionBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddTransactionBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddTransactionBtn.UseVisualStyleBackColor = true;
            this.AddTransactionBtn.Click += new System.EventHandler(this.AddTransactionBtn_Click);
            // 
            // TransactionContainer
            // 
            this.TransactionContainer.Location = new System.Drawing.Point(0, 169);
            this.TransactionContainer.Name = "TransactionContainer";
            this.TransactionContainer.Size = new System.Drawing.Size(782, 391);
            this.TransactionContainer.TabIndex = 8;
            // 
            // OverviewTab
            // 
            this.OverviewTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.OverviewTab.Controls.Add(this.FilterDailyBtn);
            this.OverviewTab.Controls.Add(this.FilterYearlyBtn);
            this.OverviewTab.Controls.Add(this.FilterMonthlyBtn);
            this.OverviewTab.Controls.Add(this.FilterAllBtn);
            this.OverviewTab.Controls.Add(this.label2);
            this.OverviewTab.Controls.Add(this.TodayTransactionPanel);
            this.OverviewTab.Controls.Add(this.CategogyChart);
            this.OverviewTab.Controls.Add(this.IncomeExpenseChart);
            this.OverviewTab.Location = new System.Drawing.Point(4, 34);
            this.OverviewTab.Name = "OverviewTab";
            this.OverviewTab.Size = new System.Drawing.Size(785, 637);
            this.OverviewTab.TabIndex = 2;
            this.OverviewTab.Text = "tabPage3";
            // 
            // TodayTransactionPanel
            // 
            this.TodayTransactionPanel.BackColor = System.Drawing.Color.White;
            this.TodayTransactionPanel.Controls.Add(this.label1);
            this.TodayTransactionPanel.Location = new System.Drawing.Point(3, 155);
            this.TodayTransactionPanel.Name = "TodayTransactionPanel";
            this.TodayTransactionPanel.Size = new System.Drawing.Size(472, 414);
            this.TodayTransactionPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "No transactions today";
            // 
            // CategogyChart
            // 
            chartArea1.Name = "ChartArea1";
            this.CategogyChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.CategogyChart.Legends.Add(legend1);
            this.CategogyChart.Location = new System.Drawing.Point(521, 358);
            this.CategogyChart.Name = "CategogyChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.CategogyChart.Series.Add(series1);
            this.CategogyChart.Size = new System.Drawing.Size(237, 197);
            this.CategogyChart.TabIndex = 1;
            this.CategogyChart.Text = "chart1";
            title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(209)))));
            title1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Expense per Category";
            this.CategogyChart.Titles.Add(title1);
            // 
            // IncomeExpenseChart
            // 
            this.IncomeExpenseChart.BackImageTransparentColor = System.Drawing.Color.White;
            this.IncomeExpenseChart.BackSecondaryColor = System.Drawing.Color.White;
            this.IncomeExpenseChart.BorderSkin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(209)))));
            this.IncomeExpenseChart.BorderSkin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(209)))));
            this.IncomeExpenseChart.BorderSkin.PageColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(209)))));
            chartArea2.Name = "ChartArea1";
            this.IncomeExpenseChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.IncomeExpenseChart.Legends.Add(legend2);
            this.IncomeExpenseChart.Location = new System.Drawing.Point(521, 155);
            this.IncomeExpenseChart.Name = "IncomeExpenseChart";
            this.IncomeExpenseChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(209)))));
            series2.Legend = "Legend1";
            series2.Name = "Income";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            this.IncomeExpenseChart.Series.Add(series2);
            this.IncomeExpenseChart.Size = new System.Drawing.Size(237, 197);
            this.IncomeExpenseChart.TabIndex = 0;
            this.IncomeExpenseChart.Text = "Income-Expense";
            title2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(209)))));
            title2.BackSecondaryColor = System.Drawing.Color.White;
            title2.BorderColor = System.Drawing.Color.Transparent;
            title2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Total Income-Expense";
            title2.Text = "Income-Expense";
            this.IncomeExpenseChart.Titles.Add(title2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "TODAY TRANSACTION";
            // 
            // FilterAllBtn
            // 
            this.FilterAllBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.FilterAllBtn.AutoSize = true;
            this.FilterAllBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.FilterAllBtn.Checked = true;
            this.FilterAllBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.FilterAllBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(142)))), ((int)(((byte)(168)))));
            this.FilterAllBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(212)))), ((int)(((byte)(37)))));
            this.FilterAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterAllBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterAllBtn.Location = new System.Drawing.Point(529, 90);
            this.FilterAllBtn.Name = "FilterAllBtn";
            this.FilterAllBtn.Size = new System.Drawing.Size(34, 29);
            this.FilterAllBtn.TabIndex = 4;
            this.FilterAllBtn.Text = "All";
            this.FilterAllBtn.UseVisualStyleBackColor = false;
            this.FilterAllBtn.Click += new System.EventHandler(this.FilterAllBtn_Click);
            // 
            // FilterMonthlyBtn
            // 
            this.FilterMonthlyBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.FilterMonthlyBtn.AutoSize = true;
            this.FilterMonthlyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.FilterMonthlyBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.FilterMonthlyBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(142)))), ((int)(((byte)(168)))));
            this.FilterMonthlyBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(212)))), ((int)(((byte)(37)))));
            this.FilterMonthlyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterMonthlyBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterMonthlyBtn.Location = new System.Drawing.Point(636, 90);
            this.FilterMonthlyBtn.Name = "FilterMonthlyBtn";
            this.FilterMonthlyBtn.Size = new System.Drawing.Size(58, 29);
            this.FilterMonthlyBtn.TabIndex = 5;
            this.FilterMonthlyBtn.Text = "Month";
            this.FilterMonthlyBtn.UseVisualStyleBackColor = false;
            this.FilterMonthlyBtn.Click += new System.EventHandler(this.FilterMonthlyBtn_Click);
            // 
            // FilterYearlyBtn
            // 
            this.FilterYearlyBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.FilterYearlyBtn.AutoSize = true;
            this.FilterYearlyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.FilterYearlyBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.FilterYearlyBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(142)))), ((int)(((byte)(168)))));
            this.FilterYearlyBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(212)))), ((int)(((byte)(37)))));
            this.FilterYearlyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterYearlyBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterYearlyBtn.Location = new System.Drawing.Point(577, 90);
            this.FilterYearlyBtn.Name = "FilterYearlyBtn";
            this.FilterYearlyBtn.Size = new System.Drawing.Size(45, 29);
            this.FilterYearlyBtn.TabIndex = 6;
            this.FilterYearlyBtn.Text = "Year";
            this.FilterYearlyBtn.UseVisualStyleBackColor = false;
            this.FilterYearlyBtn.Click += new System.EventHandler(this.FilterYearlyBtn_Click);
            // 
            // FilterDailyBtn
            // 
            this.FilterDailyBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.FilterDailyBtn.AutoSize = true;
            this.FilterDailyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.FilterDailyBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.FilterDailyBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(142)))), ((int)(((byte)(168)))));
            this.FilterDailyBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(212)))), ((int)(((byte)(37)))));
            this.FilterDailyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterDailyBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterDailyBtn.Location = new System.Drawing.Point(708, 90);
            this.FilterDailyBtn.Name = "FilterDailyBtn";
            this.FilterDailyBtn.Size = new System.Drawing.Size(42, 29);
            this.FilterDailyBtn.TabIndex = 7;
            this.FilterDailyBtn.Text = "Day";
            this.FilterDailyBtn.UseVisualStyleBackColor = false;
            this.FilterDailyBtn.Visible = false;
            this.FilterDailyBtn.Click += new System.EventHandler(this.FilterDailyBtn_Click);
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
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.MenuPanel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.WalletTab.ResumeLayout(false);
            this.TransactionTab.ResumeLayout(false);
            this.OverviewTab.ResumeLayout(false);
            this.OverviewTab.PerformLayout();
            this.TodayTransactionPanel.ResumeLayout(false);
            this.TodayTransactionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategogyChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeExpenseChart)).EndInit();
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
        private System.Windows.Forms.Button OverviewMenu;
        private System.Windows.Forms.Button TransactionMenu;
        private System.Windows.Forms.Button WalletMenu;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage WalletTab;
        private System.Windows.Forms.TabPage TransactionTab;
        private System.Windows.Forms.TabPage OverviewTab;
        private System.Windows.Forms.Button AddWalletBtn;
        private System.Windows.Forms.FlowLayoutPanel WalletContainer;
        private System.Windows.Forms.Button AddTransactionBtn;
        private System.Windows.Forms.FlowLayoutPanel TransactionContainer;
        private System.Windows.Forms.DataVisualization.Charting.Chart CategogyChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart IncomeExpenseChart;
        private System.Windows.Forms.FlowLayoutPanel TodayTransactionPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton FilterDailyBtn;
        private System.Windows.Forms.RadioButton FilterYearlyBtn;
        private System.Windows.Forms.RadioButton FilterMonthlyBtn;
        private System.Windows.Forms.RadioButton FilterAllBtn;
        private System.Windows.Forms.Label label2;
    }
}