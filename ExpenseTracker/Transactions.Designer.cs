namespace ExpenseTracker
{
    partial class Transactions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.refreshBtn = new System.Windows.Forms.PictureBox();
            this.userCbx = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateLbl = new System.Windows.Forms.Label();
            this.yearlyBtn = new System.Windows.Forms.Button();
            this.monthlyBtn = new System.Windows.Forms.Button();
            this.weeklyBtn = new System.Windows.Forms.Button();
            this.dailyBtn = new System.Windows.Forms.Button();
            this.incomeBtn = new System.Windows.Forms.Button();
            this.expenseBtn = new System.Windows.Forms.Button();
            this.transactionTbl = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.dateRightBtn = new System.Windows.Forms.PictureBox();
            this.dateLeftBtn = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshBtn)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRightBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateLeftBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.refreshBtn);
            this.panel1.Location = new System.Drawing.Point(596, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 30);
            this.panel1.TabIndex = 30;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshBtn.BackColor = System.Drawing.Color.Transparent;
            this.refreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshBtn.Image = global::ExpenseTracker.Properties.Resources.loading_arrow;
            this.refreshBtn.Location = new System.Drawing.Point(3, 3);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(24, 24);
            this.refreshBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refreshBtn.TabIndex = 8;
            this.refreshBtn.TabStop = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            this.refreshBtn.MouseHover += new System.EventHandler(this.refreshBtn_MouseHover);
            // 
            // userCbx
            // 
            this.userCbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userCbx.BackColor = System.Drawing.Color.Silver;
            this.userCbx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userCbx.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.userCbx.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userCbx.ForeColor = System.Drawing.Color.Black;
            this.userCbx.FormattingEnabled = true;
            this.userCbx.ItemHeight = 22;
            this.userCbx.Location = new System.Drawing.Point(662, 13);
            this.userCbx.Name = "userCbx";
            this.userCbx.Size = new System.Drawing.Size(132, 30);
            this.userCbx.TabIndex = 29;
            this.userCbx.SelectedIndexChanged += new System.EventHandler(this.userCbx_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(632, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(30, 30);
            this.panel4.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::ExpenseTracker.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // dateLbl
            // 
            this.dateLbl.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.dateLbl.Location = new System.Drawing.Point(42, 16);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(195, 28);
            this.dateLbl.TabIndex = 25;
            this.dateLbl.Text = "2024";
            this.dateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yearlyBtn
            // 
            this.yearlyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.yearlyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.yearlyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yearlyBtn.FlatAppearance.BorderSize = 0;
            this.yearlyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yearlyBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearlyBtn.ForeColor = System.Drawing.Color.White;
            this.yearlyBtn.Location = new System.Drawing.Point(510, 13);
            this.yearlyBtn.Name = "yearlyBtn";
            this.yearlyBtn.Size = new System.Drawing.Size(70, 30);
            this.yearlyBtn.TabIndex = 34;
            this.yearlyBtn.Text = "Yearly";
            this.yearlyBtn.UseVisualStyleBackColor = false;
            this.yearlyBtn.Click += new System.EventHandler(this.yearlyBtn_Click);
            // 
            // monthlyBtn
            // 
            this.monthlyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthlyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.monthlyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.monthlyBtn.FlatAppearance.BorderSize = 0;
            this.monthlyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monthlyBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyBtn.ForeColor = System.Drawing.Color.White;
            this.monthlyBtn.Location = new System.Drawing.Point(434, 13);
            this.monthlyBtn.Name = "monthlyBtn";
            this.monthlyBtn.Size = new System.Drawing.Size(70, 30);
            this.monthlyBtn.TabIndex = 33;
            this.monthlyBtn.Text = "Monthly";
            this.monthlyBtn.UseVisualStyleBackColor = false;
            this.monthlyBtn.Click += new System.EventHandler(this.monthlyBtn_Click);
            // 
            // weeklyBtn
            // 
            this.weeklyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.weeklyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.weeklyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.weeklyBtn.FlatAppearance.BorderSize = 0;
            this.weeklyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.weeklyBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weeklyBtn.ForeColor = System.Drawing.Color.White;
            this.weeklyBtn.Location = new System.Drawing.Point(358, 13);
            this.weeklyBtn.Name = "weeklyBtn";
            this.weeklyBtn.Size = new System.Drawing.Size(70, 30);
            this.weeklyBtn.TabIndex = 32;
            this.weeklyBtn.Text = "Weekly";
            this.weeklyBtn.UseVisualStyleBackColor = false;
            this.weeklyBtn.Click += new System.EventHandler(this.weeklyBtn_Click);
            // 
            // dailyBtn
            // 
            this.dailyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dailyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.dailyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dailyBtn.FlatAppearance.BorderSize = 0;
            this.dailyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dailyBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyBtn.ForeColor = System.Drawing.Color.White;
            this.dailyBtn.Location = new System.Drawing.Point(282, 13);
            this.dailyBtn.Name = "dailyBtn";
            this.dailyBtn.Size = new System.Drawing.Size(70, 30);
            this.dailyBtn.TabIndex = 31;
            this.dailyBtn.Text = "Daily";
            this.dailyBtn.UseVisualStyleBackColor = false;
            this.dailyBtn.Click += new System.EventHandler(this.dailyBtn_Click);
            // 
            // incomeBtn
            // 
            this.incomeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.incomeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.incomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.incomeBtn.FlatAppearance.BorderSize = 0;
            this.incomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incomeBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeBtn.ForeColor = System.Drawing.Color.White;
            this.incomeBtn.Location = new System.Drawing.Point(110, 67);
            this.incomeBtn.Name = "incomeBtn";
            this.incomeBtn.Size = new System.Drawing.Size(76, 32);
            this.incomeBtn.TabIndex = 36;
            this.incomeBtn.Text = "Income";
            this.incomeBtn.UseVisualStyleBackColor = false;
            this.incomeBtn.Click += new System.EventHandler(this.incomeBtn_Click);
            // 
            // expenseBtn
            // 
            this.expenseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.expenseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.expenseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expenseBtn.FlatAppearance.BorderSize = 0;
            this.expenseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expenseBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseBtn.ForeColor = System.Drawing.Color.White;
            this.expenseBtn.Location = new System.Drawing.Point(29, 67);
            this.expenseBtn.Name = "expenseBtn";
            this.expenseBtn.Size = new System.Drawing.Size(76, 32);
            this.expenseBtn.TabIndex = 35;
            this.expenseBtn.Text = "Expense";
            this.expenseBtn.UseVisualStyleBackColor = false;
            this.expenseBtn.Click += new System.EventHandler(this.expenseBtn_Click);
            // 
            // transactionTbl
            // 
            this.transactionTbl.AllowUserToAddRows = false;
            this.transactionTbl.AllowUserToDeleteRows = false;
            this.transactionTbl.AllowUserToResizeColumns = false;
            this.transactionTbl.AllowUserToResizeRows = false;
            this.transactionTbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.transactionTbl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.transactionTbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.transactionTbl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(6);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transactionTbl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.transactionTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionTbl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.category,
            this.amount,
            this.notes});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.transactionTbl.DefaultCellStyle = dataGridViewCellStyle2;
            this.transactionTbl.EnableHeadersVisualStyles = false;
            this.transactionTbl.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.transactionTbl.Location = new System.Drawing.Point(29, 105);
            this.transactionTbl.MultiSelect = false;
            this.transactionTbl.Name = "transactionTbl";
            this.transactionTbl.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transactionTbl.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.transactionTbl.RowHeadersVisible = false;
            this.transactionTbl.Size = new System.Drawing.Size(753, 315);
            this.transactionTbl.TabIndex = 37;
            this.transactionTbl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.transactionTbl_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.FillWeight = 30.15228F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // category
            // 
            this.category.DataPropertyName = "category";
            this.category.FillWeight = 129.9492F;
            this.category.HeaderText = "Category";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.DataPropertyName = "amount";
            this.amount.FillWeight = 129.9492F;
            this.amount.HeaderText = "Amount";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // notes
            // 
            this.notes.DataPropertyName = "notes";
            this.notes.FillWeight = 129.9492F;
            this.notes.HeaderText = "Notes";
            this.notes.Name = "notes";
            this.notes.ReadOnly = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(725, 67);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(57, 32);
            this.deleteBtn.TabIndex = 39;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.editBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.Location = new System.Drawing.Point(658, 67);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(57, 32);
            this.editBtn.TabIndex = 38;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // dateRightBtn
            // 
            this.dateRightBtn.BackColor = System.Drawing.Color.Transparent;
            this.dateRightBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateRightBtn.Image = global::ExpenseTracker.Properties.Resources.right_arrow_icon;
            this.dateRightBtn.Location = new System.Drawing.Point(238, 4);
            this.dateRightBtn.Name = "dateRightBtn";
            this.dateRightBtn.Size = new System.Drawing.Size(26, 52);
            this.dateRightBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dateRightBtn.TabIndex = 27;
            this.dateRightBtn.TabStop = false;
            this.dateRightBtn.Click += new System.EventHandler(this.dateRightBtn_Click);
            // 
            // dateLeftBtn
            // 
            this.dateLeftBtn.BackColor = System.Drawing.Color.Transparent;
            this.dateLeftBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateLeftBtn.Image = global::ExpenseTracker.Properties.Resources.left_arrow_icon;
            this.dateLeftBtn.Location = new System.Drawing.Point(15, 4);
            this.dateLeftBtn.Name = "dateLeftBtn";
            this.dateLeftBtn.Size = new System.Drawing.Size(26, 52);
            this.dateLeftBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dateLeftBtn.TabIndex = 26;
            this.dateLeftBtn.TabStop = false;
            this.dateLeftBtn.Click += new System.EventHandler(this.dateLeftBtn_Click);
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.transactionTbl);
            this.Controls.Add(this.incomeBtn);
            this.Controls.Add(this.expenseBtn);
            this.Controls.Add(this.yearlyBtn);
            this.Controls.Add(this.monthlyBtn);
            this.Controls.Add(this.weeklyBtn);
            this.Controls.Add(this.dailyBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userCbx);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dateRightBtn);
            this.Controls.Add(this.dateLeftBtn);
            this.Controls.Add(this.dateLbl);
            this.Name = "Transactions";
            this.Size = new System.Drawing.Size(810, 440);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.refreshBtn)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRightBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateLeftBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox refreshBtn;
        private System.Windows.Forms.ComboBox userCbx;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox dateRightBtn;
        private System.Windows.Forms.PictureBox dateLeftBtn;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Button yearlyBtn;
        private System.Windows.Forms.Button monthlyBtn;
        private System.Windows.Forms.Button weeklyBtn;
        private System.Windows.Forms.Button dailyBtn;
        private System.Windows.Forms.Button incomeBtn;
        private System.Windows.Forms.Button expenseBtn;
        private System.Windows.Forms.DataGridView transactionTbl;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn notes;
    }
}
