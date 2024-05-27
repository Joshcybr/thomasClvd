using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TH.Models;

namespace thomasClvd.Models
{
    public class Database
    {
        private string connectionString = "Server=tcp:joshua-s.database.windows.net,1433;Initial Catalog=thomasclvd_;Persist Security Info=False;User ID=joshua;Password=123123J#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";

        public List<ProductDisplayModel> SelectProducts()
        {
            List<ProductDisplayModel> products = new List<ProductDisplayModel>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Products";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            products.Add(new ProductDisplayModel
                            {
                                ProductID = (int)reader["ProductID"],
                                ProductName = reader["ProductName"].ToString(),
                                Price = (decimal)reader["Price"],
                                
                            });
                        }
                    }
                }
            }
            return products;
        }

        public void AddToCart(int productId, int quantity)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO CartItems (ProductID, Quantity) VALUES (@ProductID, @Quantity)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ProductID", productId);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<CartItem> GetCartItems()
        {
            List<CartItem> cartItems = new List<CartItem>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT ci.CartItemID, ci.Quantity, p.ProductID, p.ProductName, p.Price, p.ImageUrl FROM CartItems ci JOIN Products p ON ci.ProductID = p.ProductID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product product = new Product
                            {
                                ProductID = (int)reader["ProductID"],
                                ProductName = reader["ProductName"].ToString(),
                                Price = (decimal)reader["Price"],

                            };
                            cartItems.Add(new CartItem
                            {
                                CartItemID = (int)reader["CartItemID"],
                                ProductID = (int)reader["ProductID"],
                                Quantity = (int)reader["Quantity"],
                              
                            });
                        }
                    }
                }
            }
            return cartItems;
        }
    }
}
