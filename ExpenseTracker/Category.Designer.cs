
namespace ExpenseTracker
{
    partial class Category
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
            this.label1 = new System.Windows.Forms.Label();
            this.categoryTbl_category = new System.Windows.Forms.DataGridView();
            this.expenseBtn_category = new System.Windows.Forms.Button();
            this.incomeBtn_category = new System.Windows.Forms.Button();
            this.addBtn_category = new System.Windows.Forms.Button();
            this.editBtn_category = new System.Windows.Forms.Button();
            this.deleteBtn_category = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.categoryTbl_category)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categories";
            // 
            // categoryTbl_category
            // 
            this.categoryTbl_category.AllowUserToAddRows = false;
            this.categoryTbl_category.AllowUserToDeleteRows = false;
            this.categoryTbl_category.AllowUserToResizeColumns = false;
            this.categoryTbl_category.AllowUserToResizeRows = false;
            this.categoryTbl_category.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.categoryTbl_category.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.categoryTbl_category.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(6);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categoryTbl_category.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.categoryTbl_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryTbl_category.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.categoryTbl_category.DefaultCellStyle = dataGridViewCellStyle2;
            this.categoryTbl_category.EnableHeadersVisualStyles = false;
            this.categoryTbl_category.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.categoryTbl_category.Location = new System.Drawing.Point(29, 81);
            this.categoryTbl_category.MultiSelect = false;
            this.categoryTbl_category.Name = "categoryTbl_category";
            this.categoryTbl_category.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categoryTbl_category.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.categoryTbl_category.RowHeadersVisible = false;
            this.categoryTbl_category.Size = new System.Drawing.Size(753, 322);
            this.categoryTbl_category.TabIndex = 22;
            this.categoryTbl_category.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoryTbl_category_CellClick);
            // 
            // expenseBtn_category
            // 
            this.expenseBtn_category.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.expenseBtn_category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.expenseBtn_category.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expenseBtn_category.FlatAppearance.BorderSize = 0;
            this.expenseBtn_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expenseBtn_category.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseBtn_category.ForeColor = System.Drawing.Color.White;
            this.expenseBtn_category.Location = new System.Drawing.Point(327, 24);
            this.expenseBtn_category.Name = "expenseBtn_category";
            this.expenseBtn_category.Size = new System.Drawing.Size(76, 32);
            this.expenseBtn_category.TabIndex = 23;
            this.expenseBtn_category.Text = "Expense";
            this.expenseBtn_category.UseVisualStyleBackColor = false;
            this.expenseBtn_category.Click += new System.EventHandler(this.expenseBtn_category_Click);
            // 
            // incomeBtn_category
            // 
            this.incomeBtn_category.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.incomeBtn_category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.incomeBtn_category.Cursor = System.Windows.Forms.Cursors.Hand;
            this.incomeBtn_category.FlatAppearance.BorderSize = 0;
            this.incomeBtn_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incomeBtn_category.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeBtn_category.ForeColor = System.Drawing.Color.White;
            this.incomeBtn_category.Location = new System.Drawing.Point(408, 24);
            this.incomeBtn_category.Name = "incomeBtn_category";
            this.incomeBtn_category.Size = new System.Drawing.Size(76, 32);
            this.incomeBtn_category.TabIndex = 24;
            this.incomeBtn_category.Text = "Income";
            this.incomeBtn_category.UseVisualStyleBackColor = false;
            this.incomeBtn_category.Click += new System.EventHandler(this.incomeBtn_category_Click);
            // 
            // addBtn_category
            // 
            this.addBtn_category.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addBtn_category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addBtn_category.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn_category.FlatAppearance.BorderSize = 0;
            this.addBtn_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn_category.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn_category.ForeColor = System.Drawing.Color.White;
            this.addBtn_category.Location = new System.Drawing.Point(568, 24);
            this.addBtn_category.Name = "addBtn_category";
            this.addBtn_category.Size = new System.Drawing.Size(57, 32);
            this.addBtn_category.TabIndex = 25;
            this.addBtn_category.Text = "Add";
            this.addBtn_category.UseVisualStyleBackColor = false;
            this.addBtn_category.Click += new System.EventHandler(this.addBtn_category_Click);
            // 
            // editBtn_category
            // 
            this.editBtn_category.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editBtn_category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.editBtn_category.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editBtn_category.FlatAppearance.BorderSize = 0;
            this.editBtn_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn_category.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn_category.ForeColor = System.Drawing.Color.White;
            this.editBtn_category.Location = new System.Drawing.Point(635, 24);
            this.editBtn_category.Name = "editBtn_category";
            this.editBtn_category.Size = new System.Drawing.Size(57, 32);
            this.editBtn_category.TabIndex = 26;
            this.editBtn_category.Text = "Edit";
            this.editBtn_category.UseVisualStyleBackColor = false;
            this.editBtn_category.Click += new System.EventHandler(this.editBtn_category_Click);
            // 
            // deleteBtn_category
            // 
            this.deleteBtn_category.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtn_category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteBtn_category.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn_category.FlatAppearance.BorderSize = 0;
            this.deleteBtn_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn_category.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn_category.ForeColor = System.Drawing.Color.White;
            this.deleteBtn_category.Location = new System.Drawing.Point(702, 24);
            this.deleteBtn_category.Name = "deleteBtn_category";
            this.deleteBtn_category.Size = new System.Drawing.Size(57, 32);
            this.deleteBtn_category.TabIndex = 27;
            this.deleteBtn_category.Text = "Delete";
            this.deleteBtn_category.UseVisualStyleBackColor = false;
            this.deleteBtn_category.Click += new System.EventHandler(this.deleteBtn_category_Click);
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.Controls.Add(this.deleteBtn_category);
            this.Controls.Add(this.editBtn_category);
            this.Controls.Add(this.addBtn_category);
            this.Controls.Add(this.incomeBtn_category);
            this.Controls.Add(this.expenseBtn_category);
            this.Controls.Add(this.categoryTbl_category);
            this.Controls.Add(this.label1);
            this.Name = "Category";
            this.Size = new System.Drawing.Size(810, 440);
            this.Load += new System.EventHandler(this.Category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryTbl_category)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView categoryTbl_category;
        private System.Windows.Forms.Button expenseBtn_category;
        private System.Windows.Forms.Button incomeBtn_category;
        private System.Windows.Forms.Button addBtn_category;
        private System.Windows.Forms.Button editBtn_category;
        private System.Windows.Forms.Button deleteBtn_category;
    }
}
