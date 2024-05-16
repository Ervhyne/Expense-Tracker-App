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
    public partial class Category : UserControl
    {
        string connectionString = "server=127.0.0.1; user=root; database=expensetrackingdb; password=";

        public Category()
        {
            InitializeComponent();

            expenseData = new ExpenseData(); // Create an instance on load
            LoadData("Expense"); // Call LoadData with initial filter (Expense)
        }
    
        private ExpenseData expenseData; // Instance of ExpenseData class
        private void LoadData(string filterType = "")
        {
            DataTable dataTable = expenseData.GetExpenseData(filterType); // Get data with filter
            categoryTbl_category.DataSource = dataTable; // Set DataGridView's DataSource
        }

        private string GetSelectedFilter()
        {
            if (incomeBtn_category.BackColor == ColorTranslator.FromHtml("#D0A6A6"))
            {
                return "Income";
            }
            else
            {
                return "Expense";
            }
        }

        private CategoryForm categoryForm;
        private void addBtn_category_Click(object sender, EventArgs e)
        {
            if (categoryForm == null)
            {
                categoryForm = new CategoryForm();
                categoryForm.FormClosed += CategoryForm_FormClosed; // Subscribe to FormClosed event
            }

            categoryForm.StartPosition = FormStartPosition.CenterScreen; // Center the modal form
            categoryForm.ShowInTaskbar = false;
            categoryForm.ShowDialog(); // Show the form as a modal dialog

            string selectedFilter = GetSelectedFilter(); // Call helper function to get filter
            LoadData(selectedFilter);
        }

        private CategoryFormEdit categoryFormEdit;
        private void editBtn_category_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(getCategoryName))
            {
                return;
            }

            // Open the edit form and pass the selected category name
            using (CategoryFormEdit editForm = new CategoryFormEdit(getCategoryName))
            {
                editForm.StartPosition = FormStartPosition.CenterScreen; // Center the modal form
                editForm.ShowInTaskbar = false;

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    // Handle any post-edit actions if needed
                    // For example, refresh the data grid view
                    string selectedFilter = GetSelectedFilter();
                    LoadData(selectedFilter);
                }
            }
        }

        private string getCategoryName = "";
        private void categoryTbl_category_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = categoryTbl_category.Rows[e.RowIndex];
                getCategoryName = row.Cells["categoryName"].Value.ToString();
            }
        }

        private void deleteBtn_category_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(getCategoryName))
            {
                MessageBox.Show("Please select a category to delete.");
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string deleteData = "DELETE FROM category WHERE categoryName = @categoryName AND transactionType = @transactionType";

                using (MySqlCommand command = new MySqlCommand(deleteData, connection))
                {
                    command.Parameters.AddWithValue("@categoryName", getCategoryName);
                    command.Parameters.AddWithValue("@transactionType", GetSelectedFilter());
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }

            string selectedFilter = GetSelectedFilter(); // Call helper function to get filter
            LoadData(selectedFilter);
        }

        private Button clickedButton; // Store reference to clicked button
        private void expenseBtn_category_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(sender);
            LoadData("Expense"); // Load data for expenses
        }

        private void incomeBtn_category_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(sender);
            LoadData("Income"); // Load data for income
        }

        // Helper function to handle color change and reset
        private void ChangeButtonColor(object sender)
        {
            if (clickedButton != null)
            {
                clickedButton.BackColor = ColorTranslator.FromHtml("#786666"); // Revert previous button
            }
            clickedButton = (Button)sender; // Store clicked button reference
            clickedButton.BackColor = ColorTranslator.FromHtml("#D0A6A6"); // Set clicked color
        }

        private void CategoryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            categoryForm = null; // Reset the reference (optional)
        }

        private void Category_Load(object sender, EventArgs e)
        {
            expenseBtn_category.PerformClick();
        }
    }
}
