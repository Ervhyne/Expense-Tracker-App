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
        private void incomeBtn_Click(object sender, EventArgs e)
        {
            if (incomeExpenseForm == null) // Check if already created
            {
                incomeExpenseForm = new IncomeExpenseForm();
                incomeExpenseForm.FormClosed += IncomeExpenseForm_FormClosed; // Subscribe to FormClosed event
            }
            incomeExpenseForm.Show(); // Show the form (modal by default in WPF)
        }

        private void expenseBtn_Click(object sender, EventArgs e)
        {
            if (incomeExpenseForm == null) // Check if already created
            {
                incomeExpenseForm = new IncomeExpenseForm();
                incomeExpenseForm.FormClosed += IncomeExpenseForm_FormClosed; // Subscribe to FormClosed event
            }
            incomeExpenseForm.Show(); // Show the form (modal by default in WPF)
        }

        private void IncomeExpenseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            incomeExpenseForm = null; // Reset the reference (optional)
        }
    }
}
