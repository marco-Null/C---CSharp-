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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public Form1 form1;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            form1.EntrarNav.Visible = false;
            form1.CriarContaNav.Visible = false;

            form1.nomeDoUsuarioTexto.Visible = true;
            form1.ImagemUsuario.Visible = true;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            var nomeUsuario = textBox1.Text;


            if (!string.IsNullOrEmpty(textBox2.Text) &&
        textBox2.Text == textBox3.Text)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }

            form1.nomeDoUsuarioTexto.Text = nomeUsuario;

            if (textBox1.Text.Length <= 5)
            {
                form1.nomeDoUsuarioTexto.Location = new Point (930, 31);
            }

            else if (textBox1.Text.Length <= 7)
            {
                form1.nomeDoUsuarioTexto.Location = new Point(920, 31);
            }

            else if (textBox1.Text.Length <= 9)
            {
                form1.nomeDoUsuarioTexto.Location = new Point(910, 31);
            }

            else if (textBox1.Text.Length <= 11)
            {
                form1.nomeDoUsuarioTexto.Location = new Point(900, 31);
            }

            else if (textBox1.Text.Length <= 13)
            {
                form1.nomeDoUsuarioTexto.Location = new Point(890, 31);
            }

            else if (textBox1.Text.Length <= 15)
            {
                form1.nomeDoUsuarioTexto.Location = new Point(880, 31);
            }

            else
            {
                form1.nomeDoUsuarioTexto.Location = new Point(875, 31);
            }


        }
    }
}
