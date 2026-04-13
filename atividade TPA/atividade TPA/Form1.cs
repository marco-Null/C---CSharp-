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
    }
}
