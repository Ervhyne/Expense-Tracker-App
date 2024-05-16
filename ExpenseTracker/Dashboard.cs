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
using System.Windows.Forms.DataVisualization.Charting;

namespace ExpenseTracker
{
    public partial class Dashboard : UserControl
    {
        // Connection string 
        string connectionString = "server=127.0.0.1; user=root; database=expensetrackingdb; password=";

        private DateTime currentStartDate;
        private DateTime currentEndDate;
        private string currentView = "Daily"; // Tracks the current view (Daily, Weekly, Monthly, Yearly)

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

            // Register the event handlers for the buttons
            dailyBtn.Click += dailyBtn_Click;
            weeklyBtn.Click += weeklyBtn_Click;
            monthlyBtn.Click += monthlyBtn_Click;
            yearlyBtn.Click += yearlyBtn_Click;

            SetDateRange("Daily"); // Default to daily view
            UpdateDashboard(userCbx.SelectedItem.ToString(), currentStartDate, currentEndDate);
            dailyBtn.PerformClick();
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

            DateTime today = DateTime.Today;
            UpdateDashboard(userCbx.SelectedItem.ToString(), currentStartDate, currentEndDate);
        }

        private void LoadData()
        {
            if (userCbx.Items.Count > 0 && userCbx.SelectedItem != null)
            {
                string selectedUser = userCbx.SelectedItem.ToString();
                DataTable filteredTransactionData = GetFilteredTransactionData(selectedUser, currentStartDate, currentEndDate);
                DashboardData dashboardData = new DashboardData(connectionString); // Create an instance of DashboardData
                DataTable dashboardTable = dashboardData.GetTransactionData(selectedUser); // Retrieve filtered transaction data

                transactionTbl.DataSource = dashboardTable; // Set the DataGridView's DataSource
                LoadTransactionData(selectedUser, currentStartDate, currentEndDate);
                ExpenseTodayIncome(selectedUser);
                IncomeTodayIncome(selectedUser);

                // Update the balance label
                UpdateBalanceLabel(selectedUser);

                // Load chart with transaction data
                LoadChart(filteredTransactionData); // Pass the filtered transaction data to LoadChart

                UpdateDashboard(selectedUser, currentStartDate, currentEndDate);
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
                      System.Windows.Forms.MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void UpdateIncomeAndExpenseLabels(string selectedUser, DateTime startDate, DateTime endDate)
        {
            decimal totalIncome = GetTotalAmount(selectedUser, "Income", startDate, endDate);
            decimal totalExpense = GetTotalAmount(selectedUser, "Expense", startDate, endDate);
            decimal balance = totalIncome - totalExpense;

            incomeMoneyLbl.Text = totalIncome.ToString("C");
            expenseMoneyLbl.Text = totalExpense.ToString("C");
            balanceLbl.Text = balance.ToString("C");
        }

        private decimal GetTotalAmount(string selectedUser, string transactionType, DateTime startDate, DateTime endDate)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Query to retrieve the total amount for the selected user and transaction type within the date range
                string query = "SELECT SUM(amount) FROM transactions WHERE user = @selectedUser AND transactionType = @transactionType AND date BETWEEN @startDate AND @endDate";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@selectedUser", selectedUser);
                    command.Parameters.AddWithValue("@transactionType", transactionType);
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@endDate", endDate);

                    object result = command.ExecuteScalar();

                    // Check if the result is not null or DBNull
                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToDecimal(result);
                    }
                    else
                    {
                        return 0; // No amount found
                    }
                }
            }
        }

        private void LoadTransactionData(string selectedUser, DateTime startDate, DateTime endDate)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Query to retrieve transactions for the selected user within the date range and only for 'Expense' type
                string query = "SELECT amount, category FROM transactions WHERE user = @selectedUser AND transactionType = 'Expense' AND date BETWEEN @startDate AND @endDate ORDER BY date";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@selectedUser", selectedUser);
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@endDate", endDate);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        transactionTbl.DataSource = dataTable; // Set the DataGridView's DataSource
                    }
                }
            }
        }

        private void UpdateDashboard(string selectedUser, DateTime startDate, DateTime endDate)
        {
            LoadTransactionData(selectedUser, startDate, endDate);
            UpdateIncomeAndExpenseLabels(selectedUser, startDate, endDate);
        }

        private void dailyBtn_Click(object sender, EventArgs e)
        {
            SetDateRange("Daily");
            UpdateDashboard(userCbx.SelectedItem.ToString(), currentStartDate, currentEndDate);
            LoadChart(GetFilteredTransactionData(userCbx.SelectedItem.ToString(), currentStartDate, currentEndDate)); // Pass filtered data to LoadChart
            ChangeButtonColor(sender);
        }

        private void weeklyBtn_Click(object sender, EventArgs e)
        {
            SetDateRange("Weekly");
            UpdateDashboard(userCbx.SelectedItem.ToString(), currentStartDate, currentEndDate);
            LoadChart(GetFilteredTransactionData(userCbx.SelectedItem.ToString(), currentStartDate, currentEndDate)); // Pass filtered data to LoadChart
            ChangeButtonColor(sender);
        }

        private void monthlyBtn_Click(object sender, EventArgs e)
        {
            SetDateRange("Monthly");
            UpdateDashboard(userCbx.SelectedItem.ToString(), currentStartDate, currentEndDate);
            LoadChart(GetFilteredTransactionData(userCbx.SelectedItem.ToString(), currentStartDate, currentEndDate)); // Pass filtered data to LoadChart
            ChangeButtonColor(sender);
        }

        private void yearlyBtn_Click(object sender, EventArgs e)
        {
            SetDateRange("Yearly");
            UpdateDashboard(userCbx.SelectedItem.ToString(), currentStartDate, currentEndDate);
            LoadChart(GetFilteredTransactionData(userCbx.SelectedItem.ToString(), currentStartDate, currentEndDate)); // Pass filtered data to LoadChart
            ChangeButtonColor(sender);
        }

        private DataTable GetFilteredTransactionData(string selectedUser, DateTime startDate, DateTime endDate)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT amount, category, transactionType FROM transactions WHERE user = @selectedUser AND date BETWEEN @startDate AND @endDate ORDER BY date";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@selectedUser", selectedUser);
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@endDate", endDate);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable; // Return the filtered transaction data
                    }
                }
            }
        }

        private Button clickedButton; // Store reference to clicked button
        private void ChangeButtonColor(object sender)
        {
            if (clickedButton != null)
            {
                clickedButton.BackColor = System.Drawing.Color.FromArgb(120, 102, 102); // Revert previous button
            }
            clickedButton = (Button)sender; // Store clicked button reference
            clickedButton.BackColor = System.Drawing.Color.FromArgb(161, 156, 106); // Set clicked color
        }

        private void UpdateDateLabel()
        {
            switch (currentView)
            {
                case "Daily":
                    dateLbl.Text = currentStartDate.ToString("ddd, dd MMM");
                    break;
                case "Weekly":
                    dateLbl.Text = $"{currentStartDate:dd} - {currentEndDate:dd MMM}";
                    break;
                case "Monthly":
                    dateLbl.Text = $"{currentStartDate:MMMM, yyyy}";
                    break;
                case "Yearly":
                    dateLbl.Text = $"{currentStartDate:yyyy}";
                    break;
            }
        }

        private void SetDateRange(string view)
        {
            currentView = view;
            DateTime today = DateTime.Today;
            switch (view)
            {
                case "Daily":
                    currentStartDate = today;
                    currentEndDate = today;
                    break;
                case "Weekly":
                    // Adjust to start on Monday
                    int diff = (7 + (today.DayOfWeek - DayOfWeek.Monday)) % 7;
                    currentStartDate = today.AddDays(-diff).Date;
                    currentEndDate = currentStartDate.AddDays(6);
                    break;
                case "Monthly":
                    currentStartDate = new DateTime(today.Year, today.Month, 1);
                    currentEndDate = currentStartDate.AddMonths(1).AddDays(-1);
                    break;
                case "Yearly":
                    currentStartDate = new DateTime(today.Year, 1, 1);
                    currentEndDate = new DateTime(today.Year, 12, 31);
                    break;
            }
            UpdateDateLabel();
        }

        private void dateLeftBtn_Click(object sender, EventArgs e)
        {
            switch (currentView)
            {
                case "Daily":
                    currentStartDate = currentStartDate.AddDays(-1);
                    currentEndDate = currentStartDate;
                    break;
                case "Weekly":
                    currentStartDate = currentStartDate.AddDays(-7);
                    currentEndDate = currentStartDate.AddDays(6);
                    break;
                case "Monthly":
                    currentStartDate = currentStartDate.AddMonths(-1);
                    currentEndDate = currentStartDate.AddMonths(1).AddDays(-1);
                    break;
                case "Yearly":
                    currentStartDate = currentStartDate.AddYears(-1);
                    currentEndDate = new DateTime(currentStartDate.Year, 12, 31);
                    break;
            }
            UpdateDateLabel();
            UpdateDashboard(userCbx.SelectedItem.ToString(), currentStartDate, currentEndDate);
            LoadChart(GetFilteredTransactionData(userCbx.SelectedItem.ToString(), currentStartDate, currentEndDate)); // Load chart with filtered transaction data
        }

        private void dateRightBtn_Click(object sender, EventArgs e)
        {
            switch (currentView)
            {
                case "Daily":
                    currentStartDate = currentStartDate.AddDays(1);
                    currentEndDate = currentStartDate;
                    break;
                case "Weekly":
                    currentStartDate = currentStartDate.AddDays(7);
                    currentEndDate = currentStartDate.AddDays(6);
                    break;
                case "Monthly":
                    currentStartDate = currentStartDate.AddMonths(1);
                    currentEndDate = currentStartDate.AddMonths(1).AddDays(-1);
                    break;
                case "Yearly":
                    currentStartDate = currentStartDate.AddYears(1);
                    currentEndDate = new DateTime(currentStartDate.Year, 12, 31);
                    break;
            }
            UpdateDateLabel();
            UpdateDashboard(userCbx.SelectedItem.ToString(), currentStartDate, currentEndDate);
            LoadChart(GetFilteredTransactionData(userCbx.SelectedItem.ToString(), currentStartDate, currentEndDate)); // Load chart with filtered transaction data
        }

        void LoadChart(DataTable transactionData)
        {
            // Clear existing series and legends
            ExpenseChart.Series.Clear();
            ExpenseChart.Legends.Clear();

            // Create a new series
            Series series = new Series("Amount"); // Set the series name
            series.ChartType = SeriesChartType.Doughnut;
            series["PieLabelStyle"] = "Outside";
            series["PieLineColor"] = "Gray";
            series.LabelForeColor = System.Drawing.Color.White;

            // Add data points for expense transactions
            foreach (DataRow row in transactionData.Rows)
            {
                string category = row["category"].ToString();
                decimal amount = Convert.ToDecimal(row["amount"]);
                string transactionType = row["transactionType"].ToString();

                // Only add data points for expense transactions
                if (transactionType == "Expense")
                {
                    series.Points.AddXY(category, amount);
                }
            }

            // Add the series to the chart
            ExpenseChart.Series.Add(series);
        }
    }
}
