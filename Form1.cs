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
   
    public partial class Form1 : Form
    {
        public string result;
        bool timerrun = false;
        int Timer = 10;
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            textBox1.Text = count.ToString();
            if (Timer == 0)
            {
                result = textBox1.Text;
                Form5 form = new Form5(result);
                form.Show();
                this.Hide();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Timer > 0)
            {
                Timer -=1 ;
                if(Timer > 10)
                {
                    label1.Text = Timer + " S";
                }
                else
                {
                    label1.Text = "0" + Timer + " S";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
