using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ExpenseTracker
{
    internal class DashboardData
    {
        string connectionString = "server=127.0.0.1; user=root; database=expensetrackingdb; password=";

        public DashboardData(string connectionString) // Add constructor
        {
            this.connectionString = connectionString;
        }

        public DataTable GetTransactionData(string selectedUser)
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT amount, category, transactionType FROM transactions WHERE user = @selectedUser ORDER BY date";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@selectedUser", selectedUser);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

        public DataTable GetTransactionRecordsData(string selectedUser, DateTime startDate, DateTime endDate, string filter = null)
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT id, category, amount, notes FROM transactions WHERE user = @selectedUser AND date BETWEEN @startDate AND @endDate";

                // Add filter for transaction type if provided
                if (!string.IsNullOrEmpty(filter))
                {
                    query += " AND transactionType = @transactionType";
                }

                query += " ORDER BY date";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@selectedUser", selectedUser);
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@endDate", endDate);

                    // Add parameter for transaction type if provided
                    if (!string.IsNullOrEmpty(filter))
                    {
                        command.Parameters.AddWithValue("@transactionType", filter);
                    }

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
