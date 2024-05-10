using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ExpenseTracker
{
    public partial class IncomeExpenseForm : Form
    {

        public IncomeExpenseForm()
        {
            InitializeComponent();
        }

        private Button clickedButton; // Store reference to clicked button
        private void expenseBtn_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(sender);

        }

        private void incomeBtn_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(sender);
        }

        // Helper function to handle color change and reset
        private void ChangeButtonColor(object sender)
        {
            if (clickedButton != null)
            {
                clickedButton.BackColor = Color.Transparent; // Revert previous button
            }
            clickedButton = (Button)sender; // Store clicked button reference
            clickedButton.BackColor = ColorTranslator.FromHtml("#381D25"); // Set clicked color
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void IncomeExpenseForm_Load(object sender, EventArgs e)
        {

        }
    }
}

