using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;
using System.Globalization;
using System.IO;
using System.Reflection;

namespace marioProject
{
    public partial class primeiroMundo : Form
    {
        WindowsMediaPlayer musicaFundo;
        WindowsMediaPlayer MarioPulandoEffect;
        WindowsMediaPlayer MarioPerdeuEffect;
        WindowsMediaPlayer MarioDescendoEffect;
        WindowsMediaPlayer MarioFaseConcluEffect;
        WindowsMediaPlayer MarioQuebrandoTijoloEffect;
        WindowsMediaPlayer InimigoMortoEffect;

        List<Musica> listaDeMusicas = new List<Musica>();

        string arquivoMp3;
        string MarioPulandoSOM;
        string MarioPerdeuSom;
        string MarioDescendoSom;
        string MarioFaseConcluidaSOM;
        string MarioQuebrandoTijoloSom;
        string InimigoMortoSom;

        private string ExtrairSom(string nomeArquivo)
        {
            string caminhoTemp = Path.Combine(Path.GetTempPath(), nomeArquivo);

            if (!File.Exists(caminhoTemp))
            {
                var assembly = Assembly.GetExecutingAssembly();

                string recurso = assembly.GetManifestResourceNames()
                    .First(x => x.EndsWith("sonsMario." + nomeArquivo));

                using (Stream stream = assembly.GetManifestResourceStream(recurso))
                using (FileStream file = new FileStream(caminhoTemp, FileMode.Create, FileAccess.Write))
                {
                    stream.CopyTo(file);
                }
            }

            return caminhoTemp;
        }

        public primeiroMundo()
        {
            InitializeComponent();

            arquivoMp3 = ExtrairSom("musicaFundoMario.mp3");
            MarioPulandoSOM = ExtrairSom("somPularMario.wav");
            MarioPerdeuSom = ExtrairSom("MusicaMarioMorreu.wav");
            MarioDescendoSom = ExtrairSom("DecendoABandeiraSom.wav");
            MarioFaseConcluidaSOM = ExtrairSom("MusicaFaseTerminada.wav");
            MarioQuebrandoTijoloSom = ExtrairSom("quebrarTijolosSom.wav");
            InimigoMortoSom = ExtrairSom("pisandoInimigosSom.wav");

            timer1.Enabled = true;
            timer1.Interval = 16;
            timer1.Start();
            KeyPreview = true;

            musicaFundo = new WindowsMediaPlayer();
            MarioPulandoEffect = new WindowsMediaPlayer();
            MarioPerdeuEffect = new WindowsMediaPlayer();
            MarioDescendoEffect = new WindowsMediaPlayer();
            MarioFaseConcluEffect = new WindowsMediaPlayer();
            MarioQuebrandoTijoloEffect = new WindowsMediaPlayer();
            InimigoMortoEffect = new WindowsMediaPlayer();

            musicaFundo.URL = arquivoMp3;
            musicaFundo.settings.setMode("loop", true);
            musicaFundo.controls.play();



            foreach (Control controle in this.Controls)
            {
                if (controle is PictureBox && Convert.ToString(controle.Tag) == "bloco")
                {
                    blocos.Add((PictureBox)controle);
                }
            }
        }

        private void MarioPularSom(string arquivo)
        {
            MarioPulandoEffect.URL = arquivo;
            MarioPulandoEffect.controls.stop();
            MarioPulandoEffect.controls.currentPosition = 0;
            MarioPulandoEffect.settings.volume = 100;
            MarioPulandoEffect.controls.play();
        }

        private void MarioMorrendoSom(string arquivo)
        {
            MarioPerdeuEffect.URL = arquivo;
            MarioPerdeuEffect.controls.stop();
            MarioPerdeuEffect.controls.currentPosition = 0;
            MarioPerdeuEffect.settings.volume = 100;
            MarioPerdeuEffect.controls.play();
        }

        private void MarioDescendoBandeiraSom(string arquivo)
        {
            MarioDescendoEffect.URL = arquivo;
            MarioDescendoEffect.controls.stop();
            MarioDescendoEffect.controls.currentPosition = 0;
            MarioDescendoEffect.settings.volume = 100;
            MarioDescendoEffect.controls.play();
        }

        private void MarioTerminandoFaseSom(string arquivo)
        {
            MarioFaseConcluEffect.URL = arquivo;
            MarioFaseConcluEffect.controls.stop();
            MarioFaseConcluEffect.controls.currentPosition = 0;
            MarioFaseConcluEffect.settings.volume = 100;
            MarioFaseConcluEffect.controls.play();
        }

        private void SomQuebrarTijolo(string arquivo)
        {
            MarioQuebrandoTijoloEffect.URL = arquivo;
            MarioQuebrandoTijoloEffect.controls.stop();
            MarioQuebrandoTijoloEffect.controls.currentPosition = 0;
            MarioQuebrandoTijoloEffect.settings.volume = 100;
            MarioQuebrandoTijoloEffect.controls.play();
        }

        private void InimigoSendoMortoSOM(string arquivo)
        {
            InimigoMortoEffect.URL = arquivo;
            InimigoMortoEffect.controls.stop();
            InimigoMortoEffect.controls.currentPosition = 0;
            InimigoMortoEffect.settings.volume = 100;
            InimigoMortoEffect.controls.play();
        }

        bool MarioPulando = false; 
        bool MarioAndandoDireita = false;
        bool MarioAndandoEsquerda = false; 
        bool MarioOlhandoDireita = true;
        bool esperandoAnimacaoMorte = false;
        bool MarioMorto = false;
        bool vitoriaMario = false;
        bool decendoBandeira = false;
        bool entrandoCastelo = false;


        


        // -------------- calixtos npc's ----------------

        int velocidadeCalixto = 3;
        int velocidadeCalixto2 = 3;
        int velocidadeCalixto3 = 3;
        int velocidadeCalixto4 = 3;
        int velocidadeCalixto5 = 3;
        int velocidadeCalixto6 = 3;
        int velocidadeCalixto7 = 3;
        int velocidadeCalixto8 = 3;

        int velocidadeOswaldo1 = 5;
        int velocidadeOswaldo2 = 5;
        int pulosCabecaOswaldo1 = 0;
        int pulosCabecaOswaldo2 = 0;

        // calixto 1
        bool CalixtoAndandoDireita = true;
        bool CalixtoAndandoEsquerda = false;
        bool CalixtoOlhandoDireita = true;
        bool CalixtoVivo = true;

        // calixto 2
        bool CalixtoAndandoDireita2 = true;
        bool CalixtoAndandoEsquerda2 = false;
        bool CalixtoOlhandoDireita2 = true;
        bool CalixtoVivo2 = true;

        // calixto 3
        bool CalixtoAndandoDireita3 = true;
        bool CalixtoAndandoEsquerda3 = false;
        bool CalixtoOlhandoDireita3 = true;
        bool CalixtoVivo3 = true;

        // calixto 4
        bool CalixtoAndandoDireita4 = true;
        bool CalixtoAndandoEsquerda4 = false;
        bool CalixtoOlhandoDireita4 = true;
        bool CalixtoVivo4 = true;

        // calixto 5
        bool CalixtoAndandoDireita5 = true;
        bool CalixtoAndandoEsquerda5 = false;
        bool CalixtoOlhandoDireita5 = true;
        bool CalixtoVivo5 = true;

        // calixto 6
        bool CalixtoAndandoDireita6 = true;
        bool CalixtoAndandoEsquerda6 = false;
        bool CalixtoOlhandoDireita6 = true;
        bool CalixtoVivo6 = true;

        // calixto 7
        bool CalixtoAndandoDireita7 = true;
        bool CalixtoAndandoEsquerda7 = false;
        bool CalixtoOlhandoDireita7 = true;
        bool CalixtoVivo7 = true;

        // calixto 8
        bool CalixtoAndandoDireita8 = true;
        bool CalixtoAndandoEsquerda8 = false;
        bool CalixtoOlhandoDireita8 = true;
        bool CalixtoVivo8 = true;

        // oswaldo 1
        bool OswaldoAndandoDireita1 = true;
        bool OswaldoAndandoEsquerda1 = false;
        bool OswaldoOlhandoDireita1 = true;
        bool OswaldoVivo1 = true;

        // oswaldo 2
        bool OswaldoAndandoDireita2 = true;
        bool OswaldoAndandoEsquerda2 = false;
        bool OswaldoOlhandoDireita2 = true;
        bool OswaldoVivo2 = true;

        // -----------------------------------------------


        int forcaPuloMario = -18; 
        int velocidadeMario = 8;
        int velocidadeAumentadaMario = 0;

        int posicaoAnteriorY;
        int posicaoAnteriorX;
        int velocidadeDoY = 0;

        int gravidade = 1;
        int tempoDeFim = 0;





        List<PictureBox> blocos = new List<PictureBox>();



        private void primeiroMundo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void primeiroMundo_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (MarioMorto)
            {
                marioParadoPerso.Top += velocidadeDoY;
                velocidadeDoY += gravidade;
                return;
            }

            if (esperandoAnimacaoMorte || vitoriaMario)
            {
                return;
            }

            // salva posição anterior
            posicaoAnteriorY = marioParadoPerso.Top;
            posicaoAnteriorX = marioParadoPerso.Left;

            // movimento horizontal
            if (MarioAndandoDireita)
            {
                int meioTela = this.ClientSize.Width / 2;

                if (marioParadoPerso.Left < meioTela)
                {
                    marioParadoPerso.Left += velocidadeMario;
                }
                else
                {
                    int novoScroll = this.HorizontalScroll.Value + velocidadeMario;

                    if (novoScroll <= this.HorizontalScroll.Maximum)
                    {
                        this.HorizontalScroll.Value = novoScroll;
                    }

                    int cameraX = -this.AutoScrollPosition.X;

                    cameraX += velocidadeMario;

                    this.AutoScrollPosition = new Point(cameraX, 0);
                }
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

            // se o mario cair no limbo, acabou
            if (marioParadoPerso.Top >= limboMario.Top)
            {
                animacaoCairVoid();
            }
            // hitbox da bandeira
            if (marioParadoPerso.Top <= hitboxBandeira.Top)
            {
                marioParadoPerso.Top = marioParadoPerso.Top;
            }

            //vitoria na bandeira

            if (!vitoriaMario && marioParadoPerso.Bounds.IntersectsWith(hitboxBandeira.Bounds))
            {

                fimVitoriaMario();

            }

            //calixto andando

            if (CalixtoAndandoDireita) 
            {
                calixtoNPC.Left += velocidadeCalixto;
                CalixtoOlhandoDireita = true;

                if (calixtoNPC.Right >= pictureBox225.Left)
                {
                    CalixtoAndandoDireita = false;
                    CalixtoAndandoEsquerda = true;
                    AtualizarSpriteCalixto();
                }

            }

            else if (CalixtoAndandoEsquerda)
            {
                calixtoNPC.Left -= velocidadeCalixto;
                CalixtoOlhandoDireita = false;

                if (calixtoNPC.Left < 0)
                {
                    calixtoNPC.Enabled = false;
                }
            }

            //calixto andando 2

            if (CalixtoAndandoDireita2)
            {
                calixtoNPC2.Left += velocidadeCalixto2;
                CalixtoOlhandoDireita2 = true;

                if (calixtoNPC2.Right >= pictureBox226.Left)
                {
                    CalixtoAndandoDireita2 = false;
                    CalixtoAndandoEsquerda2 = true;
                    AtualizarSpriteCalixto2();
                }

            }

            else if (CalixtoAndandoEsquerda2)
            {
                calixtoNPC2.Left -= velocidadeCalixto2;
                CalixtoOlhandoDireita2 = false;

                if (calixtoNPC2.Left < 0)
                {
                    calixtoNPC2.Enabled = false;
                }

                if (calixtoNPC2.Left <= pictureBox225.Right)
                {
                    CalixtoAndandoEsquerda2 = false;
                    CalixtoAndandoDireita2 = true;
                    AtualizarSpriteCalixto2();
                }
            }

            //calixto andando 3

            if (CalixtoAndandoDireita3)
            {
                calixtoNPC3.Left += velocidadeCalixto3;
                CalixtoOlhandoDireita3 = true;

                if (calixtoNPC3.Right >= pictureBox228.Left)
                {
                    CalixtoAndandoDireita3 = false;
                    CalixtoAndandoEsquerda3 = true;
                    AtualizarSpriteCalixto3();
                }

            }

            else if (CalixtoAndandoEsquerda3)
            {
                calixtoNPC3.Left -= velocidadeCalixto3;
                CalixtoOlhandoDireita3 = false;

                if (calixtoNPC3.Left < 0)
                {
                    calixtoNPC3.Enabled = false;
                }

                if (calixtoNPC3.Left <= pictureBox227.Right)
                {
                    CalixtoAndandoEsquerda3 = false;
                    CalixtoAndandoDireita3 = true;
                    AtualizarSpriteCalixto3();
                }
            }

            //calixto andando 4

            if (CalixtoAndandoDireita4)
            {
                calixtoNPC4.Left += velocidadeCalixto4;
                CalixtoOlhandoDireita4 = true;

                if (calixtoNPC4.Right >= pictureBox228.Left)
                {
                    CalixtoAndandoDireita4 = false;
                    CalixtoAndandoEsquerda4 = true;
                    AtualizarSpriteCalixto4();
                }

            }

            else if (CalixtoAndandoEsquerda4)
            {
                calixtoNPC4.Left -= velocidadeCalixto4;
                CalixtoOlhandoDireita4 = false;

                if (calixtoNPC4.Left < 0)
                {
                    calixtoNPC4.Enabled = false;
                }

                if (calixtoNPC4.Left <= pictureBox227.Right)
                {
                    CalixtoAndandoEsquerda4 = false;
                    CalixtoAndandoDireita4 = true;
                    AtualizarSpriteCalixto4();
                }
            }

            //calixto andando 5

            if (CalixtoAndandoDireita5)
            {
                calixtoNPC5.Left += velocidadeCalixto5;
                CalixtoOlhandoDireita5 = true;

                if (calixtoNPC5.Right >= parede2Calixto5.Left)
                {
                    CalixtoAndandoDireita5 = false;
                    CalixtoAndandoEsquerda5 = true;
                    AtualizarSpriteCalixto5();
                }

            }

            else if (CalixtoAndandoEsquerda5)
            {
                calixtoNPC5.Left -= velocidadeCalixto5;
                CalixtoOlhandoDireita5 = false;

                if (calixtoNPC5.Left < 0)
                {
                    calixtoNPC5.Enabled = false;
                }

                if (calixtoNPC5.Left <= paredeCalixto5.Right)
                {
                    CalixtoAndandoEsquerda5 = false;
                    CalixtoAndandoDireita5 = true;
                    AtualizarSpriteCalixto5();
                }
            }

            //calixto andando 6

            if (CalixtoAndandoDireita6)
            {
                calixtoNPC6.Left += velocidadeCalixto6;
                CalixtoOlhandoDireita6 = true;

                if (calixtoNPC6.Right >= pictureBox102.Left)
                {
                    CalixtoAndandoDireita6 = false;
                    CalixtoAndandoEsquerda6 = true;
                    AtualizarSpriteCalixto6();
                }

            }

            else if (CalixtoAndandoEsquerda6)
            {
                calixtoNPC6.Left -= velocidadeCalixto6;
                CalixtoOlhandoDireita6 = false;

                if (calixtoNPC6.Left < 0)
                {
                    calixtoNPC6.Enabled = false;
                }

                if (calixtoNPC6.Left <= parede1Calixto6Cima.Right)
                {
                    CalixtoAndandoEsquerda6 = false;
                    CalixtoAndandoDireita6 = true;
                    AtualizarSpriteCalixto6();
                }
            }

            //calixto andando 7

            if (CalixtoAndandoDireita7)
            {
                calixtoNPC7.Left += velocidadeCalixto7;
                CalixtoOlhandoDireita7 = true;

                if (calixtoNPC7.Right >= pictureBox102.Left)
                {
                    CalixtoAndandoDireita7 = false;
                    CalixtoAndandoEsquerda7 = true;
                    AtualizarSpriteCalixto7();
                }

            }

            else if (CalixtoAndandoEsquerda7)
            {
                calixtoNPC7.Left -= velocidadeCalixto7;
                CalixtoOlhandoDireita7 = false;

                if (calixtoNPC7.Left < 0)
                {
                    calixtoNPC7.Enabled = false;
                }

                if (calixtoNPC7.Left <= parede1Calixto6Cima.Right)
                {
                    CalixtoAndandoEsquerda7 = false;
                    CalixtoAndandoDireita7 = true;
                    AtualizarSpriteCalixto7();
                }
            }

            //calixto andando 8

            if (CalixtoAndandoDireita8)
            {
                calixtoNPC8.Left += velocidadeCalixto8;
                CalixtoOlhandoDireita8 = true;

                if (calixtoNPC8.Right >= pictureBox230.Left)
                {
                    CalixtoAndandoDireita8 = false;
                    CalixtoAndandoEsquerda8 = true;
                    AtualizarSpriteCalixto8();
                }

            }

            else if (CalixtoAndandoEsquerda8)
            {
                calixtoNPC8.Left -= velocidadeCalixto8;
                CalixtoOlhandoDireita8 = false;

                if (calixtoNPC8.Left < 0)
                {
                    calixtoNPC8.Enabled = false;
                }

                if (calixtoNPC8.Left <= pictureBox229.Right)
                {
                    CalixtoAndandoEsquerda8 = false;
                    CalixtoAndandoDireita8 = true;
                    AtualizarSpriteCalixto8();
                }
            }

            // oswaldo andando 1

            if (OswaldoAndandoDireita1)
            {
                oswaldoNPC1.Left += velocidadeOswaldo1;
                OswaldoOlhandoDireita1 = true;

                if (oswaldoNPC1.Right >= pictureBox102.Left)
                {
                    OswaldoAndandoDireita1 = false;
                    OswaldoAndandoEsquerda1 = true;
                    AtualizarSpriteOswaldo1();
                }

            }

            else if (OswaldoAndandoEsquerda1)
            {
                oswaldoNPC1.Left -= velocidadeOswaldo1;
                OswaldoOlhandoDireita1 = false;

                if (oswaldoNPC1.Left < 0)
                {
                    oswaldoNPC1.Enabled = false;
                }

                if (oswaldoNPC1.Left <= parede1Calixto6Cima.Right)
                {
                    OswaldoAndandoEsquerda1 = false;
                    OswaldoAndandoDireita1 = true;
                    AtualizarSpriteOswaldo1();
                }
            }

            // oswaldo andando 2

            if (OswaldoAndandoDireita2)
            {
                oswaldoNPC2.Left += velocidadeOswaldo2;
                OswaldoOlhandoDireita2 = true;

                if (oswaldoNPC2.Right >= pictureBox102.Left)
                {
                    OswaldoAndandoDireita2 = false;
                    OswaldoAndandoEsquerda2 = true;
                    AtualizarSpriteOswaldo2();
                }

            }

            else if (OswaldoAndandoEsquerda2)
            {
                oswaldoNPC2.Left -= velocidadeOswaldo2;
                OswaldoOlhandoDireita2 = false;

                if (oswaldoNPC2.Left < 0)
                {
                    oswaldoNPC2.Enabled = false;
                }

                if (oswaldoNPC2.Left <= parede1Calixto6Cima.Right)
                {
                    OswaldoAndandoEsquerda2 = false;
                    OswaldoAndandoDireita2 = true;
                    AtualizarSpriteOswaldo2();
                }
            }


            // verifica se mario pixou no NPC calixto

            if (!MarioMorto && !esperandoAnimacaoMorte && CalixtoVivo && marioParadoPerso.Bounds.IntersectsWith(calixtoNPC.Bounds))
            {

                int MarioBottomAnterior = posicaoAnteriorY + marioParadoPerso.Height;

                if (velocidadeDoY > 0 && MarioBottomAnterior <= calixtoNPC.Top + 20)
                {
                    velocidadeDoY = -10;

                    CalixtoMorteNPC();
                }

                else
                {
                    if (velocidadeMario != 0)
                    {
                        MarioMorte();
                    }
                }
            }
            // verifica se mario pixou no NPC calixto 2

            if (!MarioMorto && !esperandoAnimacaoMorte && CalixtoVivo2 && marioParadoPerso.Bounds.IntersectsWith(calixtoNPC2.Bounds))
            {
                int MarioBottomAnterior2 = posicaoAnteriorY + marioParadoPerso.Height;

                if (velocidadeDoY > 0 && MarioBottomAnterior2 <= calixtoNPC2.Top + 20)
                {
                    velocidadeDoY = -10;
                    CalixtoMorteNPC2();
                }
                else
                {
                    if (velocidadeMario != 0)
                    {
                        MarioMorte();
                    }
                }
            }

            // verifica se Mario pixou no NPC calixto 3

            if (!MarioMorto && !esperandoAnimacaoMorte && CalixtoVivo3 && marioParadoPerso.Bounds.IntersectsWith(calixtoNPC3.Bounds))
            {
                int MarioBottomAnterior3 = posicaoAnteriorY + marioParadoPerso.Height;

                if (velocidadeDoY > 0 && MarioBottomAnterior3 <= calixtoNPC3.Top + 20)
                {
                    velocidadeDoY = -10;
                    CalixtoMorteNPC3();
                }
                else
                {
                    if (velocidadeMario != 0)
                    {
                        MarioMorte();
                    }
                }
            }

            // verifica se Mario pixou no NPC calixto 4

            if (!MarioMorto && !esperandoAnimacaoMorte && CalixtoVivo4 && marioParadoPerso.Bounds.IntersectsWith(calixtoNPC4.Bounds))
            {
                int MarioBottomAnterior4 = posicaoAnteriorY + marioParadoPerso.Height;

                if (velocidadeDoY > 0 && MarioBottomAnterior4 <= calixtoNPC4.Top + 20)
                {
                    velocidadeDoY = -10;
                    CalixtoMorteNPC4();
                }
                else
                {
                    if (velocidadeMario != 0)
                    {
                        MarioMorte();
                    }
                }
            }

            // verifica se Mario pixou no NPC calixto 5

            if (!MarioMorto && !esperandoAnimacaoMorte && CalixtoVivo5 && marioParadoPerso.Bounds.IntersectsWith(calixtoNPC5.Bounds))
            {
                int MarioBottomAnterior5 = posicaoAnteriorY + marioParadoPerso.Height;

                if (velocidadeDoY > 0 && MarioBottomAnterior5 <= calixtoNPC5.Top + 20)
                {
                    velocidadeDoY = -10;
                    CalixtoMorteNPC5();
                }
                else
                {
                    if (velocidadeMario != 0)
                    {
                        MarioMorte();
                    }
                }
            }

            // verifica se Mario pixou no NPC calixto 6

            if (!MarioMorto && !esperandoAnimacaoMorte && CalixtoVivo6 && marioParadoPerso.Bounds.IntersectsWith(calixtoNPC6.Bounds))
            {
                int MarioBottomAnterior6 = posicaoAnteriorY + marioParadoPerso.Height;

                if (velocidadeDoY > 0 && MarioBottomAnterior6 <= calixtoNPC6.Top + 20)
                {
                    velocidadeDoY = -10;
                    CalixtoMorteNPC6();
                }
                else
                {
                    if (velocidadeMario != 0)
                    {
                        MarioMorte();
                    }
                }
            }

            // verifica se Mario pixou no NPC calixto 7

            if (!MarioMorto && !esperandoAnimacaoMorte && CalixtoVivo7 && marioParadoPerso.Bounds.IntersectsWith(calixtoNPC7.Bounds))
            {
                int MarioBottomAnterior7 = posicaoAnteriorY + marioParadoPerso.Height;

                if (velocidadeDoY > 0 && MarioBottomAnterior7 <= calixtoNPC7.Top + 20)
                {
                    velocidadeDoY = -10;
                    CalixtoMorteNPC7();
                }
                else
                {
                    if (velocidadeMario != 0)
                    {
                        MarioMorte();
                    }
                }
            }

            // verifica se Mario pixou no NPC calixto 8

            if (!MarioMorto && !esperandoAnimacaoMorte && CalixtoVivo8 && marioParadoPerso.Bounds.IntersectsWith(calixtoNPC8.Bounds))
            {
                int MarioBottomAnterior8 = posicaoAnteriorY + marioParadoPerso.Height;

                if (velocidadeDoY > 0 && MarioBottomAnterior8 <= calixtoNPC8.Top + 20)
                {
                    velocidadeDoY = -10;
                    CalixtoMorteNPC8();
                }
                else
                {
                    if (velocidadeMario != 0)
                    {
                        MarioMorte();
                    }
                }
            }


            // verifica se Mario pixou no NPC oswaldo 1

            if (!MarioMorto && !esperandoAnimacaoMorte && OswaldoVivo1 && marioParadoPerso.Bounds.IntersectsWith(oswaldoNPC1.Bounds))
            {
                int MariobottomAnterior1 = posicaoAnteriorY + marioParadoPerso.Height;

                if (velocidadeDoY > 0 && MariobottomAnterior1 <= oswaldoNPC1.Top + 20)
                {
                    velocidadeDoY = -10;
                    pulosCabecaOswaldo1 += 1;
                    OswaldoMorteNPC1();
                }

                else
                {
                    if (velocidadeMario != 0)
                    {
                        MarioMorte();
                    }
                }
            }

            // verifica se Mario pixou no NPC oswaldo 2

            if (!MarioMorto && !esperandoAnimacaoMorte && OswaldoVivo2 && marioParadoPerso.Bounds.IntersectsWith(oswaldoNPC2.Bounds))
            {
                int MariobottomAnterior2 = posicaoAnteriorY + marioParadoPerso.Height;

                if (velocidadeDoY > 0 && MariobottomAnterior2 <= oswaldoNPC2.Top + 20)
                {
                    velocidadeDoY = -10;
                    pulosCabecaOswaldo2 += 1;
                    OswaldoMorteNPC2();
                }

                else
                {
                    if (velocidadeMario != 0)
                    {
                        MarioMorte();
                    }
                }
            }

        }

        void CalixtoMorteNPC()
        {
            CalixtoVivo = false;
            velocidadeCalixto = 0;
            CalixtoAndandoDireita = false;
            CalixtoAndandoEsquerda = false;
            calixtoNPC.Enabled = false;
            InimigoSendoMortoSOM(InimigoMortoSom);


            calixtoNPC.Size = new Size(53, 50);
            calixtoNPC.Location = new Point(calixtoNPC.Location.X, 380);


            Timer tempo = new Timer();

            tempo.Interval = 500;
            tempo.Tick += (s, e) =>
            {
                calixtoNPC.Top = 2000;
                calixtoNPC.Visible = false;

                tempo.Stop();
                tempo.Dispose();
            };

            tempo.Start();
        }

        void CalixtoMorteNPC2()
        {
            CalixtoVivo2 = false;
            velocidadeCalixto2 = 0;
            CalixtoAndandoDireita2 = false;
            CalixtoAndandoEsquerda2 = false;
            calixtoNPC2.Enabled = false;
            calixtoNPC2.Size = new Size(53, 50);
            calixtoNPC2.Location = new Point(calixtoNPC2.Location.X, 380);
            InimigoSendoMortoSOM(InimigoMortoSom);

            Timer tempo = new Timer();

            tempo.Interval = 500;
            tempo.Tick += (s, e) =>
            {
                calixtoNPC2.Top = 2000;
                calixtoNPC2.Visible = false;

                tempo.Stop();
                tempo.Dispose();
            };

            tempo.Start();
        }
        void CalixtoMorteNPC3()
        {
            CalixtoVivo3 = false;
            velocidadeCalixto3 = 0;
            CalixtoAndandoDireita3 = false;
            CalixtoAndandoEsquerda3 = false;
            calixtoNPC3.Enabled = false;
            calixtoNPC3.Size = new Size(53, 50);
            calixtoNPC3.Location = new Point(calixtoNPC3.Location.X, 380);
            InimigoSendoMortoSOM(InimigoMortoSom);

            Timer tempo = new Timer();

            tempo.Interval = 500;
            tempo.Tick += (s, e) =>
            {
                calixtoNPC3.Top = 2000;
                calixtoNPC3.Visible = false;

                tempo.Stop();
                tempo.Dispose();
            };

            tempo.Start();
        }
        void CalixtoMorteNPC4()
        {
            CalixtoVivo4 = false;
            velocidadeCalixto4 = 0;
            CalixtoAndandoDireita4 = false;
            CalixtoAndandoEsquerda4 = false;
            calixtoNPC4.Enabled = false;
            calixtoNPC4.Size = new Size(53, 50);
            calixtoNPC4.Location = new Point(calixtoNPC4.Location.X, 380);
            InimigoSendoMortoSOM(InimigoMortoSom);

            Timer tempo = new Timer();

            tempo.Interval = 500;
            tempo.Tick += (s, e) =>
            {
                calixtoNPC4.Top = 2000;
                calixtoNPC4.Visible = false;

                tempo.Stop();
                tempo.Dispose();
            };

            tempo.Start();
        }
        void CalixtoMorteNPC5()
        {
            CalixtoVivo5 = false;
            velocidadeCalixto5 = 0;
            CalixtoAndandoDireita5 = false;
            CalixtoAndandoEsquerda5 = false;
            calixtoNPC5.Enabled = false;
            calixtoNPC5.Size = new Size(53, 50);
            calixtoNPC5.Location = new Point(calixtoNPC5.Location.X, 380);
            InimigoSendoMortoSOM(InimigoMortoSom);

            Timer tempo = new Timer();

            tempo.Interval = 500;
            tempo.Tick += (s, e) =>
            {
                calixtoNPC5.Top = 2000;
                calixtoNPC5.Visible = false;

                tempo.Stop();
                tempo.Dispose();
            };

            tempo.Start();
        }
        void CalixtoMorteNPC6()
        {
            CalixtoVivo6 = false;
            velocidadeCalixto6 = 0;
            CalixtoAndandoDireita6 = false;
            CalixtoAndandoEsquerda6 = false;
            calixtoNPC6.Enabled = false;
            calixtoNPC6.Size = new Size(53, 50);
            calixtoNPC6.Location = new Point(calixtoNPC6.Location.X, 380);
            InimigoSendoMortoSOM(InimigoMortoSom);

            Timer tempo = new Timer();

            tempo.Interval = 500;
            tempo.Tick += (s, e) =>
            {
                calixtoNPC6.Top = 2000;
                calixtoNPC6.Visible = false;

                tempo.Stop();
                tempo.Dispose();
            };

            tempo.Start();
        }
        void CalixtoMorteNPC7()
        {
            CalixtoVivo7 = false;
            velocidadeCalixto7 = 0;
            CalixtoAndandoDireita7 = false;
            CalixtoAndandoEsquerda7 = false;
            calixtoNPC7.Enabled = false;
            calixtoNPC7.Size = new Size(53, 50);
            calixtoNPC7.Location = new Point(calixtoNPC7.Location.X, 380);
            InimigoSendoMortoSOM(InimigoMortoSom);

            Timer tempo = new Timer();

            tempo.Interval = 500;
            tempo.Tick += (s, e) =>
            {
                calixtoNPC7.Top = 2000;
                calixtoNPC7.Visible = false;

                tempo.Stop();
                tempo.Dispose();
            };

            tempo.Start();
        }
        void CalixtoMorteNPC8()
        {
            CalixtoVivo8 = false;
            velocidadeCalixto8 = 0;
            CalixtoAndandoDireita8 = false;
            CalixtoAndandoEsquerda8 = false;
            calixtoNPC8.Enabled = false;
            calixtoNPC8.Size = new Size(53, 50);
            calixtoNPC8.Location = new Point(calixtoNPC8.Location.X, 380);
            InimigoSendoMortoSOM(InimigoMortoSom);

            Timer tempo = new Timer();

            tempo.Interval = 500;
            tempo.Tick += (s, e) =>
            {
                calixtoNPC8.Top = 2000;
                calixtoNPC8.Visible = false;

                tempo.Stop();
                tempo.Dispose();
            };

            tempo.Start();
        }

        void OswaldoMorteNPC1()
        {
            if (pulosCabecaOswaldo1 == 1)
            {
                velocidadeOswaldo1 = 1;
                oswaldoNPC1.Size = new Size(53, 50);
                oswaldoNPC1.Location = new Point(oswaldoNPC1.Location.X, 380);
                InimigoSendoMortoSOM(InimigoMortoSom);
            }

            else if (pulosCabecaOswaldo1 >= 2)
            {
                OswaldoVivo1 = false;
                oswaldoNPC1.Enabled = false;
                oswaldoNPC1.Size = new Size(53, 30);
                oswaldoNPC1.Location = new Point(oswaldoNPC1.Location.X, 406);
                InimigoSendoMortoSOM(InimigoMortoSom);

                Timer tempo = new Timer();

                tempo.Interval = 500;
                tempo.Tick += (s, e) =>
                {
                    oswaldoNPC1.Top = 2000;
                    oswaldoNPC1.Visible = false;
                    velocidadeOswaldo1 = 0;

                    tempo.Stop();
                    tempo.Dispose();
                };

                tempo.Start();
            }
        }

        void OswaldoMorteNPC2()
        {
            if (pulosCabecaOswaldo2 == 1)
            {
                velocidadeOswaldo2 = 1;
                oswaldoNPC2.Size = new Size(53, 50);
                oswaldoNPC2.Location = new Point(oswaldoNPC2.Location.X, 380);
                InimigoSendoMortoSOM(InimigoMortoSom);
            }

            else if (pulosCabecaOswaldo2 >= 2)
            {
                OswaldoVivo2 = false;
                oswaldoNPC2.Enabled = false;
                oswaldoNPC2.Size = new Size(53, 30);
                oswaldoNPC2.Location = new Point(oswaldoNPC2.Location.X, 406);
                InimigoSendoMortoSOM(InimigoMortoSom);

                Timer tempo = new Timer();

                tempo.Interval = 500;
                tempo.Tick += (s, e) =>
                {
                    oswaldoNPC2.Top = 2000;
                    oswaldoNPC2.Visible = false;
                    velocidadeOswaldo2 = 0;

                    tempo.Stop();
                    tempo.Dispose();
                };

                tempo.Start();
            }
        }

        void AtualizarSpriteCalixto()
        {

            if (calixtoNPC.Image != null)
            {
                calixtoNPC.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                calixtoNPC.Refresh();
            }

        }

        void AtualizarSpriteCalixto2()
        {
            if (calixtoNPC2.Image != null)
            {
                calixtoNPC2.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                calixtoNPC2.Refresh();
            }
        }

        void AtualizarSpriteCalixto3()
        {
            if (calixtoNPC3.Image != null)
            {
                calixtoNPC3.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                calixtoNPC3.Refresh();
            }
        }
        void AtualizarSpriteCalixto4()
        {
            if (calixtoNPC4.Image != null)
            {
                calixtoNPC4.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                calixtoNPC4.Refresh();
            }
        }
        void AtualizarSpriteCalixto5()
        {
            if (calixtoNPC5.Image != null)
            {
                calixtoNPC5.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                calixtoNPC5.Refresh();
            }
        }
        void AtualizarSpriteCalixto6()
        {
            if (calixtoNPC6.Image != null)
            {
                calixtoNPC6.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                calixtoNPC6.Refresh();
            }
        }
        void AtualizarSpriteCalixto7()
        {
            if (calixtoNPC7.Image != null)
            {
                calixtoNPC7.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                calixtoNPC7.Refresh();
            }
        }
        void AtualizarSpriteCalixto8()
        {
            if (calixtoNPC8.Image != null)
            {
                calixtoNPC8.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                calixtoNPC8.Refresh();
            }
        }

        void AtualizarSpriteOswaldo1()
        {
            if (oswaldoNPC1.Image != null)
            {
                oswaldoNPC1.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                oswaldoNPC1.Refresh();
            }
        }

        void AtualizarSpriteOswaldo2()
        {
            if (oswaldoNPC2.Image != null)
            {
                oswaldoNPC2.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                oswaldoNPC2.Refresh();
            }
        }


        private void primeiroMundo_KeyDown(object sender, KeyEventArgs e)
        {
            if (MarioMorto || esperandoAnimacaoMorte) return;

            // verifica se W foi apertado
            if ((e.KeyCode == Keys.W || e.KeyCode == Keys.Up) && !MarioPulando)
            {
                velocidadeDoY = forcaPuloMario;
                MarioPulando = true;
                AtualizarSprite();

                MarioPularSom(MarioPulandoSOM);
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

            if (e.KeyCode == Keys.Space)
            {

                for (int i = 0; i < 10; i++)
                {
                    velocidadeAumentadaMario++;
                }

                if (velocidadeAumentadaMario == 10)
                {
                    velocidadeMario = 12;
                    forcaPuloMario = -20;
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
        
            if (e.KeyCode == Keys.Space)
            {
                velocidadeMario = 8;
                forcaPuloMario = -18;

                velocidadeAumentadaMario = 0;
            }
        }
        void AtualizarSprite()
        {
            // atualiza a direção do mario (imagem)



            if (MarioPulando)
            {
                marioParadoPerso.Image = Properties.Resources.marioParado;
            }

            else
            {
                marioParadoPerso.Image = Properties.Resources.marioPulando;
            }


            // muda a direção da imagem do mario

            if (!MarioOlhandoDireita)
            {
                marioParadoPerso.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);

            }

            
        }

        void animacaoCairVoid()
        {
            marioParadoPerso.Image = Properties.Resources.marioMortoPNG;

            Timer delayMorte = new Timer();
            delayMorte.Interval = 300;
            delayMorte.Tick += (s, e) =>

            {
                delayMorte.Stop();
                delayMorte.Dispose();
                MarioMorto = true;

                if (marioParadoPerso.Top >= limboMario.Top)
                {
                    marioParadoPerso.Top = limboMario.Top;
                }

                delayMorte.Interval = 500;
                velocidadeDoY = 0;
                blocos.Clear();

                delayMorte.Interval = 16;
                velocidadeDoY = -13;

                ReiniciarQuandoCair(); 
            };
            delayMorte.Start();
        }

        void ReiniciarQuandoCair()
        {

            Timer restartTimer = new Timer();
            restartTimer.Interval = 3000;
            restartTimer.Tick += (ts, te) => { Application.Restart(); };
            restartTimer.Start();
        }


        void MarioMorte() { 
        
            if (MarioMorto || esperandoAnimacaoMorte) return;

            esperandoAnimacaoMorte = true;

            velocidadeMario = 0;
            velocidadeCalixto = 0;
            MarioAndandoEsquerda = false;
            MarioAndandoDireita = false;
            musicaFundo.controls.stop();

            calixtoNPC.Enabled = false;
            marioParadoPerso.Image = Properties.Resources.marioMortoPNG;

            Timer delayMorte = new Timer();
            delayMorte.Interval = 500;
            delayMorte.Tick += (s, e) =>
            {
                delayMorte.Stop();
                delayMorte.Dispose();
                MarioMorrendoSom(MarioPerdeuSom);

                MarioMorto = true;
                velocidadeDoY = -15;
                blocos.Clear();
                esperandoAnimacaoMorte = false;

                // reinicia a fase
                Timer restartTimer = new Timer();
                restartTimer.Interval = 3000;
                restartTimer.Tick += (ts, te) => { Application.Restart(); };
                restartTimer.Start();
            };

            delayMorte.Start();
        }

        void fimVitoriaMario()
        {
            if (vitoriaMario) return;

            velocidadeMario = 0;
            MarioAndandoDireita = false;
            MarioAndandoEsquerda = false;
            vitoriaMario = true;
            velocidadeDoY = 0;
            decendoBandeira = true;
            marioParadoPerso.Left = hitboxBandeira.Left - 40;

            Timer pausa = new Timer();
            pausa.Interval = 1000;

            pausa.Tick += (s, e) =>
            {
                pausa.Stop();
                pausa.Dispose();

                DescerBandeira();
            };

            pausa.Start();

        }

        void DescerBandeira()
        {
            musicaFundo.controls.stop();
            MarioDescendoEffect.controls.stop();
            MarioDescendoBandeiraSom(MarioDescendoSom);

            Timer VitoriaTempo = new Timer();
            VitoriaTempo.Interval = 16;
            VitoriaTempo.Tick += (s, e) =>
            {
                marioParadoPerso.Top += 4;

                if (marioParadoPerso.Top >= 355)
                {
                    marioParadoPerso.Top = 355;
                    decendoBandeira = false;

                    marioParadoPerso.Image = Properties.Resources.marioPulando;

                    VitoriaTempo.Stop();
                    VitoriaTempo.Dispose();


                    marioParadoPerso.Refresh();
                    VitoriaTempo.Interval = 500;



                    entrarNoCastelo();
                }
            };

            VitoriaTempo.Start();
        }

        void entrarNoCastelo()
        {
            entrandoCastelo = true;
            MarioTerminandoFaseSom(MarioFaseConcluidaSOM);
            MarioDescendoEffect.controls.stop();

            Timer andar = new Timer();
            andar.Interval = 16;

            andar.Tick += (s, e) =>
            {
                marioParadoPerso.Left += 3;

                if (marioParadoPerso.Left >= cairChaoHitBoxBandeira.Left)
                {
                    marioParadoPerso.Top = cairChaoHitBoxBandeira.Bottom - 40;

                }

                // chegou no castelo
                if (marioParadoPerso.Left >= castelo.Left + 83)
                {
                    marioParadoPerso.Visible = false;

                    entrandoCastelo = false;

                    andar.Stop();
                    andar.Dispose();


                    Timer restartTimer = new Timer();
                    restartTimer.Interval = 4000;
                    restartTimer.Tick += (ts, te) => { Application.Restart(); };
                    restartTimer.Start();
                }
            };

            andar.Start();
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
                SomQuebrarTijolo(MarioQuebrandoTijoloSom);
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

        public class Musica
        {
            public string Arquivo { get; set; }

            public Musica() { }

            public Musica(string arquivo)
            {
                Arquivo = arquivo;
            }

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

        private void pictureBox248_Click(object sender, EventArgs e)
        {

        }
    }
    
}
