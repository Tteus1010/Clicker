using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clickre.Properties;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;

namespace clickre
{
    public partial class Form5 : Form
    {
        public string nome = " ";
        public string resultvar;

        public Form5(string result)
        {
            InitializeComponent();
            resultvar = result;
            label2.Text = resultvar;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "server = localhost;user = root;pwd = 12345678; database = ranking";
            MySqlConnection conn = new MySqlConnection(sql);
            try
            {
                conn.Open();
                nome = textBox1.Text;
                string query = "insert into rankingatual(nome, pontuacao) Values('" + nome + "', " + resultvar + ")";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro" + ex);
            }

            Form2 form = new Form2();
            form.Show();
            conn.Close();
            this.Hide();
        }
    }
}
