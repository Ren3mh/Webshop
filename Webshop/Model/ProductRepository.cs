using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop.Model;
using System.Data.SQLite;

namespace Webshop.Model
{
    public class ProductRepository : IRepository<Product>
    {
        private readonly string _connectionString;

        public ProductRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<Product> GetAll()
        {
            var products = new List<Product>();
            string query = "SELECT * FROM Products";

            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                connection.Open();

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        products.Add(new Product
                        {
                            ProductId = (int)reader["ProductID"],
                            _Category = (Category)(int)reader["CategoryId"],
                            Name = (string)reader["ProductName"],
                            Description = (string)reader["Description"],
                            Price = Convert.ToDouble( reader["Price"] ),
                            Stock = (int)reader["Stock"],
                            ImagePath = (string)reader["ImagePath"]
                        });
                    }
                }
            }

            return products;
        }

        public Product GetById(int id)
        {
            Product semester = null;
            string query = "SELECT * FROM SEMESTER WHERE SemesterId = @SemesterId";

            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@SemesterId", id);
                connection.Open();

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        semester = new Product
                        {
                            //SemesterId = (int)reader["SemesterId"],
                            //Number = (int)reader["Number"]
                        };
                    }
                }
            }

            return semester;
        }

        public void Add(Product semester)
        {
            string query = "INSERT INTO SEMESTER (Number) VALUES (@Number)";

            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                //command.Parameters.AddWithValue("@Number", semester.Number);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Update(Product semester)
        {
            string query = "UPDATE SEMESTER SET Number = @Number WHERE SemesterId = @SemesterId";

            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                //command.Parameters.AddWithValue("@Number", semester.Number);
                //command.Parameters.AddWithValue("@SemesterId", semester.SemesterId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            string query = "DELETE FROM SEMESTER WHERE SemesterId = @SemesterId";

            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@SemesterId", id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
