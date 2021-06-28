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
    public partial class addc : Form
    {
        public addc()
        {
            InitializeComponent();
        }

        private void addch_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;userid=root;database=ppractik";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();//соединение с бд

            MySqlCommand command = new MySqlCommand($"insert into childbook (`id книги`, `Фамилия`, `Имя`, `Отчество`, `Название книги`) values ('{id2.Text}', '{c1.Text}', '{c2.Text}', '{c3.Text}', '{c4.Text}')")
            {
                Connection = connection//команда для заполнения
            };
            command.ExecuteNonQuery();//выполнение команды
            MessageBox.Show("Книга успешно добавлена.Библиотека обновлена.");
            Log.Logger("Книга добавлена в детский раздел");
            Form1 qwer = new Form1();
            this.Hide();
            qwer.Show();
        }
    }
}
