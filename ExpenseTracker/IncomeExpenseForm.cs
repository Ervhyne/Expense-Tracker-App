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
using Mysqlx.Crud;

namespace ExpenseTracker
{
    public partial class IncomeExpenseForm : Form
    {
        private AccountData accountsData;
        private ExpenseData expenseData;
        private const string DefaultAmountText = "₱"; // Default text for the amount field

        public string ButtonType { get; set; }

        // Connection string (replace with your actual connection details)
        string connectionString = "server=127.0.0.1; user=root; database=expensetrackingdb; password=";

        private bool isIncomeSelected = false;
        private bool isExpenseSelected = false;

        public IncomeExpenseForm(string buttonType)
        {
            InitializeComponent();

            accountsData = new AccountData(); // Initialize the AccountsData object
            PopulateUserComboBox(); // Call the method to populate the combo-box

            expenseData = new ExpenseData();

            // Initially disable the category combo-box
            categoryCbx.Enabled = false;

            // Set default text for amount field
            amountTxtField.Text = DefaultAmountText;
            amountTxtField.ForeColor = Color.Gray; // Set the color to indicate it's a placeholder

            // Attach event handlers to amount field
            amountTxtField.KeyPress += AmountTxtField_KeyPress;
            amountTxtField.Enter += AmountTxtField_Enter;
            amountTxtField.Leave += AmountTxtField_Leave;
            amountTxtField.TextChanged += AmountTxtField_TextChanged; // Handle text changes

            ButtonType = buttonType;
            
        }

        private Button clickedButton; // Store reference to clicked button
        private void expenseBtn_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(sender);
            // Enable the combo-box and populate with Expense data
            categoryCbx.Enabled = true;
            PopulateCategoryComboBox("Expense");

        }

        private void incomeBtn_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(sender);
            // Enable the combo-box and populate with Income data
            categoryCbx.Enabled = true;
            PopulateCategoryComboBox("Income");

            isIncomeSelected = true;
            isExpenseSelected = false;

        }

        // Helper function to handle color change and reset
        private void ChangeButtonColor(object sender)
        {
            if (clickedButton != null)
            {
                clickedButton.BackColor = Color.Transparent; // Revert previous button
            }
            clickedButton = (Button)sender; // Store clicked button reference
            clickedButton.BackColor = ColorTranslator.FromHtml("#4D353C"); // Set clicked color

            isIncomeSelected = false;
            isExpenseSelected = true;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Check if userCbx is empty
            if (userCbx.SelectedIndex == -1)
            {
                warningLbl.ForeColor = Color.FromArgb(255, 86, 86);
                warningTimer.Start();
                return;
            }

            // Check if categoryCbx is empty
            if (categoryCbx.SelectedIndex == -1)
            {
                warningLbl.ForeColor = Color.FromArgb(255, 86, 86);
                warningTimer.Start();
                return;
            }

            // Check if datePicker is empty
            if (datePicker.Value == null || datePicker.Value == DateTime.MinValue)
            {
                warningLbl.ForeColor = Color.FromArgb(255, 86, 86);
                warningTimer.Start();
                return;
            }

            // Check if amountTxtField is empty or has only the default text
            string amountText = amountTxtField.Text.Replace(DefaultAmountText, "").Trim();
            if (string.IsNullOrWhiteSpace(amountText))
            {
                ShowAlert("Please enter an amount.", "Input Error", Color.FromArgb(255, 86, 86));
                return;
            }

            // Check if the amount is zero
            if (!decimal.TryParse(amountText, out decimal amount) || amount == 0)
            {
                ShowAlert("Please enter a valid amount.", "Input Error", Color.FromArgb(255, 86, 86));
                return;
            }

            // Check if the income or expense transaction type is selected
            if (isIncomeSelected)
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Prepare the SQL command
                        string sql = "INSERT INTO transactions (user, transactionType, category, amount, date, notes) VALUES (@user, @transactionType, @category, @amount, @date, @notes)";
                        MySqlCommand command = new MySqlCommand(sql, connection);

                        // Assign parameter values
                        command.Parameters.AddWithValue("@user", userCbx.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@transactionType", "Income");
                        command.Parameters.AddWithValue("@category", categoryCbx.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@amount", amount);
                        command.Parameters.AddWithValue("@date", datePicker.Value);
                        command.Parameters.AddWithValue("@notes", noteTxtArea.Text);

                        // Execute the command
                        command.ExecuteNonQuery();

                        // Close the form after successful insertion
                        Close();
                    }
                    catch (Exception ex)
                    {
                        // Handle exceptions (e.g., display error message)
                        MessageBox.Show("An error occurred while inserting data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (isExpenseSelected)
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Prepare the SQL command
                        string sql = "INSERT INTO transactions (user, transactionType, category, amount, date, notes) VALUES (@user, @transactionType, @category, @amount, @date, @notes)";
                        MySqlCommand command = new MySqlCommand(sql, connection);

                        // Assign parameter values
                        command.Parameters.AddWithValue("@user", userCbx.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@transactionType", "Expense");
                        command.Parameters.AddWithValue("@category", categoryCbx.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@amount", amount);
                        command.Parameters.AddWithValue("@date", datePicker.Value);
                        command.Parameters.AddWithValue("@notes", noteTxtArea.Text);

                        // Execute the command
                        command.ExecuteNonQuery();

                        // Close the form after successful insertion
                        Close();
                    }
                    catch (Exception ex)
                    {
                        // Handle exceptions (e.g., display error message)
                        MessageBox.Show("An error occurred while inserting data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                ShowAlert("Please select a transaction type.", "Input Error", Color.FromArgb(255, 86, 86));
                return;
            }

        }

        private void IncomeExpenseForm_Load(object sender, EventArgs e)
        {
            // Automatically click the corresponding button based on the passed buttonType
            if (ButtonType == "Income")
            {
                incomeBtn_form.PerformClick();
            }
            else if (ButtonType == "Expense")
            {
                expenseBtn_form.PerformClick();
            }
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
                }
                catch (MySqlException ex)
                {
                    // Handle exceptions
                    Console.WriteLine("An error occurred: " + ex.Message);
                    // You may want to display an error message to the user here
                }
            }
        }


        public void PopulateCategoryComboBox(string filterType)
        {
            try
            {
                // Clear existing items
                categoryCbx.Items.Clear();

                // Get filtered category data based on filterType
                DataTable filteredData = expenseData.GetExpenseData(filterType);

                // Add the filtered category names to the combo-box
                foreach (DataRow row in filteredData.Rows)
                {
                    string categoryName = row["categoryName"].ToString();
                    categoryCbx.Items.Add(categoryName);
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine("An error occurred: " + ex.Message);
                // You may want to display an error message to the user here
            }
        }

        // Event handler to restrict input to numeric values and a single decimal point
        private void AmountTxtField_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys, numbers, and a single decimal point
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        // Event handler for when the amount field gains focus
        private void AmountTxtField_Enter(object sender, EventArgs e)
        {
            if (amountTxtField.Text == DefaultAmountText)
            {
                amountTxtField.Text = DefaultAmountText;
                amountTxtField.ForeColor = Color.White; // Reset text color if needed
                amountTxtField.SelectionStart = amountTxtField.Text.Length; // Move cursor to the end
            }
        }

        // Event handler for when the amount field loses focus
        private void AmountTxtField_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(amountTxtField.Text) || amountTxtField.Text == DefaultAmountText)
            {
                amountTxtField.Text = DefaultAmountText;
                amountTxtField.ForeColor = Color.Gray; // Set text color to indicate placeholder text
            }
        }

        // Event handler to ensure default text is not deleted
        private void AmountTxtField_TextChanged(object sender, EventArgs e)
        {
            if (!amountTxtField.Text.StartsWith(DefaultAmountText))
            {
                amountTxtField.Text = DefaultAmountText + amountTxtField.Text.Replace(DefaultAmountText, "");
                amountTxtField.SelectionStart = amountTxtField.Text.Length; // Move cursor to the end
            }
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

        private void warningTimer_Tick(object sender, EventArgs e)
        {
            warningLbl.ForeColor = Color.FromArgb(52, 52, 52);
        }
    }
}

