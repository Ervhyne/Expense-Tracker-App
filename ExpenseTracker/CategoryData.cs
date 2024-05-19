﻿using System;
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
                    query = "SELECT categoryName FROM category WHERE transactionType = 'Expense' ORDER BY categoryName"; // Filter for Expense
                }
                else if (filterType == "Income")
                {
                    query = "SELECT categoryName FROM category WHERE transactionType = 'Income' ORDER BY categoryName"; // Filter for Income
                }
                else
                {
                    query = "SELECT categoryName FROM category ORDER BY categoryName"; // Show all if no filter
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

        public string GetTransactionType(string categoryName)
        {
            string transactionType = "";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT transactionType FROM category WHERE categoryName = @categoryName";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@categoryName", categoryName);
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        transactionType = result.ToString();
                    }
                }
            }
            return transactionType;
        }

    }
}
