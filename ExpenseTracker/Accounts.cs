using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class Accounts : UserControl
    {

        public Accounts()
        {
            InitializeComponent();
        }

        

        private AccountsForm accountsForm;
        private void addBtn_account_Click(object sender, EventArgs e)
        {
            if (accountsForm == null)
            {
                accountsForm = new AccountsForm();
                accountsForm.FormClosed += AccountsForm_FormClosed; // Subscribe to FormClosed event
            }

            accountsForm.StartPosition = FormStartPosition.CenterScreen; // Center the modal form
            accountsForm.ShowDialog(); // Show the form as a modal dialog
        }

        private void AccountsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            accountsForm = null; // Reset the reference (optional)
        }
    }
}
