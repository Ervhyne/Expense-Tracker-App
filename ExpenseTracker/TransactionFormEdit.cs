using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ExpenseTracker
{
    public partial class TransactionFormEdit : Form
    {
        string connectionString = "server=127.0.0.1; user=root; database=expensetrackingdb; password=";
        private string amount;
        private string notes;
        private int transactionId;

        private const string DefaultAmountText = "₱"; // Default text for the amount field
        private ExpenseData expenseData = new ExpenseData();

        public TransactionFormEdit(int transactionId, string amount, string notes, string transactionType, string selectedCategory)
        {
            InitializeComponent();

            // Initialize the form with the passed data
            this.transactionId = transactionId;
            this.amount = amount;
            this.notes = notes;

            // Populate the text boxes with the data
            if (!string.IsNullOrWhiteSpace(amount))
            {
                amountTxtBox.Text = DefaultAmountText + amount;
                amountTxtBox.ForeColor = Color.Black; // Set color to indicate actual value
            }
            else
            {
                amountTxtBox.Text = DefaultAmountText;
                amountTxtBox.ForeColor = Color.Gray; // Set color to indicate placeholder text
            }

            // Set the selected category in the combo-box
            categoryCbx.SelectedItem = selectedCategory;

            // Attach event handlers to amount field
            amountTxtBox.KeyPress += amountTxtBox_KeyPress;
            amountTxtBox.Enter += amountTxtBox_Enter;
            amountTxtBox.Leave += amountTxtBox_Leave;
            amountTxtBox.TextChanged += amountTxtBox_TextChanged; // Ensure the Peso sign is not removable

            // Attach KeyDown event handler for the form
            this.KeyDown += new KeyEventHandler(Form_KeyDown);

            // Populate the category combo-box based on transaction type
            PopulateCategoryComboBox(transactionType);
        }

        private void PopulateCategoryComboBox(string transactionType)
        {
            // Clear existing items
            categoryCbx.Items.Clear();

            // Fetch category data from ExpenseData based on transaction type
            DataTable categoryData = expenseData.GetExpenseData(transactionType);

            // Add fetched category names to the combo-box
            foreach (DataRow row in categoryData.Rows)
            {
                categoryCbx.Items.Add(row["categoryName"].ToString());
            }
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                saveBtn_Click(this, new EventArgs());
                e.Handled = true; // Prevent default handling of the Enter key
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string amountText = amountTxtBox.Text.Replace(DefaultAmountText, "").Trim();

            if (string.IsNullOrEmpty(amountText))
            {
                ShowAlert("Please enter an amount.", "Input Error", Color.FromArgb(255, 86, 86));
                return;
            }

            if (!decimal.TryParse(amountText, out decimal amount) || amount == 0)
            {
                ShowAlert("Please enter a valid amount.", "Input Error", Color.FromArgb(255, 86, 86));
                return;
            }

            string selectedCategory = categoryCbx.SelectedItem?.ToString(); // Get the selected category

            if (string.IsNullOrEmpty(selectedCategory))
            {
                ShowAlert("Please select a category.", "Input Error", Color.FromArgb(255, 86, 86));
                return;
            }

            // Update the transaction in the database
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE transactions SET amount = @amount, notes = @notes, category = @category WHERE id = @transactionId";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@amount", amount);
                        command.Parameters.AddWithValue("@notes", noteTxtBox.Text);
                        command.Parameters.AddWithValue("@category", selectedCategory); // Add category parameter
                        command.Parameters.AddWithValue("@transactionId", transactionId);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while saving the data. Please try again.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Close the form
            Close();
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

        // Event handler to restrict input to numeric values and a single decimal point
        private void amountTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void amountTxtBox_Enter(object sender, EventArgs e)
        {
            if (amountTxtBox.Text == DefaultAmountText)
            {
                amountTxtBox.Text = DefaultAmountText;
                amountTxtBox.ForeColor = Color.Black; // Reset text color if needed
                amountTxtBox.SelectionStart = amountTxtBox.Text.Length; // Move cursor to the end
            }
        }

        private void amountTxtBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(amountTxtBox.Text) || amountTxtBox.Text == DefaultAmountText)
            {
                amountTxtBox.Text = DefaultAmountText;
                amountTxtBox.ForeColor = Color.Gray; // Set text color to indicate placeholder text
            }
        }

        // Event handler to ensure default text is not deleted
        private void amountTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (!amountTxtBox.Text.StartsWith(DefaultAmountText))
            {
                amountTxtBox.Text = DefaultAmountText + amountTxtBox.Text.Replace(DefaultAmountText, "");
                amountTxtBox.SelectionStart = amountTxtBox.Text.Length; // Move cursor to the end
            }
        }

        public void SetSelectedCategory(string category)
        {
            // Set the selected category in the combo-box
            categoryCbx.SelectedItem = category;
        }
    }
}
