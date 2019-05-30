using System;
using System.Collections.Generic;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace subd_couse_work
{
    class DbManager
    {
        private static MySqlConnection connection;
        private string connectionString;

        public DbManager() {
            StreamReader fs = new StreamReader("db_credentials.cn", Encoding.ASCII);

            string username = fs.ReadLine();

            string password = fs.ReadLine();

            connectionString = string.Format("datasource=127.0.0.1;port=3306;username={0};password={1};database=DiscographyManagerDB;", username, password);

            connection = new MySqlConnection(connectionString);

            connection.Open();

            connection.Close();
        }

        public static class Songs{
            public static DataRow Find(int id)
            {
                connection.Open();

                MySqlCommand sqlCmd = new MySqlCommand("Select * From Songs Where Id = @id", connection);

                sqlCmd.Parameters.AddWithValue("@id", id);

                MySqlDataAdapter da = new MySqlDataAdapter(sqlCmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                connection.Close();

                return dt.Rows[0];
            }

            public static void Insert(params string[] query)
            {
                connection.Open();

                MySqlCommand sqlCmd = new MySqlCommand("Insert Into Users (Name) Values (@name)", connection);

                var list = new List<string>();

                sqlCmd.Parameters.AddWithValue("@name", query[0]);

                sqlCmd.ExecuteNonQuery();

                connection.Close();
            }

            public static void Update(int id, params string[] query)
            {
                connection.Open();

                MySqlCommand sqlCmd = new MySqlCommand("Update Users Name = @name Where Id = @id", connection);

                sqlCmd.Parameters.AddWithValue("@id", id);
                sqlCmd.Parameters.AddWithValue("@name", query[0]);

                sqlCmd.ExecuteNonQuery();

                connection.Close();
            }
        }

        public static class Discographies {

        }

        public static class Users {
            public static DataRow Find(int id) {
                connection.Open();

                MySqlCommand sqlCmd = new MySqlCommand("Select * From Users Where Id = @id", connection);

                sqlCmd.Parameters.AddWithValue("@id", id);

                MySqlDataAdapter da = new MySqlDataAdapter(sqlCmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                connection.Close();

                return dt.Rows[0];
            }

            public static DataTable Where(Dictionary<string,string> dict) {
                connection.Open();

                StringBuilder sb = new StringBuilder();

                sb.Append("Select * From Users Where ");

                int counter = 0;

                foreach (var obj in dict) {
                    sb.Append(obj.Key + "=" + string.Concat("@" + obj.Key));

                    if (counter < dict.Count - 1) {
                        sb.Append(" And ");
                    }

                    counter++;
                }

                sb.Append(";");

                MySqlCommand sqlCmd = new MySqlCommand(sb.ToString(), connection);

                foreach (var obj in dict) {
                    sqlCmd.Parameters.AddWithValue(string.Concat("@", obj.Key), obj.Value.ToString());
                }

                MySqlDataAdapter da = new MySqlDataAdapter(sqlCmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                connection.Close();

                return dt;
            }

            public static void Insert(Dictionary<string, string> dict) {
                connection.Open();

                StringBuilder sb = new StringBuilder();

                sb.Append("Insert Into Users (");

                int counter = 0;

                foreach (var obj in dict)
                {
                    sb.Append(obj.Key);

                    if (counter < dict.Count - 1){
                        sb.Append(", ");
                    }

                    counter++;
                }

                sb.Append(") Values ( ");

                counter = 0;

                foreach (var obj in dict)
                {
                    sb.Append("@" + obj.Key);

                    if (counter < dict.Count - 1)
                    {
                        sb.Append(", ");
                    }

                    counter++;
                }

                sb.Append(");");

                MySqlCommand sqlCmd = new MySqlCommand(sb.ToString(), connection);

                foreach (var obj in dict)
                {
                    sqlCmd.Parameters.AddWithValue(string.Concat("@", obj.Key), obj.Value.ToString());
                }

                sqlCmd.ExecuteNonQuery();

                connection.Close();
            }

            public static void Update(int id, Dictionary<string, string> dict) {
                connection.Open();

                StringBuilder sb = new StringBuilder();

                sb.Append("Update Users Set ");

                int counter = 0;

                foreach (var obj in dict)
                {
                    sb.Append(obj.Key + "=" + string.Concat("@" + obj.Key));

                    if (counter < dict.Count - 1)
                    {
                        sb.Append(", ");
                    }

                    counter++;
                }

                sb.Append(" Where Id = @id;");

                MySqlCommand sqlCmd = new MySqlCommand(sb.ToString(), connection);

                sqlCmd.Parameters.AddWithValue("@id", id);

                foreach (var obj in dict)
                {
                    sqlCmd.Parameters.AddWithValue(string.Concat("@", obj.Key), obj.Value.ToString());
                }

                sqlCmd.ExecuteNonQuery();

                connection.Close();
            }
        }

    }
}
