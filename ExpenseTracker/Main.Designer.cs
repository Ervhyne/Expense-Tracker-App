namespace ExpenseTracker
{
    partial class MaterialForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.accountsBtn = new System.Windows.Forms.Button();
            this.categoriesBtn = new System.Windows.Forms.Button();
            this.reportsBtn = new System.Windows.Forms.Button();
            this.transactionsBtn = new System.Windows.Forms.Button();
            this.dashboardBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.accounts1 = new ExpenseTracker.Accounts();
            this.category1 = new ExpenseTracker.Category();
            this.dashboard1 = new ExpenseTracker.Dashboard();
            this.reports1 = new ExpenseTracker.Reports();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(112)))), ((int)(((byte)(163)))));
            this.panel1.Controls.Add(this.accountsBtn);
            this.panel1.Controls.Add(this.categoriesBtn);
            this.panel1.Controls.Add(this.reportsBtn);
            this.panel1.Controls.Add(this.transactionsBtn);
            this.panel1.Controls.Add(this.dashboardBtn);
            this.panel1.Location = new System.Drawing.Point(-1, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 36);
            this.panel1.TabIndex = 0;
            // 
            // accountsBtn
            // 
            this.accountsBtn.BackColor = System.Drawing.Color.Transparent;
            this.accountsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.accountsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accountsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(112)))), ((int)(((byte)(163)))));
            this.accountsBtn.FlatAppearance.BorderSize = 0;
            this.accountsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            this.accountsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(121)))));
            this.accountsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountsBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountsBtn.ForeColor = System.Drawing.Color.White;
            this.accountsBtn.Location = new System.Drawing.Point(445, 2);
            this.accountsBtn.Name = "accountsBtn";
            this.accountsBtn.Size = new System.Drawing.Size(105, 32);
            this.accountsBtn.TabIndex = 4;
            this.accountsBtn.Text = "Accounts";
            this.accountsBtn.UseVisualStyleBackColor = false;
            this.accountsBtn.Click += new System.EventHandler(this.accountsBtn_Click);
            // 
            // categoriesBtn
            // 
            this.categoriesBtn.BackColor = System.Drawing.Color.Transparent;
            this.categoriesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.categoriesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoriesBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(112)))), ((int)(((byte)(163)))));
            this.categoriesBtn.FlatAppearance.BorderSize = 0;
            this.categoriesBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            this.categoriesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(121)))));
            this.categoriesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoriesBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriesBtn.ForeColor = System.Drawing.Color.White;
            this.categoriesBtn.Location = new System.Drawing.Point(337, 2);
            this.categoriesBtn.Name = "categoriesBtn";
            this.categoriesBtn.Size = new System.Drawing.Size(105, 32);
            this.categoriesBtn.TabIndex = 3;
            this.categoriesBtn.Text = "Categories";
            this.categoriesBtn.UseVisualStyleBackColor = false;
            this.categoriesBtn.Click += new System.EventHandler(this.categoriesBtn_Click);
            // 
            // reportsBtn
            // 
            this.reportsBtn.BackColor = System.Drawing.Color.Transparent;
            this.reportsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.reportsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(112)))), ((int)(((byte)(163)))));
            this.reportsBtn.FlatAppearance.BorderSize = 0;
            this.reportsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            this.reportsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(121)))));
            this.reportsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportsBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsBtn.ForeColor = System.Drawing.Color.White;
            this.reportsBtn.Location = new System.Drawing.Point(229, 2);
            this.reportsBtn.Name = "reportsBtn";
            this.reportsBtn.Size = new System.Drawing.Size(105, 32);
            this.reportsBtn.TabIndex = 2;
            this.reportsBtn.Text = "Reports";
            this.reportsBtn.UseVisualStyleBackColor = false;
            this.reportsBtn.Click += new System.EventHandler(this.reportsBtn_Click);
            // 
            // transactionsBtn
            // 
            this.transactionsBtn.BackColor = System.Drawing.Color.Transparent;
            this.transactionsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.transactionsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transactionsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(112)))), ((int)(((byte)(163)))));
            this.transactionsBtn.FlatAppearance.BorderSize = 0;
            this.transactionsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            this.transactionsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(121)))));
            this.transactionsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transactionsBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionsBtn.ForeColor = System.Drawing.Color.White;
            this.transactionsBtn.Location = new System.Drawing.Point(121, 2);
            this.transactionsBtn.Name = "transactionsBtn";
            this.transactionsBtn.Size = new System.Drawing.Size(105, 32);
            this.transactionsBtn.TabIndex = 1;
            this.transactionsBtn.Text = "Transactions";
            this.transactionsBtn.UseVisualStyleBackColor = false;
            this.transactionsBtn.Click += new System.EventHandler(this.transactionsBtn_Click);
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.BackColor = System.Drawing.Color.Transparent;
            this.dashboardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboardBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(112)))), ((int)(((byte)(163)))));
            this.dashboardBtn.FlatAppearance.BorderSize = 0;
            this.dashboardBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            this.dashboardBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(121)))));
            this.dashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBtn.ForeColor = System.Drawing.Color.White;
            this.dashboardBtn.Location = new System.Drawing.Point(13, 2);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Size = new System.Drawing.Size(105, 32);
            this.dashboardBtn.TabIndex = 0;
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.UseVisualStyleBackColor = false;
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reports1);
            this.panel2.Controls.Add(this.accounts1);
            this.panel2.Controls.Add(this.category1);
            this.panel2.Controls.Add(this.dashboard1);
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(810, 440);
            this.panel2.TabIndex = 3;
            // 
            // accounts1
            // 
            this.accounts1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.accounts1.Location = new System.Drawing.Point(0, 0);
            this.accounts1.Name = "accounts1";
            this.accounts1.Size = new System.Drawing.Size(810, 440);
            this.accounts1.TabIndex = 2;
            // 
            // category1
            // 
            this.category1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.category1.Location = new System.Drawing.Point(0, 0);
            this.category1.Name = "category1";
            this.category1.Size = new System.Drawing.Size(810, 440);
            this.category1.TabIndex = 1;
            // 
            // dashboard1
            // 
            this.dashboard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.dashboard1.Location = new System.Drawing.Point(0, 0);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(810, 440);
            this.dashboard1.TabIndex = 3;
            // 
            // reports1
            // 
            this.reports1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.reports1.Location = new System.Drawing.Point(0, 0);
            this.reports1.Name = "reports1";
            this.reports1.Size = new System.Drawing.Size(810, 440);
            this.reports1.TabIndex = 4;
            // 
            // MaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(810, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "MaterialForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MaterialForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button dashboardBtn;
        private System.Windows.Forms.Button transactionsBtn;
        private System.Windows.Forms.Button reportsBtn;
        private System.Windows.Forms.Button accountsBtn;
        private System.Windows.Forms.Button categoriesBtn;
        private System.Windows.Forms.Panel panel2;
        private Accounts accounts1;
        private Category category1;
        private Dashboard dashboard1;
        private Reports reports1;
    }
}

