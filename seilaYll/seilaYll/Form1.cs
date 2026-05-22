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
    }
}
