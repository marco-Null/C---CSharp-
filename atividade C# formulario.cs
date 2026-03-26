using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Foto.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox6.Enabled = true;
            }
            else
            {
                textBox6.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox7.Enabled = true;
            }
            else
            {
                textBox7.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                textBox8.Enabled = true;
            }
            else
            {
                textBox8.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "12345";
            textBox2.Text = "Marco antonio";
            textBox3.Text = "casa";
            textBox4.Text = "123-456-789-10";
            textBox5.Text = "99 9999-9999";
            textBox9.Text = "1234567";
            textBox10.Text = "1234";
            textBox11.Text = "rua nao sei";
            textBox12.Text = "bairro infinito";
            textBox13.Text = "são paulo";
            textBox6.Text = "blablabla@gmail.com.br";
            textBox7.Text = "slasla@gmail.com";
            textBox8.Text = "ondeOnde@gmail.com";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Foto.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
             if (string.IsNullOrEmpty(textBox1.Text))
    {
        MessageBox.Show("Nenhum nome está no cadastro!", "Aviso",
        MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
    else if (string.IsNullOrEmpty(textBox2.Text))
    {
        MessageBox.Show("Nenhum nome está no cadastro!", "Aviso",
        MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
    else if (string.IsNullOrEmpty(textBox3.Text))
    {
        MessageBox.Show("Nenhum nome está no cadastro!", "Aviso",
        MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
    else if (string.IsNullOrEmpty(textBox4.Text))
    {
        MessageBox.Show("Nenhum nome está no cadastro!", "Aviso",
        MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
    else if (string.IsNullOrEmpty(textBox5.Text))
    {
        MessageBox.Show("Nenhum nome está no cadastro!", "Aviso",
        MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
    else if (string.IsNullOrEmpty(textBox6.Text))
    {
        MessageBox.Show("Nenhum nome está no cadastro!", "Aviso",
        MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
    else if (string.IsNullOrEmpty(textBox7.Text))
    {
        MessageBox.Show("Nenhum nome está no cadastro!", "Aviso",
        MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
    else if (string.IsNullOrEmpty(textBox8.Text))
    {
        MessageBox.Show("Nenhum nome está no cadastro!", "Aviso",
        MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
    else if (string.IsNullOrEmpty(textBox9.Text))
    {
        MessageBox.Show("Nenhum nome está no cadastro!", "Aviso",
        MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
    else if (string.IsNullOrEmpty(textBox10.Text))
    {
        MessageBox.Show("Nenhum nome está no cadastro!", "Aviso",
        MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
    else if (string.IsNullOrEmpty(textBox11.Text))
    {
        MessageBox.Show("Nenhum nome está no cadastro!", "Aviso",
        MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
    else if (string.IsNullOrEmpty(textBox12.Text))
    {
        MessageBox.Show("Nenhum nome está no cadastro!", "Aviso",
        MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
    else if (string.IsNullOrEmpty(textBox13.Text))
    {
        MessageBox.Show("Nenhum nome está no cadastro!", "Aviso",
        MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    else
    {
        string mensagem = "Dados do Cadastro:\n\n" +
                  "Codigo: " + textBox1.Text + "\n" +
                  "Nome: " + textBox2.Text + "\n" +
                  "RG: " + textBox3.Text + "\n" +
                  "CPF: " + textBox4 + "\n" +
                  "Telefone Residencia: " + textBox5 + "\n" +
                  "CEP: " + textBox6.Text + "\n" +
                  "Logradouro: " + textBox8.Text + "\n" +
                  "Numero: " + textBox7.Text + "\n" +
                  "Bairro: " + textBox9.Text + "\n" +
                  "Cidade: " + textBox10.Text + "\n" +
                  "E-mail: " + textBox11.Text + "\n" +
                  "Facebook: " + textBox13.Text + "\n" +
                  "Twitter: " + textBox12.Text;


        MessageBox.Show(mensagem, "Consulta",
        MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
