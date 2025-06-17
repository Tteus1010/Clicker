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
    public partial class Congrats : Form
    {
        public string nome = " ";
        public string resultvar;

        public Congrats(string result)
        {
            InitializeComponent();
            resultvar = result;
            label2.Text = resultvar;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "server = ranking.cp2iq4siiv3a.us-east-2.rds.amazonaws.com;user = admin;pwd = 2303Simon123; database = ranking";
            MySqlConnection conn = new MySqlConnection(sql);
            try
            {
                conn.Open();
                nome = textBox1.Text;
                string query = "insert into rankingAtual(nome, pontuacao) Values('" + nome + "', " + resultvar + ")";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro" + ex);
            }

            Menu form = new Menu();
            form.Show();
            conn.Close();
            this.Hide();
        }
    }
}
