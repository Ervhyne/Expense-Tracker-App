using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Media;
using System.Windows;
using GemBox.Document.Drawing;
using MySql.Data.MySqlClient;
using ZedGraph;

namespace ExpenseTracker
{
    public partial class Dashboard : UserControl
    {
        // Connection string 
        string connectionString = "server=127.0.0.1; user=root; database=expensetrackingdb; password=";
        public Dashboard()
        {
            InitializeComponent();
            PopulateUserComboBox(); // Populate the combo box first
            userCbx.SelectedIndexChanged += UserCbx_SelectedIndexChanged; // Register the event handler

            // Update the expense label initially
            if (userCbx.Items.Count > 0)
            {
                string selectedUser = userCbx.SelectedItem.ToString();
                ExpenseTodayIncome(selectedUser);
                IncomeTodayIncome(selectedUser);
            }

        }

        private void UserCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData(); // Reload data when a different user is selected
            
            // Get the selected user
            string selectedUser = userCbx.SelectedItem.ToString();

            // Update the expense label with the selected user's expenses
            ExpenseTodayIncome(selectedUser);
            IncomeTodayIncome(selectedUser);

            // Update the balance label
            UpdateBalanceLabel(selectedUser);
        }

        private void LoadData()
        {
            if (userCbx.Items.Count > 0 && userCbx.SelectedItem != null)
            {
                string selectedUser = userCbx.SelectedItem.ToString();
                DashboardData dashboardData = new DashboardData(connectionString); // Create an instance of DashboardData
                DataTable dashboardTable = dashboardData.GetTransactionData(selectedUser); // Retrieve filtered transaction data
                transactionTbl.DataSource = dashboardTable; // Set the DataGridView's DataSource
                ExpenseTodayIncome(selectedUser);
                IncomeTodayIncome(selectedUser);

                // Update the balance label
                UpdateBalanceLabel(selectedUser);
            }
            else
            {
                // Handle the case where no user is selected
                System.Windows.Forms.MessageBox.Show("Please select a user.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private IncomeExpenseForm incomeExpenseForm;
        public static int parentX, parentY;
        private void incomeBtn_Click(object sender, EventArgs e)
        {
            OpenIncomeExpenseForm("Income");
        }

        private void expenseBtn_Click(object sender, EventArgs e)
        {
            OpenIncomeExpenseForm("Expense");
        }

        private void OpenIncomeExpenseForm(string buttonType)
        {
            if (incomeExpenseForm == null || incomeExpenseForm.IsDisposed)
            {
                incomeExpenseForm = new IncomeExpenseForm(buttonType);
                incomeExpenseForm.FormClosed += IncomeExpenseForm_FormClosed;
            }

            incomeExpenseForm.StartPosition = FormStartPosition.CenterScreen;
            incomeExpenseForm.ShowDialog();
            LoadData();

        }


        private void IncomeExpenseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            incomeExpenseForm = null; // Reset the reference (optional)
        }

        private void PopulateUserComboBox()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string selectData = "SELECT userName FROM account ORDER BY userName";

                    // Prepare the command
                    MySqlCommand command = new MySqlCommand(selectData, connection);

                    // Execute the query and retrieve the data
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // Clear existing items
                        userCbx.Items.Clear();

                        // Loop through the result set and add items to the combo-box
                        while (reader.Read())
                        {
                            string userName = reader["userName"].ToString();
                            userCbx.Items.Add(userName);
                        }
                    }

                    // Auto-select the first item if the combo-box is not empty
                    if (userCbx.Items.Count > 0)
                    {
                        userCbx.SelectedIndex = 0; // Select the first item
                    }
                }
                catch (MySqlException ex)
                {
                    // Handle exceptions
                    Console.WriteLine("An error occurred: " + ex.Message);
                    // You may want to display an error message to the user here
                }
            }
        }

        public void ExpenseTodayIncome(string selectedUser)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Ensure the query uses the correct format for date comparison
                    string query = "SELECT SUM(amount) FROM transactions WHERE user = @selectedUser AND transactionType = 'Expense' AND DATE(date) = @selectedDate";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Convert today's date to a string in the format 'yyyy-MM-dd'
                        string today = DateTime.Today.ToString("yyyy-MM-dd");

                        // Add parameters to the command
                        command.Parameters.AddWithValue("@selectedUser", selectedUser);
                        command.Parameters.AddWithValue("@selectedDate", today);

                        // Use MessageBox for debugging
                        // System.Windows.Forms.MessageBox.Show($"Executing query: {query}\nSelected User: {selectedUser}\nSelected Date: {today}", "Debug Info");

                        // Execute the query and get the result
                        object result = command.ExecuteScalar();

                        // Check if the result is not null or DBNull
                        if (result != null && result != DBNull.Value)
                        {
                            decimal todayCost = Convert.ToDecimal(result);
                            expenseMoneyLbl.Text = todayCost.ToString("C");
                            // System.Windows.Forms.MessageBox.Show($"Today's Expense: {todayCost.ToString("C")}", "Debug Info");
                        }
                        else
                        {
                            expenseMoneyLbl.Text = "No Expenses";
                            // System.Windows.Forms.MessageBox.Show("No Expenses found for today.", "Debug Info");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Show any exceptions in a MessageBox
                     System.Windows.Forms.MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void IncomeTodayIncome(string selectedUser)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Ensure the query uses the correct format for date comparison
                    string query = "SELECT SUM(amount) FROM transactions WHERE user = @selectedUser AND transactionType = 'Income' AND DATE(date) = @selectedDate";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Convert today's date to a string in the format 'yyyy-MM-dd'
                        string today = DateTime.Today.ToString("yyyy-MM-dd");

                        // Add parameters to the command
                        command.Parameters.AddWithValue("@selectedUser", selectedUser);
                        command.Parameters.AddWithValue("@selectedDate", today);

                        // Execute the query and get the result
                        object result = command.ExecuteScalar();

                        // Check if the result is not null or DBNull
                        if (result != null && result != DBNull.Value)
                        {
                            decimal todayIncome = Convert.ToDecimal(result);
                            incomeMoneyLbl.Text = todayIncome.ToString("C");
                            // System.Windows.Forms.MessageBox.Show($"Today's Income: {todayIncome.ToString("C")}", "Debug Info");
                        }
                        else
                        {
                            incomeMoneyLbl.Text = "No Income";
                            // System.Windows.Forms.MessageBox.Show("No Income found for today.", "Debug Info");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Show any exceptions in a MessageBox
                    // System.Windows.Forms.MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateBalanceLabel(string selectedUser)
        {
            // Get the total income and total expense for the selected user
            decimal totalIncome = GetTotalIncome(selectedUser);
            decimal totalExpense = GetTotalExpense(selectedUser);

            // Calculate the balance
            decimal balance = totalIncome - totalExpense;

            // Update the balance label
            balanceLbl.Text = balance.ToString("C");
        }

        private decimal GetTotalIncome(string selectedUser)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Query to retrieve the total income for the selected user on the current date
                string query = "SELECT SUM(amount) FROM transactions WHERE user = @selectedUser AND transactionType = 'Income' AND DATE(date) = CURDATE()";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@selectedUser", selectedUser);
                    object result = command.ExecuteScalar();

                    // Check if the result is not null or DBNull
                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToDecimal(result);
                    }
                    else
                    {
                        return 0; // No income found
                    }
                }
            }
        }

        private decimal GetTotalExpense(string selectedUser)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Query to retrieve the total expense for the selected user on the current date
                string query = "SELECT SUM(amount) FROM transactions WHERE user = @selectedUser AND transactionType = 'Expense' AND DATE(date) = CURDATE()";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@selectedUser", selectedUser);
                    object result = command.ExecuteScalar();

                    // Check if the result is not null or DBNull
                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToDecimal(result);
                    }
                    else
                    {
                        return 0; // No expense found
                    }
                }
            }
        }
    }
}
