using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Media;
using System.Windows;
using GemBox.Document.Drawing;

namespace ExpenseTracker
{
    public partial class MaterialForm : MaterialSkin.Controls.MaterialForm
    {
        MaterialSkinManager materialSkinManager;
        public MaterialForm()
        { 
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey900, Accent.LightBlue700, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private IncomeExpenseForm incomeExpenseForm;
        public static int parentX, parentY;
        private void incomeBtn_Click(object sender, EventArgs e)
        {
            Form modalBackground = new Form();
            using (IncomeExpenseForm modal = new IncomeExpenseForm())
            {
                modalBackground.StartPosition = FormStartPosition.Manual;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                modalBackground.Opacity = .50d;
                modalBackground.BackColor = System.Drawing.Color.Black;
                modalBackground.Size = this.Size;
                modalBackground.Location = this.Location;
                modalBackground.ShowInTaskbar = true;
                modalBackground.Show();
                modal.Owner = modalBackground;

                parentX = this.Location.X;
                parentY = this.Location.Y;

                modal.ShowDialog();
                modalBackground.Dispose();
            }
        }

        private void expenseBtn_Click(object sender, EventArgs e)
        {
            Form modalBackground = new Form();
            using (IncomeExpenseForm modal = new IncomeExpenseForm())
            {
                modalBackground.StartPosition = FormStartPosition.Manual;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                modalBackground.Opacity = .50d;
                modalBackground.BackColor = System.Drawing.Color.Black;
                modalBackground.Size = this.Size;
                modalBackground.Location = this.Location;
                modalBackground.ShowInTaskbar = true;
                modalBackground.Show();
                modal.Owner = modalBackground;

                parentX = this.Location.X;
                parentY = this.Location.Y;

                modal.ShowDialog();
                modalBackground.Dispose();
            }
        }

        private void IncomeExpenseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            incomeExpenseForm = null; // Reset the reference (optional)
        }
       
    }
}
