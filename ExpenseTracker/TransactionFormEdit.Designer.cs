namespace ExpenseTracker
{
    partial class TransactionFormEdit
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.amountTxtBox = new System.Windows.Forms.TextBox();
            this.noteTxtBox = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.warningTimer = new System.Windows.Forms.Timer(this.components);
            this.warningLbl = new System.Windows.Forms.Label();
            this.categoryCbx = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(110)))), ((int)(((byte)(161)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 30);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Edit Transaction";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(41, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Notes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Amount";
            // 
            // amountTxtBox
            // 
            this.amountTxtBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountTxtBox.Location = new System.Drawing.Point(107, 83);
            this.amountTxtBox.Name = "amountTxtBox";
            this.amountTxtBox.Size = new System.Drawing.Size(168, 26);
            this.amountTxtBox.TabIndex = 10;
            this.amountTxtBox.Enter += new System.EventHandler(this.amountTxtBox_Enter);
            this.amountTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amountTxtBox_KeyPress);
            this.amountTxtBox.Leave += new System.EventHandler(this.amountTxtBox_Leave);
            // 
            // noteTxtBox
            // 
            this.noteTxtBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteTxtBox.Location = new System.Drawing.Point(107, 119);
            this.noteTxtBox.Multiline = true;
            this.noteTxtBox.Name = "noteTxtBox";
            this.noteTxtBox.Size = new System.Drawing.Size(168, 47);
            this.noteTxtBox.TabIndex = 11;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(179)))), ((int)(((byte)(131)))));
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(160, 201);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(62, 23);
            this.saveBtn.TabIndex = 13;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(104)))), ((int)(((byte)(85)))));
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(67, 201);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(62, 23);
            this.cancelBtn.TabIndex = 12;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // warningTimer
            // 
            this.warningTimer.Interval = 3000;
            this.warningTimer.Tick += new System.EventHandler(this.warningTimer_Tick);
            // 
            // warningLbl
            // 
            this.warningLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.warningLbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.warningLbl.Location = new System.Drawing.Point(12, 179);
            this.warningLbl.Name = "warningLbl";
            this.warningLbl.Size = new System.Drawing.Size(266, 16);
            this.warningLbl.TabIndex = 14;
            this.warningLbl.Text = "Fill in all the blanks";
            this.warningLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // categoryCbx
            // 
            this.categoryCbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryCbx.BackColor = System.Drawing.Color.Silver;
            this.categoryCbx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoryCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryCbx.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.categoryCbx.Font = new System.Drawing.Font("Arial", 12F);
            this.categoryCbx.ForeColor = System.Drawing.Color.Black;
            this.categoryCbx.FormattingEnabled = true;
            this.categoryCbx.ItemHeight = 18;
            this.categoryCbx.Location = new System.Drawing.Point(107, 48);
            this.categoryCbx.Name = "categoryCbx";
            this.categoryCbx.Size = new System.Drawing.Size(168, 26);
            this.categoryCbx.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "Category";
            // 
            // TransactionFormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(290, 237);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.categoryCbx);
            this.Controls.Add(this.warningLbl);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.noteTxtBox);
            this.Controls.Add(this.amountTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransactionFormEdit";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransactionForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox amountTxtBox;
        private System.Windows.Forms.TextBox noteTxtBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Timer warningTimer;
        private System.Windows.Forms.Label warningLbl;
        private System.Windows.Forms.ComboBox categoryCbx;
        private System.Windows.Forms.Label label4;
    }
}