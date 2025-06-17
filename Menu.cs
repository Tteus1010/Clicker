using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clickre
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clicker form = new Clicker();
            this.Hide();
            form.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            this.Hide();
            form.Show();
        }
    }
}
