using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace ExpenseTracker
{
    public class CategoryDataProvider
    {
        private readonly string connectionString;

        public CategoryDataProvider(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public DataTable GetCategories()
        {
            DataTable table = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string sql = "SELECT categoryName FROM category";

                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(table);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error loading categories: " + ex.Message);  // Replace with your desired error handling
                }
            }

            return table;
        }
    }
    
}
