using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ExpenseTracker
{
    public partial class Accounts : UserControl
    {

        string connectionString = "server=127.0.0.1; user=root; database=expensetrackingdb; password=";
        public event EventHandler AccountsUpdated;

        public Accounts()
        {
            InitializeComponent();
            LoadData(); // Call LoadData on initialization
        }

        private void Accounts_Load(object sender, EventArgs e)
        {
            userTbl_account.ClearSelection();
        }

        private void LoadData()
        {
            AccountData accountData = new AccountData(); // Create an instance of AccountData
            DataTable accountTable = accountData.GetAccountData(); // Retrieve account data
            userTbl_account.DataSource = accountTable; // Set the DataGridView's DataSource

            // Clear the selection in the DataGridView
            userTbl_account.ClearSelection();
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
            // Clear the selection in the DataGridView
            userTbl_account.ClearSelection();
            LoadData();
            // Fire the event after adding an account
            OnAccountsUpdated();
           
        }

        private void AccountsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            accountsForm = null; // Reset the reference (optional)
        }

        private string getUserName = "";
        private void userTbl_account_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = userTbl_account.Rows[e.RowIndex];
                getUserName = row.Cells["userName"].Value.ToString();
            }
        }

        private void deleteBtn_account_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(getUserName))
            {
                MessageBox.Show("Please select a category to delete.");
                return;
            }

            // Show a confirmation message box
            DialogResult result = MessageBox.Show($"Are you sure you want to delete the '{getUserName}' account and its records?",
                                                  "Confirm Deletion",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            // If the user clicks 'No', cancel the delete operation
            if (result == DialogResult.No)
            {
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Delete the user account
                string deleteAccount = "DELETE FROM account WHERE userName = @userName";
                using (MySqlCommand command = new MySqlCommand(deleteAccount, connection))
                {
                    command.Parameters.AddWithValue("@userName", getUserName);
                    command.ExecuteNonQuery();
                }

                // Delete the transactions related to the deleted user account
                string deleteTransactions = "DELETE FROM transactions WHERE user = @user";
                using (MySqlCommand command = new MySqlCommand(deleteTransactions, connection))
                {
                    command.Parameters.AddWithValue("@user", getUserName);
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }

            LoadData();
            // Fire the event after deleting an account
            OnAccountsUpdated();
            // Clear the selection in the DataGridView
            userTbl_account.ClearSelection();
        }

        private void OnAccountsUpdated()
        {
            AccountsUpdated?.Invoke(this, EventArgs.Empty);
        }

        private AccountsFormEdit accountsFormEdit;
        private void editBtn_account_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(getUserName))
            {
                return;
            }

            // Open the edit form and pass the selected category name
            using (AccountsFormEdit editForm = new AccountsFormEdit(getUserName))
            {
                editForm.StartPosition = FormStartPosition.CenterScreen; // Center the modal form
                editForm.ShowInTaskbar = false;

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    // Handle any post-edit actions if needed
                    // For example, refresh the data grid view
                    LoadData();
                }
            }
            // Clear the selection in the DataGridView
            userTbl_account.ClearSelection();
        }
    }
}
