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
        public Category()
        {
            InitializeComponent();
            if (categoryForm != null)  // Check if reference exists (optional)
            {
                categoryForm.CategorySaved += OnCategoryFormSaved;  // Subscribe to event
            }
            // Call RefreshData to initially populate the DataGridView
            RefreshData();
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
            categoryForm.ShowDialog(); // Show the form as a modal dialog
        }

        private void editBtn_category_Click(object sender, EventArgs e)
        {
            if (categoryForm == null)
            {
                categoryForm = new CategoryForm();
                categoryForm.FormClosed += CategoryForm_FormClosed; // Subscribe to FormClosed event
            }

            categoryForm.StartPosition = FormStartPosition.CenterScreen; // Center the modal form
            categoryForm.ShowDialog(); // Show the form as a modal dialog
        }

        private void deleteBtn_category_Click(object sender, EventArgs e)
        {
            if (categoryTbl_category.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = categoryTbl_category.SelectedRows[0];

                // Confirmation dialog (optional)
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this category?", "Delete Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // Get category name from the selected row
                    string categoryName = selectedRow.Cells["categoryName"].Value.ToString();  // Adjust as needed

                    // Connect to database (assuming connection string is available)
                    string connectionString = "server=127.0.0.1; user=root; database=expensetrackingdb; password=";
                    MySqlConnection connection = new MySqlConnection(connectionString);

                    try
                    {
                        connection.Open();

                        // Create and execute MySQL DELETE command (assuming category name is unique)
                        string sql = "DELETE FROM category WHERE categoryName = @categoryName";
                        MySqlCommand command = new MySqlCommand(sql, connection);
                        command.Parameters.AddWithValue("@categoryName", categoryName);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Category deleted successfully
                            RefreshData();  // Update DataGridView
                            MessageBox.Show("Category deleted successfully!", "Success", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("An error occurred while deleting the category. No rows affected.", "Error", MessageBoxButtons.OK);
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("An error occurred while deleting the category: " + ex.Message, "Error", MessageBoxButtons.OK);
                    }
                    finally
                    {
                        connection.Close();  // Ensure connection is closed
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a category to delete.", "No Selection", MessageBoxButtons.OK);
            }
        }

        private Button clickedButton; // Store reference to clicked button
        private void expenseBtn_category_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(sender);
        }

        private void incomeBtn_category_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(sender);
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

            string connectionString = "server=127.0.0.1; user=root; database=expensetrackingdb; password=";
            CategoryDataProvider provider = new CategoryDataProvider(connectionString);

            DataTable categories = provider.GetCategories();
            categoryTbl_category.DataSource = categories;
        }

        public void RefreshData()
        {
            string connectionString = "server=127.0.0.1; user=root; database=expensetrackingdb; password=";
            CategoryDataProvider provider = new CategoryDataProvider(connectionString);

            DataTable categories = provider.GetCategories();
            categoryTbl_category.DataSource = categories;
        }

        private void OnCategoryFormSaved(object sender, EventArgs e)
        {
            RefreshData();  // Call RefreshData to update DataGridView on successful save
        }
    }
}
