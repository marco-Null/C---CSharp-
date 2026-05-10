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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public Form1 form1;

        private void button1_Click(object sender, EventArgs e)
        {

            form1.EntrarNav.Visible = false;
            form1.CriarContaNav.Visible = false;

            form1.nomeDoUsuarioTexto.Visible = true;
            form1.ImagemUsuario.Visible = true;

            form1.AtualizarBotoesQuandoEntrarOrCriar();

            this.Close();
        }

        private void VerificadorCampos()
        {
            button1.Enabled = !string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            VerificadorCampos();

            var nomeUsuario = textBox1.Text;

            form1.nomeDoUsuarioTexto.Text = nomeUsuario;

            form1.comboBoxUsuarioName.Text = nomeUsuario;

            if (textBox1.Text.Length <= 5)
            {
                form1.nomeDoUsuarioTexto.Location = new Point(930, 31);
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            VerificadorCampos();
        }
    }
}
