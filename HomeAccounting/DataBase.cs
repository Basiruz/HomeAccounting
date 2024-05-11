using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace HomeAccounting
{
    internal class DataBase
    {
        private MySqlDataAdapter dataAdapter;
        private DataSet dataSet;
        private MySqlConnection connection;

        public DataBase()
        {
            // Initialize connection
            string connectionString = "server=localhost;port=3306;user=root;password=root;database=accounting";
            connection = new MySqlConnection(connectionString);
        }

        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
        }

        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }

        public void LoadData(DataGridView dataGridView)
        {
            try
            {
                openConnection();
                string query = "SELECT * FROM accounting";
                dataAdapter = new MySqlDataAdapter(query, connection);
                dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "accounting");
                dataGridView.DataSource = dataSet.Tables["accounting"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }
    }
}

