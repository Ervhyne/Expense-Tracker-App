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

        // Optional: Declare a custom event for successful save notification
        public event EventHandler CategorySaved;
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTxtBox.Text) || transactionTypeCbx.SelectedIndex == -1)
            {
                ShowAlert("Fill in all the blanks.", "Input Error", Color.FromArgb(255, 86, 86));
                return;
            }

            // Connection string (replace with your actual connection details)
            string connectionString = "server=127.0.0.1; user=root; database=expensetrackingdb; password=";

            // Get values from UI elements
            string category_name = nameTxtBox.Text;
            string transactionType = transactionTypeCbx.SelectedItem.ToString();

            // Using MySqlConnector (assuming you've added the reference)
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Write SQL select statement to check if the category already exists for the specified transaction type
                string checkCategorySql = "SELECT COUNT(*) FROM category WHERE CategoryName = @categoryName AND TransactionType = @transactionType";

                // Create a MySqlCommand object to check if the category exists
                using (MySqlCommand checkCategoryCommand = new MySqlCommand(checkCategorySql, connection))
                {
                    // Add parameters to prevent SQL injection attacks
                    checkCategoryCommand.Parameters.AddWithValue("@categoryName", category_name);
                    checkCategoryCommand.Parameters.AddWithValue("@transactionType", transactionType);

                    try
                    {
                        // Open the connection
                        connection.Open();

                        // Execute the query to check if the category already exists for the specified transaction type
                        int categoryCount = Convert.ToInt32(checkCategoryCommand.ExecuteScalar());

                        if (categoryCount > 0)
                        {
                            // Category already exists for the specified transaction type, show alert message
                            ShowAlert("Category already exists.", "Input Error", Color.FromArgb(255, 86, 86));
                            return;
                        }
                    }
                    catch (MySqlException ex)
                    {
                        // Handle potential MySQL exceptions
                        Console.WriteLine("An error occurred: " + ex.Message);  // Replace with your desired error handling
                    }
                }

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
                        // Execute the query and handle success/failure using return value
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Transaction saved successfully, handle success logic here (e.g., clear form, update UI)
                            nameTxtBox.Text = "";
                            transactionTypeCbx.SelectedIndex = -1; // Select the first item (optional)

                            // Trigger CategorySaved event (assuming CategoryForm has a reference to the Category control)
                            CategorySaved?.Invoke(this, EventArgs.Empty);  // Assuming an event is declared in Category

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

        private void ShowAlert(string message, string caption, Color color)
        {
            warningLbl.Text = message;
            warningLbl.ForeColor = color;
            warningTimer.Start();
            warningTimer.Tick += (sender, e) =>
            {
                warningLbl.ForeColor = Color.FromArgb(52, 52, 52); // Reset color
                warningTimer.Stop();
            };
        }
    }
}
