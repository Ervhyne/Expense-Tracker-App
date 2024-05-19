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
    public partial class Transactions : UserControl
    {
        // Connection string 
        string connectionString = "server=127.0.0.1; user=root; database=expensetrackingdb; password=";
        private DateTime currentStartDate;
        private DateTime currentEndDate;
        private string currentView = "Daily"; // Tracks the current view (Daily, Weekly, Monthly, Yearly)

        private ToolTip toolTip;


        public Transactions()
        {
            InitializeComponent();
            PopulateUserComboBox();
            LoadData();

            dailyBtn.PerformClick();
            expenseBtn.PerformClick();

            // Clear the selection in the DataGridView
            transactionTbl.ClearSelection();

            // Initialize the ToolTip if it's not added through the designer
            toolTip = new ToolTip();
        }

        public void LoadData(string filter = null)
        {
            if (userCbx.Items.Count > 0 && userCbx.SelectedItem != null)
            {
                string selectedUser = userCbx.SelectedItem.ToString();

                try
                {
                    DashboardData transactionData = new DashboardData(connectionString);
                    DateTime startDate = currentStartDate; // Assuming currentStartDate is accessible within the Transactions class
                    DateTime endDate = currentEndDate; // Assuming currentEndDate is accessible within the Transactions class
                    DataTable transactionTable = transactionData.GetTransactionRecordsData(selectedUser, startDate, endDate, filter);

                    transactionTbl.DataSource = transactionTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading data. Please try again.", "Data Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a user.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        public void LoadData(DateTime startDate, DateTime endDate, string filter = null)
        {
            if (userCbx.Items.Count > 0 && userCbx.SelectedItem != null)
            {
                string selectedUser = userCbx.SelectedItem.ToString();

                try
                {
                    DashboardData transactionData = new DashboardData(connectionString); // Create an instance of DashboardData
                    DataTable transactionTable = transactionData.GetTransactionRecordsData(selectedUser, startDate, endDate, filter); // Retrieve filtered transaction data

                    transactionTbl.DataSource = transactionTable; // Set the DataGridView's DataSource
                }
                catch (Exception ex)
                {
                    // Handle potential errors
                    MessageBox.Show("An error occurred while loading data. Please try again.", "Data Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Handle the case where no user is selected
                MessageBox.Show("Please select a user.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void expenseBtn_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(sender);
            LoadData("Expense");

            // Clear the selection in the DataGridView
            transactionTbl.ClearSelection();
        }

        private void incomeBtn_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(sender);
            LoadData("Income");

            // Clear the selection in the DataGridView
            transactionTbl.ClearSelection();
        }

        private Button clickedButton; // Store reference to clicked button
        private Button clickedButton1; // Store reference to clicked button
        private void ChangeButtonColor(object sender)
        {
            if (clickedButton != null)
            {
                clickedButton.BackColor = ColorTranslator.FromHtml("#786666"); // Revert previous button
            }
            clickedButton = (Button)sender; // Store clicked button reference
            clickedButton.BackColor = ColorTranslator.FromHtml("#D0A6A6"); // Set clicked color
        }

        private void ChangeButtonColorDate(object sender)
        {
            if (clickedButton1 != null)
            {
                clickedButton1.BackColor = System.Drawing.Color.FromArgb(120, 102, 102); // Revert previous button
            }
            clickedButton1 = (Button)sender; // Store clicked button reference
            clickedButton1.BackColor = System.Drawing.Color.FromArgb(161, 156, 106); // Set clicked color
        }

        private void dailyBtn_Click(object sender, EventArgs e)
        {
            if (userCbx.SelectedItem != null && userCbx.Items.Count > 0)
            {
                SetDateRange("Daily");
                ChangeButtonColorDate(sender);
                LoadData("Expense"); // Or "Income" based on your default selection
                                     // Check if the expense button was previously clicked
                if (clickedButton == expenseBtn)
                {
                    expenseBtn.PerformClick();
                }
                // Check if the income button was previously clicked
                else if (clickedButton == incomeBtn)
                {
                    incomeBtn.PerformClick();
                }
            }

            // Clear the selection in the DataGridView
            transactionTbl.ClearSelection();
        }

        private void weeklyBtn_Click(object sender, EventArgs e)
        {
            if (userCbx.SelectedItem != null && userCbx.Items.Count > 0)
            {
                SetDateRange("Weekly");
                ChangeButtonColorDate(sender);
                LoadData("Expense"); // Or "Income" based on your default selection
                                     // Check if the expense button was previously clicked
                if (clickedButton == expenseBtn)
                {
                    expenseBtn.PerformClick();
                }
                // Check if the income button was previously clicked
                else if (clickedButton == incomeBtn)
                {
                    incomeBtn.PerformClick();
                }
            }

            // Clear the selection in the DataGridView
            transactionTbl.ClearSelection();
        }

        private void monthlyBtn_Click(object sender, EventArgs e)
        {
            if (userCbx.SelectedItem != null && userCbx.Items.Count > 0)
            {
                SetDateRange("Monthly");
                ChangeButtonColorDate(sender);
                LoadData("Expense"); // Or "Income" based on your default selection
                                     // Check if the expense button was previously clicked
                if (clickedButton == expenseBtn)
                {
                    expenseBtn.PerformClick();
                }
                // Check if the income button was previously clicked
                else if (clickedButton == incomeBtn)
                {
                    incomeBtn.PerformClick();
                }
            }

            // Clear the selection in the DataGridView
            transactionTbl.ClearSelection();
        }

        private void yearlyBtn_Click(object sender, EventArgs e)
        {
            if (userCbx.SelectedItem != null && userCbx.Items.Count > 0)
            {
                SetDateRange("Yearly");
                ChangeButtonColorDate(sender);
                LoadData("Expense"); // Or "Income" based on your default selection
                                     // Check if the expense button was previously clicked
                if (clickedButton == expenseBtn)
                {
                    expenseBtn.PerformClick();
                }
                // Check if the income button was previously clicked
                else if (clickedButton == incomeBtn)
                {
                    incomeBtn.PerformClick();
                }
            }

            // Clear the selection in the DataGridView
            transactionTbl.ClearSelection();
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
            // Reload data
            LoadData(currentStartDate, currentEndDate);
            UpdateDateLabel();

            // Check if the expense button was previously clicked
            if (clickedButton == expenseBtn)
            {
                expenseBtn.PerformClick();
            }
            // Check if the income button was previously clicked
            else if (clickedButton == incomeBtn)
            {
                incomeBtn.PerformClick();
            }

            // Clear the selection in the DataGridView
            transactionTbl.ClearSelection();
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
            // Reload data
            LoadData(currentStartDate, currentEndDate);
            UpdateDateLabel();

            // Check if the expense button was previously clicked
            if (clickedButton == expenseBtn)
            {
                expenseBtn.PerformClick();
            }
            // Check if the income button was previously clicked
            else if (clickedButton == incomeBtn)
            {
                incomeBtn.PerformClick();
            }

            // Clear the selection in the DataGridView
            transactionTbl.ClearSelection();
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

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            PopulateUserComboBox();
            // Check if the expense button was previously clicked
            if (clickedButton == expenseBtn)
            {
                expenseBtn.PerformClick();
            }
            // Check if the income button was previously clicked
            else if (clickedButton == incomeBtn)
            {
                incomeBtn.PerformClick();
            }
        }

        private void refreshBtn_MouseHover(object sender, EventArgs e)
        {
            // Show the ToolTip with the message "refresh user combo-box"
            toolTip.Show("Refresh User Combo-box", refreshBtn, 0, -20, 1500); // The message will appear above the button for 2 seconds
        }

        private void userCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
            // Check if the expense button was previously clicked
            if (clickedButton == expenseBtn)
            {
                expenseBtn.PerformClick();
            }
            // Check if the income button was previously clicked
            else if (clickedButton == incomeBtn)
            {
                incomeBtn.PerformClick();
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (selectedTransactionId != -1)
            {
                string transactionType = GetTransactionType(selectedTransactionId); // Get the transaction type
                string selectedCategory = GetSelectedCategory(selectedTransactionId); // Get the selected category

                // Create an instance of TransactionFormEdit
                TransactionFormEdit transactionFormEdit = new TransactionFormEdit(selectedTransactionId, selectedAmount, selectedNotes, transactionType, selectedCategory);

                // Set the selected category
                transactionFormEdit.SetSelectedCategory(selectedCategory);

                // Show the form
                transactionFormEdit.ShowDialog();

                // Reload data after editing
                LoadData();
                LoadData(currentStartDate, currentEndDate);

                // Check if the expense button was previously clicked
                if (clickedButton == expenseBtn)
                {
                    expenseBtn.PerformClick();
                }
                // Check if the income button was previously clicked
                else if (clickedButton == incomeBtn)
                {
                    incomeBtn.PerformClick();
                }
            }
            else
            {
                // Show a message indicating that no row is selected
                MessageBox.Show("Please select a row in the transaction table.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Clear the selection in the DataGridView
            transactionTbl.ClearSelection();
        }


        private string GetSelectedCategory(int transactionId)
        {
            string query = "SELECT category FROM transactions WHERE id = @transactionId";
            string category;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@transactionId", transactionId);
                    category = (string)command.ExecuteScalar();
                }
            }

            return category;
        }

        private string GetTransactionType(int transactionId)
        {
            string query = "SELECT transactionType FROM transactions WHERE id = @transactionId";
            string transactionType;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@transactionId", transactionId);
                    transactionType = (string)command.ExecuteScalar();
                }
            }

            return transactionType;
        }


        private string selectedAmount = "";
        private string selectedNotes = "";
        private int selectedTransactionId = -1;

        private void transactionTbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = transactionTbl.Rows[e.RowIndex];
                selectedAmount = row.Cells["amount"].Value.ToString();
                selectedNotes = row.Cells["notes"].Value.ToString();
                selectedTransactionId = Convert.ToInt32(row.Cells["id"].Value); // Assuming the column name for ID is "id"
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (selectedTransactionId != -1)
            {
                // Ask for confirmation before deleting
                DialogResult result = MessageBox.Show("Are you sure you want to delete this transaction?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Delete the transaction from the database
                    DeleteTransaction(selectedTransactionId);

                    // Reload data after deleting
                    LoadData();
                    LoadData(currentStartDate, currentEndDate);

                    // Clear the selection in the DataGridView
                    transactionTbl.ClearSelection();
                }
            }
            else
            {
                // Show a message indicating that no row is selected
                MessageBox.Show("Please select a row in the transaction table.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteTransaction(int transactionId)
        {
            // Implement the logic to delete the transaction from the database
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM transactions WHERE id = @transactionId";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@transactionId", transactionId);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting the transaction. Please try again.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
