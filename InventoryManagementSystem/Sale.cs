using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    internal class Sale
    {
        public int id;
        public string product_code;
        public int quantity;
        public string date;

        public Sale(int id, string product_code, int quantity, string date)
        {
            this.id = id;
            this.product_code = product_code;
            this.quantity = quantity;
            this.date = date;
        }


        // Create
        public static int AddSale(Dictionary<string, int> basket)
        {
            try
            {
                DateTime date_now = DateTime.Now;

                // Opening a connection to MySql server
                string connectionString = "server=localhost;database=inventory;uid=root;pwd=@Nanahemaaml7;";
                MySqlConnection conn = new MySqlConnection(connectionString);

                conn.Open();

                for (int i = 0; i < basket.Count; i++)
                {
                    string product_code = basket.Keys.ElementAt(i);
                    int quantity = basket[product_code];

                    // SQL Query to insert new user
                    string sqlquery = $"INSERT INTO `sale` (`product`, `quantity`, `date`) VALUES (?product_code, ?quantity, ?date_now);";
                    MySqlCommand cmd = new MySqlCommand(sqlquery, conn);
                    cmd.Parameters.Add("?product_code", MySqlDbType.VarChar).Value = product_code;
                    cmd.Parameters.Add("?quantity", MySqlDbType.Int32).Value = quantity;
                    cmd.Parameters.Add("?date_now", MySqlDbType.DateTime).Value = date_now;

                    cmd.ExecuteNonQuery();
                }



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
        public static List<Sale> GetSales()
        {
            // list of Category Objects
            List<Sale> sales = new List<Sale>();
            try
            {
                // Opening a connection to MySql server
                string connectionString = "server=localhost;database=inventory;uid=root;pwd=@Nanahemaaml7;";
                MySqlConnection conn = new MySqlConnection(connectionString);

                conn.Open();


                // SQL Query to insert new category
                string sqlquery = "SELECT * FROM sale;";
                MySqlCommand cmd = new MySqlCommand(sqlquery, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    sales.Add(new Sale(int.Parse(rdr[0].ToString()), rdr[1].ToString(), int.Parse(rdr[2].ToString()), rdr[3].ToString()));
                }
                rdr.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return sales;
            }

            return sales;
        }

        // Update
        public static int UpdateCategory(int id, string name)
        {
            try
            {
                // Opening a connection to MySql server
                string connectionString = "server=localhost;database=inventory;uid=root;pwd=@Nanahemaaml7;";
                MySqlConnection conn = new MySqlConnection(connectionString);

                conn.Open();


                // SQL Query to update user where id=id
                string sqlquery = "UPDATE `category` SET `name` = ?name WHERE (`id` = ?id);";

                MySqlCommand cmd = new MySqlCommand(sqlquery, conn);
                cmd.Parameters.Add("?name", MySqlDbType.VarChar).Value = name;
                cmd.Parameters.Add("?id", MySqlDbType.Int64).Value = id;
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
        public static int DeleteSale(int id)
        {
            try
            {
                // Opening a connection to MySql server
                string connectionString = "server=localhost;database=inventory;uid=root;pwd=@Nanahemaaml7;";
                MySqlConnection conn = new MySqlConnection(connectionString);

                conn.Open();


                // SQL Query to insert new user
                string sqlquery = $"DELETE FROM `sale` WHERE (`id` = ?id);";
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

