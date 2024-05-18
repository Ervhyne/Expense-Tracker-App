using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ExpenseTracker
{
    public partial class Reports : UserControl
    {
        // Connection string 
        string connectionString = "server=127.0.0.1; user=root; database=expensetrackingdb; password=";

        private DateTime currentYear;
        private ToolTip toolTip;

        public Reports()
        {
            InitializeComponent();
            currentYear = DateTime.Now;
            UpdateDateLabel();
            PopulateUserComboBox();
            UpdateIncomeLabels();
            UpdateExpenseLabels();

            // Initialize the ToolTip if it's not added through the designer
            toolTip = new ToolTip();
        }

        private void UpdateDateLabel()
        {
            dateLbl.Text = currentYear.ToString("yyyy");
        }

        private void dateLeftBtn_Click(object sender, EventArgs e)
        {
            currentYear = currentYear.AddYears(-1);
            UpdateDateLabel();
            UpdateIncomeLabels();
            UpdateExpenseLabels();
        }

        private void dateRightBtn_Click(object sender, EventArgs e)
        {
            currentYear = currentYear.AddYears(1);
            UpdateDateLabel();
            UpdateIncomeLabels();
            UpdateExpenseLabels();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            PopulateUserComboBox();
        }

        private void refreshBtn_MouseHover(object sender, EventArgs e)
        {
            // Show the ToolTip with the message "refresh user combo-box"
            toolTip.Show("Refresh User Combo-box and Datas", refreshBtn, 0, -20, 2000); // The message will appear above the button for 2 seconds
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

        private decimal GetIncomeForToday(string user)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT SUM(amount) FROM transactions WHERE user = @user AND transactionType = 'Income' AND DATE(date) = CURDATE() AND YEAR(date) = @year";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@user", user);
                command.Parameters.AddWithValue("@year", currentYear.Year);

                object result = command.ExecuteScalar();
                return result != DBNull.Value ? Convert.ToDecimal(result) : 0;
            }
        }

        private decimal GetIncomeForYesterday(string user)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT SUM(amount) FROM transactions WHERE user = @user AND transactionType = 'Income' AND DATE(date) = CURDATE() - INTERVAL 1 DAY AND YEAR(date) = @year";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@user", user);
                command.Parameters.AddWithValue("@year", currentYear.Year);

                object result = command.ExecuteScalar();
                return result != DBNull.Value ? Convert.ToDecimal(result) : 0;
            }
        }

        private decimal GetIncomeForThisMonth(string user)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT SUM(amount) FROM transactions WHERE user = @user AND transactionType = 'Income' AND MONTH(date) = MONTH(CURDATE()) AND YEAR(date) = @year";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@user", user);
                command.Parameters.AddWithValue("@year", currentYear.Year);

                object result = command.ExecuteScalar();
                return result != DBNull.Value ? Convert.ToDecimal(result) : 0;
            }
        }

        private decimal GetIncomeForThisYear(string user)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT SUM(amount) FROM transactions WHERE user = @user AND transactionType = 'Income' AND YEAR(date) = @year";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@user", user);
                command.Parameters.AddWithValue("@year", currentYear.Year);

                object result = command.ExecuteScalar();
                return result != DBNull.Value ? Convert.ToDecimal(result) : 0;
            }
        }

        private decimal GetTotalIncome(string user)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT SUM(amount) FROM transactions WHERE user = @user AND transactionType = 'Income'";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@user", user);
                command.Parameters.AddWithValue("@year", currentYear.Year);

                object result = command.ExecuteScalar();
                return result != DBNull.Value ? Convert.ToDecimal(result) : 0;
            }
        }

        private void UpdateIncomeLabels()
        {
            string selectedUser = userCbx.SelectedItem.ToString();

            incomeMoneyLbl_today.Text = GetIncomeForToday(selectedUser).ToString("C");
            incomeMoneyLbl_yesterday.Text = GetIncomeForYesterday(selectedUser).ToString("C");
            incomeMoneyLbl_monthly.Text = GetIncomeForThisMonth(selectedUser).ToString("C");
            incomeMoneyLbl_yearly.Text = GetIncomeForThisYear(selectedUser).ToString("C");
            incomeMoneyLbl_total.Text = GetTotalIncome(selectedUser).ToString("C");
        }

        private decimal GetExpenseForToday(string user)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT SUM(amount) FROM transactions WHERE user = @user AND transactionType = 'Expense' AND DATE(date) = CURDATE() AND YEAR(date) = @year";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@user", user);
                command.Parameters.AddWithValue("@year", currentYear.Year);

                object result = command.ExecuteScalar();
                return result != DBNull.Value ? Convert.ToDecimal(result) : 0;
            }
        }

        private decimal GetExpenseForYesterday(string user)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT SUM(amount) FROM transactions WHERE user = @user AND transactionType = 'Expense' AND DATE(date) = CURDATE() - INTERVAL 1 DAY AND YEAR(date) = @year";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@user", user);
                command.Parameters.AddWithValue("@year", currentYear.Year);

                object result = command.ExecuteScalar();
                return result != DBNull.Value ? Convert.ToDecimal(result) : 0;
            }
        }

        private decimal GetExpenseForThisMonth(string user)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT SUM(amount) FROM transactions WHERE user = @user AND transactionType = 'Expense' AND MONTH(date) = MONTH(CURDATE()) AND YEAR(date) = @year";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@user", user);
                command.Parameters.AddWithValue("@year", currentYear.Year);

                object result = command.ExecuteScalar();
                return result != DBNull.Value ? Convert.ToDecimal(result) : 0;
            }
        }

        private decimal GetExpenseForThisYear(string user)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT SUM(amount) FROM transactions WHERE user = @user AND transactionType = 'Expense' AND YEAR(date) = @year";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@user", user);
                command.Parameters.AddWithValue("@year", currentYear.Year);

                object result = command.ExecuteScalar();
                return result != DBNull.Value ? Convert.ToDecimal(result) : 0;
            }
        }   

        private decimal GetTotalExpense(string user)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT SUM(amount) FROM transactions WHERE user = @user AND transactionType = 'Expense'";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@user", user);

                object result = command.ExecuteScalar();
                return result != DBNull.Value ? Convert.ToDecimal(result) : 0;
            }
        }

        private void UpdateExpenseLabels()
        {
            string selectedUser = userCbx.SelectedItem.ToString();

            expenseMoneyLbl_today.Text = GetExpenseForToday(selectedUser).ToString("C");
            expenseMoneyLbl_yesterday.Text = GetExpenseForYesterday(selectedUser).ToString("C");
            expenseMoneyLbl_monthly.Text = GetExpenseForThisMonth(selectedUser).ToString("C");
            expenseMoneyLbl_yearly.Text = GetExpenseForThisYear(selectedUser).ToString("C");
            expenseMoneyLbl_total.Text = GetTotalExpense(selectedUser).ToString("C");
        }


        private void UserCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateIncomeLabels();
            UpdateExpenseLabels();
        }
    }
}
