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
    public partial class AccountsForm : Form
    {
        string connectionString = "server=127.0.0.1; user=root; database=expensetrackingdb; password=";

        public AccountsForm()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(usernameTxtBox.Text))
            {
                warningLbl.ForeColor = Color.FromArgb(255, 86, 86);
                warningTimer.Start();
                return;
            }
            // Connection string (replace with your actual connection details)

            // Get values from UI elements
            string account_name = usernameTxtBox.Text;

            // Validate input (optional, add checks for empty or invalid values)

            // Using MySqlConnector (assuming you've added the reference)
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Write SQL insert statement
                string sql = "INSERT INTO account (UserName) VALUES (@userName)";

                // Create a MySqlCommand object
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    // Add parameters to prevent SQL injection attacks
                    command.Parameters.AddWithValue("@userName", account_name);

                    try
                    {
                        // Open the connection
                        connection.Open();

                        // Execute the query and handle success/failure using return value
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Transaction saved successfully, handle success logic here (e.g., clear form, update UI)
                            usernameTxtBox.Text = "";

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

        private void warningTimer_Tick(object sender, EventArgs e)
        {
            warningLbl.ForeColor = Color.FromArgb(52, 52, 52);
        }
    }
}
