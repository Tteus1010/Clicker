using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clickre.Properties;

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
            nome = textBox1.Text; 
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }
        private void ranking(object sender, EventArgs e)
        {

        }
        private void salvartxt(object sender, EventArgs e)
        {
            string final = nome + " " + resultvar;
        }
    }
}
