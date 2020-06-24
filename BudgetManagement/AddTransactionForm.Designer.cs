namespace BudgetManagement
{
    partial class AddTransactionForm
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
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.income = new System.Windows.Forms.RadioButton();
            this.expense = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.value = new System.Windows.Forms.NumericUpDown();
            this.time = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.note = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.wallet = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.categogyName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.value)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(285, 399);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(5);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 30);
            this.CancelBtn.TabIndex = 20;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(212)))), ((int)(((byte)(37)))));
            this.SubmitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubmitBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SubmitBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SubmitBtn.FlatAppearance.BorderSize = 0;
            this.SubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitBtn.Location = new System.Drawing.Point(170, 399);
            this.SubmitBtn.Margin = new System.Windows.Forms.Padding(5);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(75, 30);
            this.SubmitBtn.TabIndex = 19;
            this.SubmitBtn.Text = "OK";
            this.SubmitBtn.UseVisualStyleBackColor = false;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "ADD TRANSACTION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Type";
            // 
            // income
            // 
            this.income.Appearance = System.Windows.Forms.Appearance.Button;
            this.income.AutoSize = true;
            this.income.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(177)))), ((int)(((byte)(214)))));
            this.income.Checked = true;
            this.income.Cursor = System.Windows.Forms.Cursors.Hand;
            this.income.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.income.FlatAppearance.BorderSize = 0;
            this.income.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(96)))), ((int)(((byte)(115)))));
            this.income.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income.Location = new System.Drawing.Point(60, 136);
            this.income.Name = "income";
            this.income.Size = new System.Drawing.Size(78, 33);
            this.income.TabIndex = 22;
            this.income.TabStop = true;
            this.income.Text = "Income";
            this.income.UseVisualStyleBackColor = false;
            // 
            // expense
            // 
            this.expense.Appearance = System.Windows.Forms.Appearance.Button;
            this.expense.AutoSize = true;
            this.expense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(177)))), ((int)(((byte)(214)))));
            this.expense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expense.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.expense.FlatAppearance.BorderSize = 0;
            this.expense.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(96)))), ((int)(((byte)(115)))));
            this.expense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expense.Location = new System.Drawing.Point(162, 136);
            this.expense.Name = "expense";
            this.expense.Size = new System.Drawing.Size(83, 33);
            this.expense.TabIndex = 23;
            this.expense.TabStop = true;
            this.expense.Text = "Expense";
            this.expense.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "Value";
            // 
            // value
            // 
            this.value.Location = new System.Drawing.Point(304, 137);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(185, 31);
            this.value.TabIndex = 25;
            this.value.ThousandsSeparator = true;
            // 
            // time
            // 
            this.time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.time.Location = new System.Drawing.Point(304, 209);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(185, 31);
            this.time.TabIndex = 26;
            this.time.Value = new System.DateTime(2020, 6, 24, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 23);
            this.label4.TabIndex = 27;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 23);
            this.label5.TabIndex = 28;
            this.label5.Text = "Note";
            // 
            // note
            // 
            this.note.Location = new System.Drawing.Point(304, 281);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(186, 96);
            this.note.TabIndex = 29;
            this.note.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 23);
            this.label6.TabIndex = 30;
            this.label6.Text = "Wallet";
            // 
            // wallet
            // 
            this.wallet.FormattingEnabled = true;
            this.wallet.Location = new System.Drawing.Point(59, 209);
            this.wallet.Name = "wallet";
            this.wallet.Size = new System.Drawing.Size(186, 31);
            this.wallet.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(212)))), ((int)(((byte)(37)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(59, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 43);
            this.button1.TabIndex = 32;
            this.button1.Text = "Choose icon";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // categogyName
            // 
            this.categogyName.AutoSize = true;
            this.categogyName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categogyName.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categogyName.Location = new System.Drawing.Point(57, 320);
            this.categogyName.Name = "categogyName";
            this.categogyName.Size = new System.Drawing.Size(33, 18);
            this.categogyName.TabIndex = 33;
            this.categogyName.Text = "icon";
            // 
            // AddTransactionForm
            // 
            this.AcceptButton = this.SubmitBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(544, 463);
            this.Controls.Add(this.categogyName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.wallet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.note);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.time);
            this.Controls.Add(this.value);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.expense);
            this.Controls.Add(this.income);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddTransactionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTransactionForm";
            this.Load += new System.EventHandler(this.AddTransactionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.value)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.RadioButton income;
        public System.Windows.Forms.RadioButton expense;
        public System.Windows.Forms.DateTimePicker time;
        public System.Windows.Forms.RichTextBox note;
        public System.Windows.Forms.ComboBox wallet;
        public System.Windows.Forms.Label categogyName;
        public System.Windows.Forms.NumericUpDown value;
        public System.Windows.Forms.Button button1;
    }
}