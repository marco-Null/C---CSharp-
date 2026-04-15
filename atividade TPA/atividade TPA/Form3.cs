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
            this.Close();

            form1.EntrarNav.Visible = false;
            form1.CriarContaNav.Visible = false;

            form1.nomeDoUsuarioTexto.Visible = true;
            form1.ImagemUsuario.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var nomeUsuario = textBox1.Text;

            form1.nomeDoUsuarioTexto.Text = nomeUsuario;

            form1.comboBoxUsuarioName.Text = nomeUsuario;
        }
    }
}
