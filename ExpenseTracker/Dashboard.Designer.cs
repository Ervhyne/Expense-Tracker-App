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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.yearlyBtn = new System.Windows.Forms.Button();
            this.monthlyBtn = new System.Windows.Forms.Button();
            this.weeklyBtn = new System.Windows.Forms.Button();
            this.dailyBtn = new System.Windows.Forms.Button();
            this.usersCbx = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ExpenseChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.summaryPanel = new System.Windows.Forms.Panel();
            this.expenseBtn = new System.Windows.Forms.Button();
            this.incomeBtn = new System.Windows.Forms.Button();
            this.balanceLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.expenseMoneybl = new System.Windows.Forms.Label();
            this.incomeMoneyLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateRightBtn = new System.Windows.Forms.PictureBox();
            this.dateLeftBtn = new System.Windows.Forms.PictureBox();
            this.dateLbl = new System.Windows.Forms.Label();
            this.transactionTbl = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseChart)).BeginInit();
            this.summaryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateRightBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateLeftBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTbl)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.yearlyBtn);
            this.panel3.Controls.Add(this.monthlyBtn);
            this.panel3.Controls.Add(this.weeklyBtn);
            this.panel3.Controls.Add(this.dailyBtn);
            this.panel3.Controls.Add(this.usersCbx);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.ExpenseChart);
            this.panel3.Controls.Add(this.summaryPanel);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.dateRightBtn);
            this.panel3.Controls.Add(this.dateLeftBtn);
            this.panel3.Controls.Add(this.dateLbl);
            this.panel3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(810, 440);
            this.panel3.TabIndex = 2;
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
            // 
            // usersCbx
            // 
            this.usersCbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.usersCbx.BackColor = System.Drawing.Color.Silver;
            this.usersCbx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usersCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usersCbx.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.usersCbx.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersCbx.ForeColor = System.Drawing.Color.Black;
            this.usersCbx.FormattingEnabled = true;
            this.usersCbx.ItemHeight = 23;
            this.usersCbx.Location = new System.Drawing.Point(697, 10);
            this.usersCbx.Name = "usersCbx";
            this.usersCbx.Size = new System.Drawing.Size(97, 31);
            this.usersCbx.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(667, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(31, 31);
            this.panel4.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ExpenseTracker.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
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
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.HeaderSeparatorColor = System.Drawing.Color.White;
            legend1.ItemColumnSeparatorColor = System.Drawing.Color.Transparent;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Legend1";
            legend1.TitleBackColor = System.Drawing.Color.Transparent;
            this.ExpenseChart.Legends.Add(legend1);
            this.ExpenseChart.Location = new System.Drawing.Point(269, 79);
            this.ExpenseChart.Name = "ExpenseChart";
            this.ExpenseChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Color = System.Drawing.SystemColors.ActiveBorder;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ExpenseChart.Series.Add(series1);
            this.ExpenseChart.Size = new System.Drawing.Size(490, 346);
            this.ExpenseChart.TabIndex = 5;
            this.ExpenseChart.Text = "chart1";
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
            this.summaryPanel.Controls.Add(this.expenseMoneybl);
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
            // expenseMoneybl
            // 
            this.expenseMoneybl.BackColor = System.Drawing.Color.Transparent;
            this.expenseMoneybl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseMoneybl.Location = new System.Drawing.Point(72, 23);
            this.expenseMoneybl.Name = "expenseMoneybl";
            this.expenseMoneybl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.expenseMoneybl.Size = new System.Drawing.Size(173, 20);
            this.expenseMoneybl.TabIndex = 8;
            this.expenseMoneybl.Text = "₱1000";
            this.expenseMoneybl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // 
            // dateLeftBtn
            // 
            this.dateLeftBtn.BackColor = System.Drawing.Color.Transparent;
            this.dateLeftBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateLeftBtn.Image = global::ExpenseTracker.Properties.Resources.left_arrow_icon;
            this.dateLeftBtn.Location = new System.Drawing.Point(27, 4);
            this.dateLeftBtn.Name = "dateLeftBtn";
            this.dateLeftBtn.Size = new System.Drawing.Size(26, 52);
            this.dateLeftBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dateLeftBtn.TabIndex = 1;
            this.dateLeftBtn.TabStop = false;
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.dateLbl.Location = new System.Drawing.Point(74, 16);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(135, 28);
            this.dateLbl.TabIndex = 0;
            this.dateLbl.Text = "Mon, 7 May";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
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
            this.transactionTbl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.transactionTbl.DefaultCellStyle = dataGridViewCellStyle2;
            this.transactionTbl.EnableHeadersVisualStyles = false;
            this.transactionTbl.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
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
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.Controls.Add(this.panel3);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(810, 440);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseChart)).EndInit();
            this.summaryPanel.ResumeLayout(false);
            this.summaryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateRightBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateLeftBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTbl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button yearlyBtn;
        private System.Windows.Forms.Button monthlyBtn;
        private System.Windows.Forms.Button weeklyBtn;
        private System.Windows.Forms.Button dailyBtn;
        private System.Windows.Forms.ComboBox usersCbx;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ExpenseChart;
        private System.Windows.Forms.Panel summaryPanel;
        private System.Windows.Forms.Button expenseBtn;
        private System.Windows.Forms.Button incomeBtn;
        private System.Windows.Forms.Label balanceLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label expenseMoneybl;
        private System.Windows.Forms.Label incomeMoneyLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox dateRightBtn;
        private System.Windows.Forms.PictureBox dateLeftBtn;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.DataGridView transactionTbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}
