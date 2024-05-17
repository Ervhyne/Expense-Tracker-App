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

            string account_name = usernameTxtBox.Text;

            // Using MySqlConnector (assuming you've added the reference)
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Check if the username already exists
                    string checkSql = "SELECT COUNT(*) FROM account WHERE UserName = @userName";
                    using (MySqlCommand checkCommand = new MySqlCommand(checkSql, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@userName", account_name);
                        int existingCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                        if (existingCount > 0)
                        {
                            // Username already exists, show error message
                            ShowAlert("Username already exists.", "Duplicate Username", Color.FromArgb(255, 86, 86));
                            return;
                        }
                    }

                    // If username doesn't exist, proceed with insertion
                    string insertSql = "INSERT INTO account (UserName) VALUES (@userName)";
                    using (MySqlCommand command = new MySqlCommand(insertSql, connection))
                    {
                        command.Parameters.AddWithValue("@userName", account_name);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Transaction saved successfully, handle success logic here
                            usernameTxtBox.Text = "";
                            Close();
                        }
                        else
                        {
                            // Error saving transaction
                            Console.WriteLine("Error saving transaction. Please check logs for details.");
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    // Handle potential MySQL exceptions
                    Console.WriteLine("An error occurred: " + ex.Message);
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
                warningLbl.ForeColor = Color.FromArgb(57, 44, 71); // Reset color
                warningTimer.Stop();
            };
        }

        public void ClickSaveButton()
        {
            saveBtn.PerformClick();
        }
    }
}
