using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
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
            ClasseCon ClasseCon = new ClasseCon();
            ClasseCon.conexao();

            try
            {
                string sql = "server = ranking.cp2iq4siiv3a.us-east-2.rds.amazonaws.com;user = admin;pwd = 2303Simon123; database = ranking";
                MySqlConnection conn = new MySqlConnection(sql);
                DataGridView dt = new DataGridView();
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter();
                string query = "select * from rankingAtual order by pontuacao desc limit 5;";
                da.SelectCommand = new MySqlCommand(query, conn);
                DataTable data = new DataTable();
                da.Fill(data);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = data;

                dataGridView1.DataSource = bSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show("MySQL erro: " + ex);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            form.Show();
            this.Hide();
        }
    }
}
