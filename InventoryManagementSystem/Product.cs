using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    internal class Product
    {
        public string id;
        public string code;
        public string name;
        public int quantity;
        public float cost_price;
        public float retail_price;
        public int reorder_level;
        public int category;



        // constructor
        public Product(string id, string code, string name, int quantity, float cost_price, float retail_price, int reorder_level, int category)
        {
            this.id = id;
            this.name = name;
            this.code = code;
            this.quantity = quantity;
            this.cost_price = cost_price;
            this.retail_price = retail_price;
            this.reorder_level = reorder_level;
            this.category = category;

        }

        // Create
        public static int AddProduct(string name, string code, int quantity, float cost_price, float retail_price, int reorder_level, int category)
        {
            try
            {
                // Opening a connection to MySql server
                string connectionString = "server=localhost;database=inventory;uid=root;pwd=prince;";
                MySqlConnection conn = new MySqlConnection(connectionString);

                conn.Open();


                // SQL Query to insert new user
                string sqlquery = "INSERT INTO `product` (`name`, `quantity`, `cost_price`, `retail_price`, `reorder_level`, `category`, `code`) VALUES (?name, ?quantity, ?cost_price, ?retail_price, ?reorder_level, ?category, ?code);";
                MySqlCommand cmd = new MySqlCommand(sqlquery, conn);
                cmd.Parameters.Add("?name", MySqlDbType.VarChar).Value = name;
                cmd.Parameters.Add("?code", MySqlDbType.VarChar).Value = code;
                cmd.Parameters.Add("?quantity", MySqlDbType.Int64).Value = quantity;
                cmd.Parameters.Add("?cost_price", MySqlDbType.Float).Value = cost_price;
                cmd.Parameters.Add("?retail_price", MySqlDbType.Float).Value = retail_price;
                cmd.Parameters.Add("?reorder_level", MySqlDbType.Int64).Value = reorder_level;
                cmd.Parameters.Add("?category", MySqlDbType.Int64).Value = category;


                cmd.ExecuteNonQuery();
                conn.Close();
                //MySqlDataReader rdr = cmd.ExecuteReader();
                //rdr.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }

            return 1;
        }

        // Read
        public static List<Product> GetProducts()
        {
            // list of Category Objects
            List<Product> products = new List<Product>();
            try
            {
                // Opening a connection to MySql server
                string connectionString = "server=localhost;database=inventory;uid=root;pwd=prince;";
                MySqlConnection conn = new MySqlConnection(connectionString);

                conn.Open();


                // SQL Query to read data in product table
                string sqlquery = "SELECT * FROM product;";
                MySqlCommand cmd = new MySqlCommand(sqlquery, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    products.Add(new Product(id:rdr[0].ToString(), code: rdr[7].ToString(),  name:rdr[1].ToString(), quantity:int.Parse(rdr[2].ToString()), cost_price:float.Parse(rdr[3].ToString()), retail_price:float.Parse(rdr[4].ToString()), reorder_level:int.Parse(rdr[5].ToString()), category:int.Parse(rdr[6].ToString())));
                }
                rdr.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return products;
            }

            return products;
        }

        // Update
        public static int UpdateProduct(int id, string name, string code, int quantity, float cost_price, float retail_price, int reorder_level, int category)
        {
            try
            {
                // Opening a connection to MySql server
                string connectionString = "server=localhost;database=inventory;uid=root;pwd=prince;";
                MySqlConnection conn = new MySqlConnection(connectionString);

                conn.Open();


                // SQL Query to update user where id=id
                string sqlquery = "UPDATE `product` SET `name` = ?name, `quantity` = ?quantity, `cost_price` = ?cost_price, `retail_price` = ?retail_price, `reorder_level` = ?reorder_level, `category` = ?category, `code` = ?code WHERE (`id` = ?id);";

                MySqlCommand cmd = new MySqlCommand(sqlquery, conn);
                cmd.Parameters.Add("?id", MySqlDbType.Int64).Value = id;
                cmd.Parameters.Add("?name", MySqlDbType.VarChar).Value = name;
                cmd.Parameters.Add("?code", MySqlDbType.VarChar).Value = code;
                cmd.Parameters.Add("?quantity", MySqlDbType.Int64).Value = quantity;
                cmd.Parameters.Add("?cost_price", MySqlDbType.Float).Value = cost_price;
                cmd.Parameters.Add("?retail_price", MySqlDbType.Float).Value = retail_price;
                cmd.Parameters.Add("?reorder_level", MySqlDbType.Int64).Value = reorder_level;
                cmd.Parameters.Add("?category", MySqlDbType.Int64).Value = category;
                cmd.ExecuteNonQuery();
                conn.Close();
                //MySqlDataReader rdr = cmd.ExecuteReader();
                //rdr.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }

            return 1;
        }

        // Delete
        public static int DeleteProduct(int id)
        {
            try
            {
                // Opening a connection to MySql server
                string connectionString = "server=localhost;database=inventory;uid=root;pwd=prince;";
                MySqlConnection conn = new MySqlConnection(connectionString);

                conn.Open();


                // SQL Query to insert new user
                string sqlquery = $"DELETE FROM `product` WHERE (`id` = ?id);";
                MySqlCommand cmd = new MySqlCommand(sqlquery, conn);
                cmd.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
                cmd.ExecuteNonQuery();
                conn.Close();


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }

            return 1;
        }
    }
}

