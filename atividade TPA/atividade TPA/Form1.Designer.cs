namespace atividade_TPA
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.NavBar = new System.Windows.Forms.GroupBox();
            this.nomeDoUsuarioTexto = new System.Windows.Forms.Label();
            this.ImagemUsuario = new System.Windows.Forms.PictureBox();
            this.betaNav = new System.Windows.Forms.Label();
            this.CriarContaNav = new System.Windows.Forms.Button();
            this.mineTerra = new System.Windows.Forms.PictureBox();
            this.navMinecraft = new System.Windows.Forms.Label();
            this.EntrarNav = new System.Windows.Forms.Button();
            this.SobreButtom = new System.Windows.Forms.Button();
            this.radioButtonJava = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonBedrock = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxBedrockVersion = new System.Windows.Forms.ComboBox();
            this.comboBoxJavaVersion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SkinImage = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CarregarSkinButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.trocarSkinButtom = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MODSbutton = new System.Windows.Forms.Button();
            this.configuraçõesButton = new System.Windows.Forms.Button();
            this.comboBoxMODS = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBoxUsuarioName = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.progressoJogo = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tempo = new System.Windows.Forms.Timer(this.components);
            this.NavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mineTerra)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SkinImage)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavBar
            // 
            this.NavBar.BackColor = System.Drawing.Color.Black;
            this.NavBar.Controls.Add(this.nomeDoUsuarioTexto);
            this.NavBar.Controls.Add(this.ImagemUsuario);
            this.NavBar.Controls.Add(this.betaNav);
            this.NavBar.Controls.Add(this.CriarContaNav);
            this.NavBar.Controls.Add(this.mineTerra);
            this.NavBar.Controls.Add(this.navMinecraft);
            this.NavBar.Controls.Add(this.EntrarNav);
            this.NavBar.Location = new System.Drawing.Point(0, -9);
            this.NavBar.Name = "NavBar";
            this.NavBar.Size = new System.Drawing.Size(1054, 72);
            this.NavBar.TabIndex = 0;
            this.NavBar.TabStop = false;
            this.NavBar.Text = "NavBar";
            // 
            // nomeDoUsuarioTexto
            // 
            this.nomeDoUsuarioTexto.AutoSize = true;
            this.nomeDoUsuarioTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeDoUsuarioTexto.ForeColor = System.Drawing.SystemColors.Control;
            this.nomeDoUsuarioTexto.Location = new System.Drawing.Point(858, 31);
            this.nomeDoUsuarioTexto.Name = "nomeDoUsuarioTexto";
            this.nomeDoUsuarioTexto.Size = new System.Drawing.Size(113, 16);
            this.nomeDoUsuarioTexto.TabIndex = 10;
            this.nomeDoUsuarioTexto.Text = "Nome do Usuario";
            this.nomeDoUsuarioTexto.Visible = false;
            this.nomeDoUsuarioTexto.Click += new System.EventHandler(this.nomeDoUsuarioTexto_Click);
            // 
            // ImagemUsuario
            // 
            this.ImagemUsuario.BackColor = System.Drawing.Color.Black;
            this.ImagemUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ImagemUsuario.Image = global::atividade_TPA.Properties.Resources.rostoSteve;
            this.ImagemUsuario.Location = new System.Drawing.Point(985, 21);
            this.ImagemUsuario.Margin = new System.Windows.Forms.Padding(5);
            this.ImagemUsuario.Name = "ImagemUsuario";
            this.ImagemUsuario.Size = new System.Drawing.Size(38, 35);
            this.ImagemUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagemUsuario.TabIndex = 19;
            this.ImagemUsuario.TabStop = false;
            this.ImagemUsuario.Visible = false;
            this.ImagemUsuario.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // betaNav
            // 
            this.betaNav.AutoSize = true;
            this.betaNav.BackColor = System.Drawing.Color.Black;
            this.betaNav.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betaNav.ForeColor = System.Drawing.Color.Red;
            this.betaNav.Location = new System.Drawing.Point(230, 49);
            this.betaNav.Name = "betaNav";
            this.betaNav.Size = new System.Drawing.Size(51, 20);
            this.betaNav.TabIndex = 4;
            this.betaNav.Text = "BETA";
            // 
            // CriarContaNav
            // 
            this.CriarContaNav.Location = new System.Drawing.Point(885, 25);
            this.CriarContaNav.Name = "CriarContaNav";
            this.CriarContaNav.Size = new System.Drawing.Size(67, 28);
            this.CriarContaNav.TabIndex = 3;
            this.CriarContaNav.Text = "Criar conta";
            this.CriarContaNav.UseVisualStyleBackColor = true;
            this.CriarContaNav.Click += new System.EventHandler(this.CriarContaNav_Click);
            // 
            // mineTerra
            // 
            this.mineTerra.Image = global::atividade_TPA.Properties.Resources.minecraftIcon;
            this.mineTerra.Location = new System.Drawing.Point(278, 11);
            this.mineTerra.Name = "mineTerra";
            this.mineTerra.Size = new System.Drawing.Size(55, 55);
            this.mineTerra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mineTerra.TabIndex = 2;
            this.mineTerra.TabStop = false;
            // 
            // navMinecraft
            // 
            this.navMinecraft.AutoSize = true;
            this.navMinecraft.BackColor = System.Drawing.Color.Black;
            this.navMinecraft.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navMinecraft.ForeColor = System.Drawing.SystemColors.Control;
            this.navMinecraft.Location = new System.Drawing.Point(15, 24);
            this.navMinecraft.Name = "navMinecraft";
            this.navMinecraft.Size = new System.Drawing.Size(239, 31);
            this.navMinecraft.TabIndex = 1;
            this.navMinecraft.Text = "LAUNCH&RCRAFT";
            this.navMinecraft.Click += new System.EventHandler(this.navMinecraft_Click);
            // 
            // EntrarNav
            // 
            this.EntrarNav.Location = new System.Drawing.Point(961, 25);
            this.EntrarNav.Name = "EntrarNav";
            this.EntrarNav.Size = new System.Drawing.Size(73, 28);
            this.EntrarNav.TabIndex = 0;
            this.EntrarNav.Text = "ENTRAR";
            this.EntrarNav.UseVisualStyleBackColor = true;
            this.EntrarNav.Click += new System.EventHandler(this.EntrarNav_Click);
            // 
            // SobreButtom
            // 
            this.SobreButtom.Location = new System.Drawing.Point(980, 78);
            this.SobreButtom.Name = "SobreButtom";
            this.SobreButtom.Size = new System.Drawing.Size(43, 23);
            this.SobreButtom.TabIndex = 4;
            this.SobreButtom.Text = "Sobre";
            this.SobreButtom.UseVisualStyleBackColor = true;
            this.SobreButtom.Click += new System.EventHandler(this.SobreButtom_Click);
            // 
            // radioButtonJava
            // 
            this.radioButtonJava.AutoSize = true;
            this.radioButtonJava.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonJava.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonJava.Location = new System.Drawing.Point(27, 50);
            this.radioButtonJava.Name = "radioButtonJava";
            this.radioButtonJava.Size = new System.Drawing.Size(76, 29);
            this.radioButtonJava.TabIndex = 7;
            this.radioButtonJava.TabStop = true;
            this.radioButtonJava.Text = "Java";
            this.radioButtonJava.UseVisualStyleBackColor = true;
            this.radioButtonJava.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioButtonBedrock);
            this.groupBox1.Controls.Add(this.radioButtonJava);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(730, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(30, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tipo do Minecraft";
            // 
            // radioButtonBedrock
            // 
            this.radioButtonBedrock.AutoSize = true;
            this.radioButtonBedrock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonBedrock.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonBedrock.Location = new System.Drawing.Point(109, 50);
            this.radioButtonBedrock.Name = "radioButtonBedrock";
            this.radioButtonBedrock.Size = new System.Drawing.Size(109, 29);
            this.radioButtonBedrock.TabIndex = 8;
            this.radioButtonBedrock.TabStop = true;
            this.radioButtonBedrock.Text = "Bedrock";
            this.radioButtonBedrock.UseVisualStyleBackColor = true;
            this.radioButtonBedrock.CheckedChanged += new System.EventHandler(this.radioButtonBedrock_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBoxBedrockVersion);
            this.groupBox2.Controls.Add(this.comboBoxJavaVersion);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(710, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 142);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Versão";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(167, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Bedrock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(54, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Java";
            // 
            // comboBoxBedrockVersion
            // 
            this.comboBoxBedrockVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBedrockVersion.Enabled = false;
            this.comboBoxBedrockVersion.FormattingEnabled = true;
            this.comboBoxBedrockVersion.Items.AddRange(new object[] {
            "1.22.14",
            "1.21.13",
            "1.20.19",
            "1.19.34",
            "1.18.15",
            "1.17.23",
            "1.16.21"});
            this.comboBoxBedrockVersion.Location = new System.Drawing.Point(151, 96);
            this.comboBoxBedrockVersion.Name = "comboBoxBedrockVersion";
            this.comboBoxBedrockVersion.Size = new System.Drawing.Size(96, 21);
            this.comboBoxBedrockVersion.TabIndex = 12;
            // 
            // comboBoxJavaVersion
            // 
            this.comboBoxJavaVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxJavaVersion.Enabled = false;
            this.comboBoxJavaVersion.FormattingEnabled = true;
            this.comboBoxJavaVersion.Items.AddRange(new object[] {
            "1.22",
            "1.21",
            "1.20",
            "1.19",
            "1.18",
            "1.17.2",
            "1.16",
            "1.14.4",
            "1.12.2",
            "1.8.0",
            "1.7.10",
            "1.0"});
            this.comboBoxJavaVersion.Location = new System.Drawing.Point(26, 96);
            this.comboBoxJavaVersion.Name = "comboBoxJavaVersion";
            this.comboBoxJavaVersion.Size = new System.Drawing.Size(95, 21);
            this.comboBoxJavaVersion.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(33, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Versão do Minecraft";
            // 
            // SkinImage
            // 
            this.SkinImage.BackColor = System.Drawing.Color.Black;
            this.SkinImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SkinImage.Image = global::atividade_TPA.Properties.Resources.steve_png;
            this.SkinImage.Location = new System.Drawing.Point(0, 16);
            this.SkinImage.Margin = new System.Windows.Forms.Padding(5);
            this.SkinImage.Name = "SkinImage";
            this.SkinImage.Size = new System.Drawing.Size(124, 203);
            this.SkinImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SkinImage.TabIndex = 10;
            this.SkinImage.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(477, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 42);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sua SKIN";
            // 
            // CarregarSkinButton
            // 
            this.CarregarSkinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarregarSkinButton.Location = new System.Drawing.Point(456, 357);
            this.CarregarSkinButton.Name = "CarregarSkinButton";
            this.CarregarSkinButton.Size = new System.Drawing.Size(108, 46);
            this.CarregarSkinButton.TabIndex = 5;
            this.CarregarSkinButton.Text = "Carregar Skin";
            this.CarregarSkinButton.UseVisualStyleBackColor = true;
            this.CarregarSkinButton.Click += new System.EventHandler(this.CarregarSkinButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(757, 456);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(168, 58);
            this.StartButton.TabIndex = 12;
            this.StartButton.Text = "START";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // trocarSkinButtom
            // 
            this.trocarSkinButtom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trocarSkinButtom.Location = new System.Drawing.Point(580, 357);
            this.trocarSkinButtom.Name = "trocarSkinButtom";
            this.trocarSkinButtom.Size = new System.Drawing.Size(108, 46);
            this.trocarSkinButtom.TabIndex = 13;
            this.trocarSkinButtom.Text = "Trocar Skin";
            this.trocarSkinButtom.UseVisualStyleBackColor = true;
            this.trocarSkinButtom.Click += new System.EventHandler(this.trocarSkinButtom_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(32, 87);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 435);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Atualizações";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(16, 377);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(322, 36);
            this.label15.TabIndex = 22;
            this.label15.Text = "-Correção de bugs relacionados à detecção de \r\nmemória RAM.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(16, 346);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(262, 18);
            this.label14.TabIndex = 21;
            this.label14.Text = "-Ajustes em falhas visuais na interface.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(16, 298);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(306, 36);
            this.label13.TabIndex = 20;
            this.label13.Text = "-Resolvido problema de travamento ao iniciar\r\ndeterminadas versões modadas.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(16, 269);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(374, 18);
            this.label12.TabIndex = 19;
            this.label12.Text = "-Corrigido erro que impedia o login em algumas contas.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(30, 232);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 25);
            this.label11.TabIndex = 18;
            this.label11.Text = "-Bugs-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(16, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(351, 36);
            this.label10.TabIndex = 17;
            this.label10.Text = "-Melhor desempenho no carregamento das versões\r\ne inicialização do jogo.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(16, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(361, 36);
            this.label9.TabIndex = 16;
            this.label9.Text = "-Novo sistema de gerenciamento de perfis, facilitando\r\na troca entre diferentes c" +
    "onfigurações de jogo.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(16, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(369, 36);
            this.label8.TabIndex = 10;
            this.label8.Text = "-Suporte expandido para versões antigas, permitindo\r\nmaior compatibilidade com mo" +
    "ds e mundos clássicos.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(91, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(231, 42);
            this.label7.TabIndex = 15;
            this.label7.Text = "Atualizações";
            // 
            // MODSbutton
            // 
            this.MODSbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MODSbutton.Location = new System.Drawing.Point(525, 475);
            this.MODSbutton.Name = "MODSbutton";
            this.MODSbutton.Size = new System.Drawing.Size(108, 36);
            this.MODSbutton.TabIndex = 15;
            this.MODSbutton.Text = "Mods";
            this.MODSbutton.UseVisualStyleBackColor = true;
            // 
            // configuraçõesButton
            // 
            this.configuraçõesButton.Location = new System.Drawing.Point(888, 78);
            this.configuraçõesButton.Name = "configuraçõesButton";
            this.configuraçõesButton.Size = new System.Drawing.Size(83, 23);
            this.configuraçõesButton.TabIndex = 16;
            this.configuraçõesButton.Text = "Configurações";
            this.configuraçõesButton.UseVisualStyleBackColor = true;
            this.configuraçõesButton.Click += new System.EventHandler(this.configuraçõesButton_Click);
            // 
            // comboBoxMODS
            // 
            this.comboBoxMODS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMODS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMODS.FormattingEnabled = true;
            this.comboBoxMODS.Items.AddRange(new object[] {
            "-Seus Mods-"});
            this.comboBoxMODS.Location = new System.Drawing.Point(460, 445);
            this.comboBoxMODS.Name = "comboBoxMODS";
            this.comboBoxMODS.Size = new System.Drawing.Size(232, 24);
            this.comboBoxMODS.TabIndex = 15;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBoxUsuarioName);
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Location = new System.Drawing.Point(748, 385);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 58);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Usuarío";
            // 
            // comboBoxUsuarioName
            // 
            this.comboBoxUsuarioName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUsuarioName.FormattingEnabled = true;
            this.comboBoxUsuarioName.Items.AddRange(new object[] {
            "-Steve-"});
            this.comboBoxUsuarioName.Location = new System.Drawing.Point(57, 22);
            this.comboBoxUsuarioName.Name = "comboBoxUsuarioName";
            this.comboBoxUsuarioName.Size = new System.Drawing.Size(133, 21);
            this.comboBoxUsuarioName.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::atividade_TPA.Properties.Resources.rostoSteve;
            this.pictureBox1.Location = new System.Drawing.Point(8, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.SkinImage);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox5.Location = new System.Drawing.Point(509, 123);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(124, 221);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "SKIN";
            // 
            // progressoJogo
            // 
            this.progressoJogo.Margin = new System.Windows.Forms.Padding(733, 2, 1, 20);
            this.progressoJogo.Name = "progressoJogo";
            this.progressoJogo.Size = new System.Drawing.Size(200, 22);
            this.progressoJogo.Click += new System.EventHandler(this.toolStripProgressBar1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressoJogo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 528);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1054, 44);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tempo
            // 
            this.tempo.Interval = 50;
            this.tempo.Tick += new System.EventHandler(this.tempo_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::atividade_TPA.Properties.Resources.minecraftFundoTerra;
            this.ClientSize = new System.Drawing.Size(1054, 572);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.comboBoxMODS);
            this.Controls.Add(this.configuraçõesButton);
            this.Controls.Add(this.MODSbutton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.trocarSkinButtom);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.CarregarSkinButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SobreButtom);
            this.Controls.Add(this.NavBar);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LauncherCraft";
            this.NavBar.ResumeLayout(false);
            this.NavBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mineTerra)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SkinImage)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox NavBar;
        private System.Windows.Forms.Label navMinecraft;
        private System.Windows.Forms.PictureBox mineTerra;
        private System.Windows.Forms.Button SobreButtom;
        private System.Windows.Forms.RadioButton radioButtonJava;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonBedrock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxJavaVersion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxBedrockVersion;
        private System.Windows.Forms.Label betaNav;
        private System.Windows.Forms.PictureBox SkinImage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CarregarSkinButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button trocarSkinButtom;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button MODSbutton;
        private System.Windows.Forms.Button configuraçõesButton;
        private System.Windows.Forms.ComboBox comboBoxMODS;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ToolStripProgressBar progressoJogo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Timer tempo;
        public System.Windows.Forms.Button EntrarNav;
        public System.Windows.Forms.Button CriarContaNav;
        public System.Windows.Forms.Label nomeDoUsuarioTexto;
        public System.Windows.Forms.PictureBox ImagemUsuario;
        public System.Windows.Forms.ComboBox comboBoxUsuarioName;
    }
}

