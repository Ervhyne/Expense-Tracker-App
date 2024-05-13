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

        // Constructor to receive selected category name
        public CategoryFormEdit(string categoryName)
        {
            InitializeComponent();
            this.categoryName = categoryName;

            // Populate text box and combo box with selected category data
            PopulateFormData();
        }
        private void PopulateFormData()
        {
            // Fetch additional data for the selected category from the database if needed
            // For example, fetch transaction type based on the category name
            string fetchedTransactionType = ""; // Placeholder for fetched transaction type

            // Populate text box with category name
            nameTxtBox.Text = categoryName;

            // Populate combo box with transaction type data
            // Assuming fetchedTransactionType contains the transaction type
            // You can fetch it from the database or set it manually
            transactionTypeCbx.Items.Clear(); // Clear existing items
            transactionTypeCbx.Items.Add("Expense"); // Add expense option
            transactionTypeCbx.Items.Add("Income");  // Add income option

            // Set the selected transaction type
            if (!string.IsNullOrEmpty(fetchedTransactionType))
            {
                transactionTypeCbx.SelectedItem = fetchedTransactionType;
            }
            else
            {
                // Set a default value if fetchedTransactionType is empty
                transactionTypeCbx.SelectedItem = "Expense"; // For example, default to "Expense"
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
