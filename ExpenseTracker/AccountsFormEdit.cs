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
    public partial class AccountsFormEdit : Form
    {
        string connectionString = "server=127.0.0.1; user=root; database=expensetrackingdb; password=";
        private string userName;

        public AccountsFormEdit(string userName)
        {
            InitializeComponent();
            this.userName = userName;

            // Populate text box and combo box with selected category data
            PopulateFormData();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usernameTxtBox.Text))
            {
                warningLbl.ForeColor = Color.FromArgb(255, 86, 86);
                warningTimer.Start();
                return;
            }

            // Get the edited data from the text box and combo box
            string editedUserName = usernameTxtBox.Text;

            // Update the category table in the database with the edited data
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Construct the UPDATE query
                    string updateQuery = "UPDATE account SET userName = @editedUserName WHERE userName = @originalUserName";

                    // Create a MySqlCommand object
                    MySqlCommand command = new MySqlCommand(updateQuery, connection);

                    // Add parameters to the command
                    command.Parameters.AddWithValue("@editedUserName", editedUserName);
                    command.Parameters.AddWithValue("@originalUserName", userName);


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

        private void PopulateFormData()
        {
            // Populate text box with category name
            usernameTxtBox.Text = userName;       
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
