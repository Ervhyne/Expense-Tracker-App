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
            if (incomeExpenseForm == null)
            {
                incomeExpenseForm = new IncomeExpenseForm();
                incomeExpenseForm.FormClosed += IncomeExpenseForm_FormClosed; // Subscribe to FormClosed event
            }

            incomeExpenseForm.StartPosition = FormStartPosition.CenterScreen; // Center the modal form
            incomeExpenseForm.ShowDialog(); // Show the form as a modal dialog
        }

        private void expenseBtn_Click(object sender, EventArgs e)
        {
            if (incomeExpenseForm == null)
            {
                incomeExpenseForm = new IncomeExpenseForm();
                incomeExpenseForm.FormClosed += IncomeExpenseForm_FormClosed; // Subscribe to FormClosed event
            }

            incomeExpenseForm.StartPosition = FormStartPosition.CenterScreen; // Center the modal form
            incomeExpenseForm.ShowDialog(); // Show the form as a modal dialog
        }

        private void IncomeExpenseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            incomeExpenseForm = null; // Reset the reference (optional)
        }
    }
}
