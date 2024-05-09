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
    public partial class Category : UserControl
    {
        public Category()
        {
            InitializeComponent();
        }

        private CategoryForm categoryForm;
        public static int parentX, parentY;
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
    }
}
