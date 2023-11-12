using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaPhe.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        private string connectionSTR = @"Data Source=DESKTOP-5V50FAS;Initial Catalog=QuanLyQuanCaPheNTN;Integrated Security=True";

        public static DataProvider Instance 
        {
            get
            {
                if(instance == null)
                {
                    instance = new DataProvider();
                }
                return DataProvider.instance;
            }

            private set
            {
                DataProvider.instance = value;
            } 
        }

        private DataProvider() { }

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {

            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {

                connection.Open();

                SqlCommand sqlCommand = new SqlCommand(query, connection);

               if(parameter != null)
                {
                    string[] listPara = query.Split(' ');

                    int i = 0;

                    foreach (string item in listPara)
                    {
                        if(item.Contains('@'))
                        {
                            sqlCommand.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }

                }

                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

                adapter.Fill(dataTable);

                connection.Close();
            }
            
            return dataTable;
        }

        public int ExecuteNoneQuery(string query, object[] parameter = null)
        {
            int dataTable = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {

                connection.Open();

                SqlCommand sqlCommand = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');

                    int i = 0;

                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            sqlCommand.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }

                }

                dataTable = sqlCommand.ExecuteNonQuery();

                connection.Close();
            }

            return dataTable;
        }

        public object ExecuteScalar (string query, object[] parameter = null)
        {

            object dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {

                connection.Open();

                SqlCommand sqlCommand = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');

                    int i = 0;

                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            sqlCommand.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }

                }

                dataTable = sqlCommand.ExecuteScalar();

                connection.Close();
            }

            return dataTable;
        }

        public static bool ExecuteNonQuery(string query, SqlConnection connection)
        {
            try
            {
                using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                {
                    connection.Open();
                    sqlCommand.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
