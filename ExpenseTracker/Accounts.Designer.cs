namespace ExpenseTracker
{
    partial class Accounts
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
            this.deleteBtn_account = new System.Windows.Forms.Button();
            this.editBtn_account = new System.Windows.Forms.Button();
            this.addBtn_account = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.userTbl_account = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.userTbl_account)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteBtn_account
            // 
            this.deleteBtn_account.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtn_account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteBtn_account.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn_account.FlatAppearance.BorderSize = 0;
            this.deleteBtn_account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn_account.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn_account.ForeColor = System.Drawing.Color.White;
            this.deleteBtn_account.Location = new System.Drawing.Point(702, 24);
            this.deleteBtn_account.Name = "deleteBtn_account";
            this.deleteBtn_account.Size = new System.Drawing.Size(57, 32);
            this.deleteBtn_account.TabIndex = 31;
            this.deleteBtn_account.Text = "Delete";
            this.deleteBtn_account.UseVisualStyleBackColor = false;
            this.deleteBtn_account.Click += new System.EventHandler(this.deleteBtn_account_Click);
            // 
            // editBtn_account
            // 
            this.editBtn_account.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editBtn_account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.editBtn_account.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editBtn_account.FlatAppearance.BorderSize = 0;
            this.editBtn_account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn_account.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn_account.ForeColor = System.Drawing.Color.White;
            this.editBtn_account.Location = new System.Drawing.Point(635, 24);
            this.editBtn_account.Name = "editBtn_account";
            this.editBtn_account.Size = new System.Drawing.Size(57, 32);
            this.editBtn_account.TabIndex = 30;
            this.editBtn_account.Text = "Edit";
            this.editBtn_account.UseVisualStyleBackColor = false;
            this.editBtn_account.Click += new System.EventHandler(this.editBtn_account_Click);
            // 
            // addBtn_account
            // 
            this.addBtn_account.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addBtn_account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addBtn_account.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn_account.FlatAppearance.BorderSize = 0;
            this.addBtn_account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn_account.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn_account.ForeColor = System.Drawing.Color.White;
            this.addBtn_account.Location = new System.Drawing.Point(568, 24);
            this.addBtn_account.Name = "addBtn_account";
            this.addBtn_account.Size = new System.Drawing.Size(57, 32);
            this.addBtn_account.TabIndex = 29;
            this.addBtn_account.Text = "Add";
            this.addBtn_account.UseVisualStyleBackColor = false;
            this.addBtn_account.Click += new System.EventHandler(this.addBtn_account_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 44);
            this.label1.TabIndex = 28;
            this.label1.Text = "Accounts";
            // 
            // userTbl_account
            // 
            this.userTbl_account.AllowUserToAddRows = false;
            this.userTbl_account.AllowUserToDeleteRows = false;
            this.userTbl_account.AllowUserToResizeColumns = false;
            this.userTbl_account.AllowUserToResizeRows = false;
            this.userTbl_account.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userTbl_account.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userTbl_account.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.userTbl_account.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(6);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userTbl_account.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.userTbl_account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userTbl_account.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userTbl_account.DefaultCellStyle = dataGridViewCellStyle2;
            this.userTbl_account.EnableHeadersVisualStyles = false;
            this.userTbl_account.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.userTbl_account.Location = new System.Drawing.Point(29, 81);
            this.userTbl_account.MultiSelect = false;
            this.userTbl_account.Name = "userTbl_account";
            this.userTbl_account.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userTbl_account.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.userTbl_account.RowHeadersVisible = false;
            this.userTbl_account.Size = new System.Drawing.Size(753, 322);
            this.userTbl_account.TabIndex = 32;
            this.userTbl_account.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userTbl_account_CellClick);
            // 
            // Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.Controls.Add(this.userTbl_account);
            this.Controls.Add(this.deleteBtn_account);
            this.Controls.Add(this.editBtn_account);
            this.Controls.Add(this.addBtn_account);
            this.Controls.Add(this.label1);
            this.Name = "Accounts";
            this.Size = new System.Drawing.Size(810, 440);
            this.Load += new System.EventHandler(this.Accounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userTbl_account)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteBtn_account;
        private System.Windows.Forms.Button editBtn_account;
        private System.Windows.Forms.Button addBtn_account;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView userTbl_account;
    }
}
