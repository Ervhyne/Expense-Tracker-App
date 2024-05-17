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
    public partial class Reports : UserControl
    {
        // Connection string 
        string connectionString = "server=127.0.0.1; user=root; database=expensetrackingdb; password=";

        private DateTime currentYear;

        public Reports()
        {
            InitializeComponent();
            currentYear = DateTime.Now;
            UpdateDateLabel();
            PopulateUserComboBox();
        }

        private void UpdateDateLabel()
        {
            dateLbl.Text = currentYear.ToString("yyyy");
        }

        private void dateLeftBtn_Click(object sender, EventArgs e)
        {
            currentYear = currentYear.AddYears(-1);
            UpdateDateLabel();
        }

        private void dateRightBtn_Click(object sender, EventArgs e)
        {
            currentYear = currentYear.AddYears(1);
            UpdateDateLabel();
        }



        private void refreshBtn_Click(object sender, EventArgs e)
        {
            PopulateUserComboBox();
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
    }
}
