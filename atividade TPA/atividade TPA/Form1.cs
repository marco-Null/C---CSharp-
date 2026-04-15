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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void navMinecraft_Click(object sender, EventArgs e)
        {

        }

        bool usandoJAVA = true;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (usandoJAVA)
            {
                comboBoxJavaVersion.Enabled = true;
                usandoJAVA = false;
            }
            else
            {
                comboBoxJavaVersion.Enabled=false;
                usandoJAVA = true;
                comboBoxJavaVersion.Text = null;
            }
        }

        private void CarregarSkinButton_Click(object sender, EventArgs e)
        {
            if (SkinImage.Visible == true)
            {
                SkinImage.Visible = false;
            }
            else
            {
                SkinImage.Visible = true;
            }
        }

        bool usandoSteve = true;

        private void trocarSkinButtom_Click(object sender, EventArgs e)
        {
            if (usandoSteve) {
                SkinImage.Image = Properties.Resources.alex_png;
                usandoSteve = false;
            }
            else
            {
                SkinImage.Image = Properties.Resources.steve_png;
                usandoSteve = true;
            }
        }

        bool usandoBED = true;
        private void radioButtonBedrock_CheckedChanged(object sender, EventArgs e)
        {
            if (usandoBED)
            {
                comboBoxBedrockVersion.Enabled = true;
                usandoBED = false;
            }
            else
            {
                comboBoxBedrockVersion.Enabled = false;
                usandoBED = true;
                comboBoxBedrockVersion.Text = null;
            }
        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            progressoJogo.Value = 0;
            tempo.Start();
        }

        private void tempo_Tick(object sender, EventArgs e)
        {
            if (progressoJogo.Value < 100)
            {
                progressoJogo.Value += 1;
            }
            else
            {
                tempo.Stop();

                Form2 tela = new Form2();

                tela.Show();

                tela.FormClosed += (s, args) =>
                {
                    this.Show();

                    progressoJogo.Value = 0;
                };

                this.Hide();


            }

        }

        private void EntrarNav_Click(object sender, EventArgs e)
        {
            Form3 entrar = new Form3();
            entrar.form1 = this;
            entrar.Show();


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void nomeDoUsuarioTexto_Click(object sender, EventArgs e)
        {

        }

        private void CriarContaNav_Click(object sender, EventArgs e)
        {
            Form4 entrar = new Form4();
            entrar.form1 = this;
            entrar.Show();
        }

        private void configuraçõesButton_Click(object sender, EventArgs e)
        {
            Form6 configuracoes = new Form6();
            configuracoes.form1 = this;
            configuracoes.Show();
        }

        private void SobreButtom_Click(object sender, EventArgs e)
        {
            Form7 Sobre = new Form7();
            Sobre.form1 = this;
            Sobre.Show();
        }
    }
}
