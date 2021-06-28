using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ppractic2
{
    public partial class addchild : Form
    {
        public addchild()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                            if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(delete.Text))
                            {
                                dataGridView1.Rows[i].Selected = true;
                                break;
                            }
                }

            }
            catch
            {
                MessageBox.Show("Введите значение");
            }
        }

    

        private void delete_TextChanged(object sender, EventArgs e)
        {

        }

        private void addchild_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ppractikDataSet1.childbook". При необходимости она может быть перемещена или удалена.
            this.childbookTableAdapter.Fill(this.ppractikDataSet1.childbook);

        }

        private void add_Click(object sender, EventArgs e)
        {
            addc qer = new addc();
            this.Hide();
            qer.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;userid=root;database=ppractik";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();//соединение с бд

            MySqlCommand command1 = new MySqlCommand("DELETE FROM `childbook` where `id книги` =@id", connection);
            command1.Parameters.Add("@id", MySqlDbType.Int32).Value = Convert.ToInt32(delete.Text);
            command1.ExecuteNonQuery();//выполнение команды
            MessageBox.Show("Книга удалена успешно", "Информация");
            Log.Logger("Книга удалена из детского раздела");
            connection.Close();
            Form1 sc = new Form1();
            sc.Show();
            this.Hide();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
            Log.Logger("Закрытие программы");
        }
    }
}
