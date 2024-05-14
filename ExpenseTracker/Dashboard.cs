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
    public partial class Dashboard : UserControl
    {

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private IncomeExpenseForm incomeExpenseForm;
        public static int parentX, parentY;
        private void incomeBtn_Click(object sender, EventArgs e)
        {
            OpenIncomeExpenseForm("Income");
        }

        private void expenseBtn_Click(object sender, EventArgs e)
        {
            OpenIncomeExpenseForm("Expense");
        }

        private void OpenIncomeExpenseForm(string buttonType)
        {
            if (incomeExpenseForm == null || incomeExpenseForm.IsDisposed)
            {
                incomeExpenseForm = new IncomeExpenseForm(buttonType);
                incomeExpenseForm.FormClosed += IncomeExpenseForm_FormClosed;
            }

            incomeExpenseForm.StartPosition = FormStartPosition.CenterScreen;
            incomeExpenseForm.ShowDialog();
        }


        private void IncomeExpenseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            incomeExpenseForm = null; // Reset the reference (optional)
        }
    }
}
