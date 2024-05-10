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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Connection string (replace with your actual connection details)
            string connectionString = "server=127.0.0.1; user=root; database=expensetrackingdb; password=";

            // Get values from UI elements
            string category_name = nameTxtBox.Text;
            string transactionType = transactionTypeCbx.SelectedItem.ToString();

            // Validate input (optional, add checks for empty or invalid values)

            // Using MySqlConnector (assuming you've added the reference)
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Write SQL insert statement
                string sql = "INSERT INTO category (CategoryName, TransactionType) VALUES (@categoryName, @transactionType)";

                // Create a MySqlCommand object
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    // Add parameters to prevent SQL injection attacks
                    command.Parameters.AddWithValue("@categoryName", category_name);
                    command.Parameters.AddWithValue("@transactionType", transactionType);

                    try
                    {
                        // Open the connection
                        connection.Open();

                        // Execute the query and handle success/failure using return value
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Transaction saved successfully, handle success logic here (e.g., clear form, update UI)
                            nameTxtBox.Text = "";
                            transactionTypeCbx.SelectedIndex = -1; // Select the first item (optional)

                            // Close the form after successful save
                            Close();
                        }
                        else
                        {
                            // Error saving transaction, handle error logic here (e.g., log the error, display user-friendly message)
                            Console.WriteLine("Error saving transaction. Please check logs for details.");  // Replace with your desired error handling
                        }
                    }
                    catch (MySqlException ex)
                    {
                        // Handle potential MySQL exceptions
                        Console.WriteLine("An error occurred: " + ex.Message);  // Replace with your desired error handling
                    }
                }

            }
        }
    }
}
