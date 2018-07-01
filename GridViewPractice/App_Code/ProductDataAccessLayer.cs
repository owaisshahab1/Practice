using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for ProductDataAccessLayer
/// </summary>

//namespace Demo
//{
        public class Product
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string Description { get; set; }
    }

        public class ProductDataAccessLayer
        {
            public static List<Product> GetAllProducts()
            {
                List<Product> listProducts = new List<Product>();
                string cs = ConfigurationManager.ConnectionStrings["GridView_KudvankatConnectionString"].ConnectionString;

                using (SqlConnection con = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand("Select * from tblProducts", con);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Product product = new Product();
                        product.Id = Convert.ToInt32(reader["Id"]);
                        product.Name = reader["Name"].ToString();
                        product.Description = reader["Description"].ToString();
                        listProducts.Add(product);
                    }

                }
                return listProducts;
            }

            public ProductDataAccessLayer()
            {


            }
        }
//}
