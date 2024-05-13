using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace ExpenseTracker
{
    public class ExpenseData // Changed class name to ExpenseData for clarity
    {
        string connectionString = "server = 127.0.0.1; user = root; database = expensetrackingdb; password =";

        public DataTable GetExpenseData(string filterType = "") // Added optional filterType parameter
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "";
                if (filterType == "Expense")
                {
                    query = "SELECT categoryName FROM category WHERE transactionType = 'Expense'"; // Filter for Expense
                }
                else if (filterType == "Income")
                {
                    query = "SELECT categoryName FROM category WHERE transactionType = 'Income'"; // Filter for Income
                }
                else
                {
                    query = "SELECT categoryName FROM category"; // Show all if no filter
                }

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }
    }
}
