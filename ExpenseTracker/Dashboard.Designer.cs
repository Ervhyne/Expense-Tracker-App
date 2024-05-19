namespace ExpenseTracker
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.yearlyBtn = new System.Windows.Forms.Button();
            this.monthlyBtn = new System.Windows.Forms.Button();
            this.weeklyBtn = new System.Windows.Forms.Button();
            this.dailyBtn = new System.Windows.Forms.Button();
            this.userCbx = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.summaryPanel = new System.Windows.Forms.Panel();
            this.expenseBtn = new System.Windows.Forms.Button();
            this.transactionTbl = new System.Windows.Forms.DataGridView();
            this.incomeBtn = new System.Windows.Forms.Button();
            this.balanceLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.expenseMoneyLbl = new System.Windows.Forms.Label();
            this.incomeMoneyLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.ExpenseChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.refreshBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateRightBtn = new System.Windows.Forms.PictureBox();
            this.dateLeftBtn = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.summaryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRightBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateLeftBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.yearlyBtn);
            this.panel3.Controls.Add(this.monthlyBtn);
            this.panel3.Controls.Add(this.weeklyBtn);
            this.panel3.Controls.Add(this.dailyBtn);
            this.panel3.Controls.Add(this.userCbx);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.summaryPanel);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.dateRightBtn);
            this.panel3.Controls.Add(this.dateLeftBtn);
            this.panel3.Controls.Add(this.dateLbl);
            this.panel3.Controls.Add(this.ExpenseChart);
            this.panel3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(810, 440);
            this.panel3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.refreshBtn);
            this.panel1.Location = new System.Drawing.Point(596, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 30);
            this.panel1.TabIndex = 9;
            // 
            // yearlyBtn
            // 
            this.yearlyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.yearlyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.yearlyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yearlyBtn.FlatAppearance.BorderSize = 0;
            this.yearlyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yearlyBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearlyBtn.Location = new System.Drawing.Point(718, 171);
            this.yearlyBtn.Name = "yearlyBtn";
            this.yearlyBtn.Size = new System.Drawing.Size(76, 32);
            this.yearlyBtn.TabIndex = 18;
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
            this.monthlyBtn.Location = new System.Drawing.Point(718, 133);
            this.monthlyBtn.Name = "monthlyBtn";
            this.monthlyBtn.Size = new System.Drawing.Size(76, 32);
            this.monthlyBtn.TabIndex = 17;
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
            this.weeklyBtn.Location = new System.Drawing.Point(718, 95);
            this.weeklyBtn.Name = "weeklyBtn";
            this.weeklyBtn.Size = new System.Drawing.Size(76, 32);
            this.weeklyBtn.TabIndex = 16;
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
            this.dailyBtn.Location = new System.Drawing.Point(718, 57);
            this.dailyBtn.Name = "dailyBtn";
            this.dailyBtn.Size = new System.Drawing.Size(76, 32);
            this.dailyBtn.TabIndex = 15;
            this.dailyBtn.Text = "Daily";
            this.dailyBtn.UseVisualStyleBackColor = false;
            this.dailyBtn.Click += new System.EventHandler(this.dailyBtn_Click);
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
            this.userCbx.TabIndex = 7;
            this.userCbx.SelectedIndexChanged += new System.EventHandler(this.UserCbx_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(632, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(30, 30);
            this.panel4.TabIndex = 6;
            // 
            // summaryPanel
            // 
            this.summaryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.summaryPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.summaryPanel.Controls.Add(this.expenseBtn);
            this.summaryPanel.Controls.Add(this.transactionTbl);
            this.summaryPanel.Controls.Add(this.incomeBtn);
            this.summaryPanel.Controls.Add(this.balanceLbl);
            this.summaryPanel.Controls.Add(this.label6);
            this.summaryPanel.Controls.Add(this.panel2);
            this.summaryPanel.Controls.Add(this.expenseMoneyLbl);
            this.summaryPanel.Controls.Add(this.incomeMoneyLbl);
            this.summaryPanel.Controls.Add(this.label3);
            this.summaryPanel.Controls.Add(this.label2);
            this.summaryPanel.Location = new System.Drawing.Point(16, 104);
            this.summaryPanel.Name = "summaryPanel";
            this.summaryPanel.Size = new System.Drawing.Size(248, 321);
            this.summaryPanel.TabIndex = 4;
            // 
            // expenseBtn
            // 
            this.expenseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.expenseBtn.BackColor = System.Drawing.Color.Transparent;
            this.expenseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expenseBtn.FlatAppearance.BorderSize = 2;
            this.expenseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.expenseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.expenseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expenseBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseBtn.Location = new System.Drawing.Point(127, 277);
            this.expenseBtn.Name = "expenseBtn";
            this.expenseBtn.Size = new System.Drawing.Size(76, 32);
            this.expenseBtn.TabIndex = 14;
            this.expenseBtn.Text = "Expense";
            this.expenseBtn.UseVisualStyleBackColor = false;
            this.expenseBtn.Click += new System.EventHandler(this.expenseBtn_Click);
            this.expenseBtn.MouseHover += new System.EventHandler(this.expenseBtn_MouseHover);
            // 
            // transactionTbl
            // 
            this.transactionTbl.AllowUserToAddRows = false;
            this.transactionTbl.AllowUserToDeleteRows = false;
            this.transactionTbl.AllowUserToResizeColumns = false;
            this.transactionTbl.AllowUserToResizeRows = false;
            this.transactionTbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.transactionTbl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.transactionTbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(6);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transactionTbl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.transactionTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionTbl.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.transactionTbl.DefaultCellStyle = dataGridViewCellStyle2;
            this.transactionTbl.EnableHeadersVisualStyles = false;
            this.transactionTbl.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.transactionTbl.Location = new System.Drawing.Point(13, 46);
            this.transactionTbl.MultiSelect = false;
            this.transactionTbl.Name = "transactionTbl";
            this.transactionTbl.ReadOnly = true;
            this.transactionTbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transactionTbl.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.transactionTbl.RowHeadersVisible = false;
            this.transactionTbl.Size = new System.Drawing.Size(224, 195);
            this.transactionTbl.TabIndex = 23;
            // 
            // incomeBtn
            // 
            this.incomeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.incomeBtn.BackColor = System.Drawing.Color.Transparent;
            this.incomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.incomeBtn.FlatAppearance.BorderSize = 2;
            this.incomeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.incomeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.incomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incomeBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeBtn.Location = new System.Drawing.Point(38, 277);
            this.incomeBtn.Name = "incomeBtn";
            this.incomeBtn.Size = new System.Drawing.Size(76, 32);
            this.incomeBtn.TabIndex = 13;
            this.incomeBtn.Text = "Income";
            this.incomeBtn.UseVisualStyleBackColor = false;
            this.incomeBtn.Click += new System.EventHandler(this.incomeBtn_Click);
            this.incomeBtn.MouseHover += new System.EventHandler(this.incomeBtn_MouseHover);
            // 
            // balanceLbl
            // 
            this.balanceLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.balanceLbl.BackColor = System.Drawing.Color.Transparent;
            this.balanceLbl.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLbl.Location = new System.Drawing.Point(87, 251);
            this.balanceLbl.Name = "balanceLbl";
            this.balanceLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.balanceLbl.Size = new System.Drawing.Size(155, 20);
            this.balanceLbl.TabIndex = 12;
            this.balanceLbl.Text = "₱0";
            this.balanceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Balance: ";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(7, 246);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 2);
            this.panel2.TabIndex = 10;
            // 
            // expenseMoneyLbl
            // 
            this.expenseMoneyLbl.BackColor = System.Drawing.Color.Transparent;
            this.expenseMoneyLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseMoneyLbl.Location = new System.Drawing.Point(72, 23);
            this.expenseMoneyLbl.Name = "expenseMoneyLbl";
            this.expenseMoneyLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.expenseMoneyLbl.Size = new System.Drawing.Size(173, 20);
            this.expenseMoneyLbl.TabIndex = 8;
            this.expenseMoneyLbl.Text = "₱1000";
            this.expenseMoneyLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // incomeMoneyLbl
            // 
            this.incomeMoneyLbl.BackColor = System.Drawing.Color.Transparent;
            this.incomeMoneyLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeMoneyLbl.Location = new System.Drawing.Point(63, 3);
            this.incomeMoneyLbl.Name = "incomeMoneyLbl";
            this.incomeMoneyLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.incomeMoneyLbl.Size = new System.Drawing.Size(182, 20);
            this.incomeMoneyLbl.TabIndex = 7;
            this.incomeMoneyLbl.Text = "₱1000";
            this.incomeMoneyLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Expense: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Income: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Summary";
            // 
            // dateLbl
            // 
            this.dateLbl.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.dateLbl.Location = new System.Drawing.Point(42, 16);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(195, 28);
            this.dateLbl.TabIndex = 0;
            this.dateLbl.Text = "Mon, 7 May";
            this.dateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExpenseChart
            // 
            this.ExpenseChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ExpenseChart.BackColor = System.Drawing.Color.Transparent;
            this.ExpenseChart.BorderlineColor = System.Drawing.Color.Transparent;
            this.ExpenseChart.BorderlineWidth = 0;
            chartArea1.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea1.AlignmentStyle = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.None;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            chartArea1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            chartArea1.Name = "ChartArea1";
            this.ExpenseChart.ChartAreas.Add(chartArea1);
            this.ExpenseChart.Location = new System.Drawing.Point(270, 95);
            this.ExpenseChart.Name = "ExpenseChart";
            this.ExpenseChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Color = System.Drawing.SystemColors.ActiveBorder;
            series1.LabelBackColor = System.Drawing.Color.Transparent;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Name = "Amount";
            series1.YValuesPerPoint = 4;
            this.ExpenseChart.Series.Add(series1);
            this.ExpenseChart.Size = new System.Drawing.Size(442, 327);
            this.ExpenseChart.TabIndex = 5;
            this.ExpenseChart.Text = "chart1";
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
            // dateRightBtn
            // 
            this.dateRightBtn.BackColor = System.Drawing.Color.Transparent;
            this.dateRightBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateRightBtn.Image = global::ExpenseTracker.Properties.Resources.right_arrow_icon;
            this.dateRightBtn.Location = new System.Drawing.Point(238, 4);
            this.dateRightBtn.Name = "dateRightBtn";
            this.dateRightBtn.Size = new System.Drawing.Size(26, 52);
            this.dateRightBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dateRightBtn.TabIndex = 2;
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
            this.dateLeftBtn.TabIndex = 1;
            this.dateLeftBtn.TabStop = false;
            this.dateLeftBtn.Click += new System.EventHandler(this.dateLeftBtn_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.Controls.Add(this.panel3);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(810, 440);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.summaryPanel.ResumeLayout(false);
            this.summaryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRightBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateLeftBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button yearlyBtn;
        private System.Windows.Forms.Button monthlyBtn;
        private System.Windows.Forms.Button weeklyBtn;
        private System.Windows.Forms.Button dailyBtn;
        private System.Windows.Forms.ComboBox userCbx;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ExpenseChart;
        private System.Windows.Forms.Panel summaryPanel;
        private System.Windows.Forms.Button expenseBtn;
        private System.Windows.Forms.Button incomeBtn;
        private System.Windows.Forms.Label balanceLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label expenseMoneyLbl;
        private System.Windows.Forms.Label incomeMoneyLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox dateRightBtn;
        private System.Windows.Forms.PictureBox dateLeftBtn;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.DataGridView transactionTbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox refreshBtn;
    }
}
