using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeAccounting
{
    public partial class Form8 : Form
    {
        private readonly string connectionString = "server=localhost;port=3306;user=root;password=root;database=accounting";
        private DataGridView dataGridView1; // Добавлен элемент управления DataGridView
        public Form8()
        {
            InitializeComponent();
            InitializeDataGridView(); // Инициализация DataGridView
            this.Load += Form8_Load;
        }
        private void Form8_Load(object sender, EventArgs e)
        {

        }
        private void InitializeDataGridView()
        {
            dataGridView1 = new DataGridView();
            dataGridView1.Dock = DockStyle.Fill;
            this.Controls.Add(dataGridView1); // Добавление DataGridView на форму
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string category = categoryField.Text;
            string summ = summField.Text;
            string comment = commentField.Text;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO `food` (`Категория`, `Сумма`, `Комментарий`) VALUES (@cat, @sum, @com)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@cat", category);
                command.Parameters.AddWithValue("@sum", summ);
                command.Parameters.AddWithValue("@com", comment);

                connection.Open();

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Успешно добавлено");
                }
                else
                {
                    MessageBox.Show("Не удалось добавить");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM `food`";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridView1.DataSource = table; // Установка источника данных для DataGridView
                }
            }
        }
    }
}
