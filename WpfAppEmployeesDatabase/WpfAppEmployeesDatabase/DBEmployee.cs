using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace MySqlCRUD
{

    class DBEmployee
    {
        public static MySqlConnection GetConnection()
        {
            string sql = @"server = localhost; user id = root;;password=25101991; database = company";
            MySqlConnection conn = new MySqlConnection(sql);
            try
            {
                conn.Open();

            }
            catch (Exception e)
            {
                //MessageBox.Show("Mysql connection erreur"+e.Message+"\n Erreur"+MessageBoxButtons.OK+ MessageBoxIcon.Erreur);
                Console.WriteLine("Error: {0}", e.ToString());
            }
          
            return conn;
        }



        public List<Employee> GetAll()
        {
            var employees = new List<Employee>();

            string sql = @"server = localhost; user id = root;;password=25101991; database = company";
            MySqlConnection conn = new MySqlConnection(sql);
             conn.Open();
            string query = "SELECT * FROM employee;";

            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);

            DataSet ds = new DataSet();
            da.Fill(ds, "employee");
            DataTable dt = ds.Tables["employee"];

            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn col in dt.Columns)
                {
                    Console.Write(row[col] + "\t");
                }

                Console.Write("\n");
            }

        }
    }
