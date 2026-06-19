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
            desabilitaEdicao();
        }

        public void habilitaEdicao()
        {

            TXT_nome.Enabled = false;
            TXT_nivel.Enabled = false;
            TXT_login.Enabled = false;
            TXT_senha.Enabled = false;

            BTN_alterar.Enabled = true;
            BTN_anterior.Enabled = true;
            BTN_excluir.Enabled = true;
            BTN_imprimir.Enabled = true;
            BTN_novo.Enabled = true;
            BTN_proximo.Enabled = true;
            BTN_anterior.Enabled = true;
            BTN_sair.Enabled = true;
            BTN_pesquisar.Enabled = true;
            BTN_salvar.Enabled = false;
            BTN_cancelar.Enabled = false;
        }

        public void desabilitaEdicao()
        {
            TXT_nome.Enabled = true;
            TXT_nivel.Enabled = true;
            TXT_login.Enabled = true;
            TXT_senha.Enabled = true;

            BTN_alterar.Enabled = false;
            BTN_anterior.Enabled = false;
            BTN_excluir.Enabled = false;
            BTN_imprimir.Enabled = false;
            BTN_novo.Enabled = false;
            BTN_proximo.Enabled = false;
            BTN_anterior.Enabled = false;
            BTN_pesquisar.Enabled = false;
            BTN_sair.Enabled = true;
            BTN_salvar.Enabled = true;
            BTN_cancelar.Enabled = true;

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

        private void TXT_codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTN_pesquisar_Click(object sender, EventArgs e)
        {
            FrnPesquisa pesquisa = new FrnPesquisa();

            pesquisa.Show();
        }

        private void BTN_salvar_Click(object sender, EventArgs e)
        {
            habilitaEdicao();
        }
    }
}
