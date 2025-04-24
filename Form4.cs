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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace clickre
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string sql = "server = localhost;user = root;pwd = 12345678; database = ranking";
            MySqlConnection conn = new MySqlConnection(sql);
            try
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter();
                string query = "select * from rankingatual order by pontuacao desc limit 5;";
                da.SelectCommand = new MySqlCommand(query, conn);
                

                DataTable data = new DataTable();
                da.Fill(data);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = data;

                dataGridView1.DataSource = bSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro" + ex);
            }
            DataGridView dt = new DataGridView();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }
    }
}
