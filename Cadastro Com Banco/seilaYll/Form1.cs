using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seilaYll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet1.tb_usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_usuarioTableAdapter.Fill(this.cadastroDataSet1.tb_usuario);

        }

        private void BTN_anterior_Click(object sender, EventArgs e)
        {
            bindingSource1.MovePrevious();
        }

        private void BTN_proximo_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveNext();
        }

        private void BTN_novo_Click(object sender, EventArgs e)
        {
            bindingSource1.AddNew();
        }

        private void BTN_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTN_excluir_Click(object sender, EventArgs e)
        {
            if (bindingSource1.Current == null)
            {
                MessageBox.Show("Não é prossivel deletar cadastros vazios", "Erro de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show("Quer excluir esse cadastro ?", "Confirmação de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(resultado == DialogResult.Yes)
            {
                bindingSource1.RemoveCurrent();
            }

            else
            {
                return;
            }

        }
    }
}
