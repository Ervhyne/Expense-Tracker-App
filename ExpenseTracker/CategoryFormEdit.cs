using MySql.Data.MySqlClient;
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
    public partial class CategoryFormEdit : Form
    {
        string connectionString = "server=127.0.0.1; user=root; database=expensetrackingdb; password=";
        private string categoryName;
        private string transactionType;

        // Constructor to receive selected category name
        public CategoryFormEdit(string categoryName)
        {
            InitializeComponent();
            this.categoryName = categoryName;

            // Fetch transaction type based on the selected category name
            transactionType = GetTransactionType(categoryName);

            // Populate text box with category name
            nameTxtBox.Text = categoryName;

            // Populate combo box with transaction type data
            PopulateTransactionTypeCbx(transactionType);
        }

        private string GetTransactionType(string categoryName)
        {
            // Use CategoryData to fetch the transaction type for the selected category name
            ExpenseData expenseData = new ExpenseData();
            return expenseData.GetTransactionType(categoryName);
        }

        private void PopulateTransactionTypeCbx(string selectedTransactionType)
        {
            // Clear existing items
            transactionTypeCbx.Items.Clear();

            // Add Expense and Income options
            transactionTypeCbx.Items.Add("Expense");
            transactionTypeCbx.Items.Add("Income");

            // Set the selected transaction type
            if (!string.IsNullOrEmpty(selectedTransactionType))
            {
                transactionTypeCbx.SelectedItem = selectedTransactionType;
            }
            else
            {
                // Set default to Expense if not found
                transactionTypeCbx.SelectedItem = "Expense";
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTxtBox.Text) || transactionTypeCbx.SelectedIndex == -1)
            {
                warningLbl.ForeColor = Color.FromArgb(255, 86, 86);
                warningTimer.Start();
                return;
            }

            // Get the edited data from the text box and combo box
            string editedCategoryName = nameTxtBox.Text;
            string editedTransactionType = transactionTypeCbx.SelectedItem.ToString();

            // Update the category table in the database with the edited data
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Construct the UPDATE query
                    string updateQuery = "UPDATE category SET categoryName = @editedCategoryName, transactionType = @editedTransactionType WHERE categoryName = @originalCategoryName";

                    // Create a MySqlCommand object
                    MySqlCommand command = new MySqlCommand(updateQuery, connection);

                    // Add parameters to the command
                    command.Parameters.AddWithValue("@editedCategoryName", editedCategoryName);
                    command.Parameters.AddWithValue("@editedTransactionType", editedTransactionType);
                    command.Parameters.AddWithValue("@originalCategoryName", categoryName);

                    // Execute the UPDATE query
                    int rowsAffected = command.ExecuteNonQuery();

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            // Close the form and indicate successful edit/update
            DialogResult = DialogResult.OK;
            Close();
        }

        private void warningTimer_Tick(object sender, EventArgs e)
        {
            warningLbl.ForeColor = Color.FromArgb(52, 52, 52);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            // Close the form without saving changes
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
