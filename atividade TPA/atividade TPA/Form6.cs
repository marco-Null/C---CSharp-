using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade_TPA
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        public Form1 form1;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "6";
            textBox2.Text = "856";
            textBox3.Text = "482";

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        int numero = 6;

        private void button1_Click(object sender, EventArgs e)
        {
            numero++;

            textBox1.Text = numero.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            numero--;

            textBox1.Text = numero.ToString();
        }
    }
}
