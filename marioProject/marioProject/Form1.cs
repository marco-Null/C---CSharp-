using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marioProject
{
    public partial class primeiroMundo : Form
    {
        public primeiroMundo()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Interval = 16;
            timer1.Start();
            KeyPreview = true;



            foreach (Control controle in this.Controls)
            {
                if (controle is PictureBox && Convert.ToString(controle.Tag) == "bloco")
                {
                    blocos.Add((PictureBox)controle);
                }
            }
        }

        bool MarioPulando = false; 
        bool MarioAndandoDireita = false;
        bool MarioAndandoEsquerda = false; 
        bool MarioOlhandoDireita = true;

        int velocidadeDoY = 0; 
        int forcaPuloMario = -20; 
        int velocidadeMario = 10;
        int posicaoAnteriorY;
        int posicaoAnteriorX;
        

        int gravidade = 1; 

        List<PictureBox> blocos = new List<PictureBox>();




        private void primeiroMundo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void primeiroMundo_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // salva posição anterior
            posicaoAnteriorY = marioParadoPerso.Top;
            posicaoAnteriorX = marioParadoPerso.Left;

            // movimento horizontal
            if (MarioAndandoDireita)
            {
                marioParadoPerso.Left += velocidadeMario;
            }

            if (MarioAndandoEsquerda)
            {
                marioParadoPerso.Left -= velocidadeMario;
            }

            VerificarColisaoBlocosHorizontal();

            // movimento vertical
            marioParadoPerso.Top += velocidadeDoY;
            velocidadeDoY += gravidade;

            VerificarColisaoBlocosVertical();

            // parede esquerda
            if (marioParadoPerso.Left < -20)
            {
                marioParadoPerso.Left = -20;
            }
        }

        private void primeiroMundo_KeyDown(object sender, KeyEventArgs e)
        {
            // verifica se W foi apertado
            if ((e.KeyCode == Keys.W || e.KeyCode == Keys.Up) && !MarioPulando)
            {
                velocidadeDoY = forcaPuloMario;
                MarioPulando = true;
                AtualizarSprite();
            }

            // verifica se D foi apertado
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                MarioAndandoDireita = true;

                if (!MarioOlhandoDireita)
                {
                    // muda a direção da imagem do mario

                    MarioOlhandoDireita = true;
                    AtualizarSprite();


                }
            }

            // verifica se A foi apertado
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                MarioAndandoEsquerda = true;

                if (MarioOlhandoDireita)
                {

                    MarioOlhandoDireita = false;
                    AtualizarSprite();

                }
            }

        }

        private void primeiroMundo_KeyUp(object sender, KeyEventArgs e)
        {
            // mario para quando a tecla não for precionada

            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                MarioAndandoDireita = false;
            }

            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                MarioAndandoEsquerda = false;
            }
        
        }
        void AtualizarSprite()
        {
            // atualiza a direção do mario (imagem)



            if (MarioPulando)
            {
                marioParadoPerso.Image = Properties.Resources.calixtoPixelEsquerdaPNG;
            }
            else
            {
                marioParadoPerso.Image = Properties.Resources.calixtoPixelParadoPNG;
            }

            // muda a direção da imagem do mario

            if (!MarioOlhandoDireita)
            {
                marioParadoPerso.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            }

            marioParadoPerso.Refresh();
        }
        void VerificarColisaoBlocosVertical()
        {
            List<PictureBox> blocosParaRemover = new List<PictureBox>();

            foreach (PictureBox bloco in blocos)
            {
                if (marioParadoPerso.Bounds.IntersectsWith(bloco.Bounds))
                {
                    int marioBottomAnterior = posicaoAnteriorY + marioParadoPerso.Height;

                    // caiu em cima do bloco
                    if (velocidadeDoY >= 0 && marioBottomAnterior <= bloco.Top)
                    {
                        marioParadoPerso.Top = bloco.Top - marioParadoPerso.Height;
                        velocidadeDoY = 0;

                        if (MarioPulando)
                        {
                            MarioPulando = false;
                            AtualizarSprite();
                        }
                    }

                    // bateu a cabeça embaixo do bloco
                    else if (velocidadeDoY < 0 && posicaoAnteriorY >= bloco.Bottom)
                    {
                        marioParadoPerso.Top = bloco.Bottom;
                        velocidadeDoY = 2;

                        if (BlocoBatidaInterrogacao(bloco))
                        {
                            blocosParaRemover.Add(bloco);
                        }
                    }
                }
            }

            foreach (PictureBox bloco in blocosParaRemover)
            {
                blocos.Remove(bloco);
            }
        }
        void VerificarColisaoBlocosHorizontal()
        {
            foreach (PictureBox bloco in blocos)
            {
                if (marioParadoPerso.Bounds.IntersectsWith(bloco.Bounds))
                {
                    int marioRightAnterior = posicaoAnteriorX + marioParadoPerso.Width;

                    // bateu na esquerda do bloco
                    if (MarioAndandoDireita && marioRightAnterior <= bloco.Left)
                    {
                        marioParadoPerso.Left = bloco.Left - marioParadoPerso.Width;
                    }

                    // bateu na direita do bloco
                    else if (MarioAndandoEsquerda && posicaoAnteriorX >= bloco.Right)
                    {
                        marioParadoPerso.Left = bloco.Right;
                    }
                }
            }
        }

        bool BlocoBatidaInterrogacao(PictureBox bloco)
        {
            // abridor do bloco de interrogação
            if (bloco == pictureBox34 || bloco == pictureBox38 || bloco == pictureBox41 || bloco == pictureBox35 || bloco == pictureBox52 ||
                bloco == pictureBox67 || bloco == pictureBox74 || bloco == pictureBox76 || bloco == pictureBox79 || bloco == pictureBox78 ||
                bloco == pictureBox97 || bloco == pictureBox98 || bloco == pictureBox167)
            {
                bloco.Image = Properties.Resources.blocoInterrogracaoABRIDOmarioPNG;
                return false;
            }

            // quebrador do bloco quebrável de tijolos
            if (bloco == pictureBox36 || bloco == pictureBox37 || bloco == pictureBox39 || bloco == pictureBox40 || bloco == pictureBox51 ||
                bloco == pictureBox53 || bloco == pictureBox54 || bloco == pictureBox55 || bloco == pictureBox56 || bloco == pictureBox57 ||
                bloco == pictureBox58 || bloco == pictureBox59 || bloco == pictureBox60 || bloco == pictureBox61 || bloco == pictureBox62 ||
                bloco == pictureBox63 || bloco == pictureBox68 || bloco == pictureBox72 || bloco == pictureBox73 || bloco == pictureBox85 ||
                bloco == pictureBox89 || bloco == pictureBox90 || bloco == pictureBox91 || bloco == pictureBox94 || bloco == pictureBox95 ||
                bloco == pictureBox96 || bloco == pictureBox99 || bloco == pictureBox164 || bloco == pictureBox165 || bloco == pictureBox166)
            {
                bloco.Visible = false;
                return true;
            }

            return false;
        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox53_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox167_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox39_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox41_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void marioParadoPerso_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox43_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox40_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox45_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox44_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox46_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox47_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox42_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox229_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox230_Click(object sender, EventArgs e)
        {

        }
    }
    
}
