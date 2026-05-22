namespace seilaYll
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_codigo = new System.Windows.Forms.TextBox();
            this.TXT_nome = new System.Windows.Forms.TextBox();
            this.TXT_nivel = new System.Windows.Forms.TextBox();
            this.TXT_senha = new System.Windows.Forms.TextBox();
            this.TXT_login = new System.Windows.Forms.TextBox();
            this.BTN_anterior = new System.Windows.Forms.Button();
            this.BTN_proximo = new System.Windows.Forms.Button();
            this.BTN_novo = new System.Windows.Forms.Button();
            this.BTN_alterar = new System.Windows.Forms.Button();
            this.BTN_excluir = new System.Windows.Forms.Button();
            this.BTN_sair = new System.Windows.Forms.Button();
            this.BTN_imprimir = new System.Windows.Forms.Button();
            this.BTN_pesquisar = new System.Windows.Forms.Button();
            this.BTN_cancelar = new System.Windows.Forms.Button();
            this.BTN_salvar = new System.Windows.Forms.Button();
            this.cadastroDataSet1 = new seilaYll.CadastroDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tb_usuarioTableAdapter = new seilaYll.CadastroDataSetTableAdapters.tb_usuarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "nivel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "login";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(76, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "senha";
            // 
            // TXT_codigo
            // 
            this.TXT_codigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "cd_usuario", true));
            this.TXT_codigo.Location = new System.Drawing.Point(141, 30);
            this.TXT_codigo.Name = "TXT_codigo";
            this.TXT_codigo.Size = new System.Drawing.Size(100, 20);
            this.TXT_codigo.TabIndex = 5;
            // 
            // TXT_nome
            // 
            this.TXT_nome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "nm_usuario", true));
            this.TXT_nome.Location = new System.Drawing.Point(141, 92);
            this.TXT_nome.Name = "TXT_nome";
            this.TXT_nome.Size = new System.Drawing.Size(565, 20);
            this.TXT_nome.TabIndex = 6;
            // 
            // TXT_nivel
            // 
            this.TXT_nivel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "sg_nivel", true));
            this.TXT_nivel.Location = new System.Drawing.Point(141, 154);
            this.TXT_nivel.Name = "TXT_nivel";
            this.TXT_nivel.Size = new System.Drawing.Size(30, 20);
            this.TXT_nivel.TabIndex = 7;
            // 
            // TXT_senha
            // 
            this.TXT_senha.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "cd_senha", true));
            this.TXT_senha.Location = new System.Drawing.Point(141, 278);
            this.TXT_senha.Name = "TXT_senha";
            this.TXT_senha.Size = new System.Drawing.Size(155, 20);
            this.TXT_senha.TabIndex = 9;
            // 
            // TXT_login
            // 
            this.TXT_login.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "nm_login", true));
            this.TXT_login.Location = new System.Drawing.Point(141, 216);
            this.TXT_login.Name = "TXT_login";
            this.TXT_login.Size = new System.Drawing.Size(230, 20);
            this.TXT_login.TabIndex = 8;
            // 
            // BTN_anterior
            // 
            this.BTN_anterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_anterior.Location = new System.Drawing.Point(26, 328);
            this.BTN_anterior.Name = "BTN_anterior";
            this.BTN_anterior.Size = new System.Drawing.Size(110, 39);
            this.BTN_anterior.TabIndex = 10;
            this.BTN_anterior.Text = "Anterior";
            this.BTN_anterior.UseVisualStyleBackColor = true;
            this.BTN_anterior.Click += new System.EventHandler(this.BTN_anterior_Click);
            // 
            // BTN_proximo
            // 
            this.BTN_proximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_proximo.Location = new System.Drawing.Point(164, 328);
            this.BTN_proximo.Name = "BTN_proximo";
            this.BTN_proximo.Size = new System.Drawing.Size(110, 39);
            this.BTN_proximo.TabIndex = 11;
            this.BTN_proximo.Text = "Proximo";
            this.BTN_proximo.UseVisualStyleBackColor = true;
            this.BTN_proximo.Click += new System.EventHandler(this.BTN_proximo_Click);
            // 
            // BTN_novo
            // 
            this.BTN_novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_novo.Location = new System.Drawing.Point(303, 328);
            this.BTN_novo.Name = "BTN_novo";
            this.BTN_novo.Size = new System.Drawing.Size(110, 39);
            this.BTN_novo.TabIndex = 12;
            this.BTN_novo.Text = "Novo";
            this.BTN_novo.UseVisualStyleBackColor = true;
            this.BTN_novo.Click += new System.EventHandler(this.BTN_novo_Click);
            // 
            // BTN_alterar
            // 
            this.BTN_alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_alterar.Location = new System.Drawing.Point(432, 328);
            this.BTN_alterar.Name = "BTN_alterar";
            this.BTN_alterar.Size = new System.Drawing.Size(110, 39);
            this.BTN_alterar.TabIndex = 13;
            this.BTN_alterar.Text = "Alterar";
            this.BTN_alterar.UseVisualStyleBackColor = true;
            // 
            // BTN_excluir
            // 
            this.BTN_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_excluir.Location = new System.Drawing.Point(568, 328);
            this.BTN_excluir.Name = "BTN_excluir";
            this.BTN_excluir.Size = new System.Drawing.Size(110, 39);
            this.BTN_excluir.TabIndex = 14;
            this.BTN_excluir.Text = "Excluir";
            this.BTN_excluir.UseVisualStyleBackColor = true;
            // 
            // BTN_sair
            // 
            this.BTN_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_sair.Location = new System.Drawing.Point(568, 383);
            this.BTN_sair.Name = "BTN_sair";
            this.BTN_sair.Size = new System.Drawing.Size(110, 39);
            this.BTN_sair.TabIndex = 19;
            this.BTN_sair.Text = "Sair";
            this.BTN_sair.UseVisualStyleBackColor = true;
            this.BTN_sair.Click += new System.EventHandler(this.BTN_sair_Click);
            // 
            // BTN_imprimir
            // 
            this.BTN_imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_imprimir.Location = new System.Drawing.Point(432, 383);
            this.BTN_imprimir.Name = "BTN_imprimir";
            this.BTN_imprimir.Size = new System.Drawing.Size(110, 39);
            this.BTN_imprimir.TabIndex = 18;
            this.BTN_imprimir.Text = "Imprimir";
            this.BTN_imprimir.UseVisualStyleBackColor = true;
            // 
            // BTN_pesquisar
            // 
            this.BTN_pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_pesquisar.Location = new System.Drawing.Point(303, 383);
            this.BTN_pesquisar.Name = "BTN_pesquisar";
            this.BTN_pesquisar.Size = new System.Drawing.Size(110, 39);
            this.BTN_pesquisar.TabIndex = 17;
            this.BTN_pesquisar.Text = "Pesquisar";
            this.BTN_pesquisar.UseVisualStyleBackColor = true;
            // 
            // BTN_cancelar
            // 
            this.BTN_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_cancelar.Location = new System.Drawing.Point(164, 383);
            this.BTN_cancelar.Name = "BTN_cancelar";
            this.BTN_cancelar.Size = new System.Drawing.Size(110, 39);
            this.BTN_cancelar.TabIndex = 16;
            this.BTN_cancelar.Text = "Cancelar";
            this.BTN_cancelar.UseVisualStyleBackColor = true;
            // 
            // BTN_salvar
            // 
            this.BTN_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_salvar.Location = new System.Drawing.Point(26, 383);
            this.BTN_salvar.Name = "BTN_salvar";
            this.BTN_salvar.Size = new System.Drawing.Size(110, 39);
            this.BTN_salvar.TabIndex = 15;
            this.BTN_salvar.Text = "Salvar";
            this.BTN_salvar.UseVisualStyleBackColor = true;
            // 
            // cadastroDataSet1
            // 
            this.cadastroDataSet1.DataSetName = "CadastroDataSet";
            this.cadastroDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "tb_usuario";
            this.bindingSource1.DataSource = this.cadastroDataSet1;
            // 
            // tb_usuarioTableAdapter
            // 
            this.tb_usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.BTN_sair);
            this.Controls.Add(this.BTN_imprimir);
            this.Controls.Add(this.BTN_pesquisar);
            this.Controls.Add(this.BTN_cancelar);
            this.Controls.Add(this.BTN_salvar);
            this.Controls.Add(this.BTN_excluir);
            this.Controls.Add(this.BTN_alterar);
            this.Controls.Add(this.BTN_novo);
            this.Controls.Add(this.BTN_proximo);
            this.Controls.Add(this.BTN_anterior);
            this.Controls.Add(this.TXT_senha);
            this.Controls.Add(this.TXT_login);
            this.Controls.Add(this.TXT_nivel);
            this.Controls.Add(this.TXT_nome);
            this.Controls.Add(this.TXT_codigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXT_codigo;
        private System.Windows.Forms.TextBox TXT_nome;
        private System.Windows.Forms.TextBox TXT_nivel;
        private System.Windows.Forms.TextBox TXT_senha;
        private System.Windows.Forms.TextBox TXT_login;
        private System.Windows.Forms.Button BTN_anterior;
        private System.Windows.Forms.Button BTN_proximo;
        private System.Windows.Forms.Button BTN_novo;
        private System.Windows.Forms.Button BTN_alterar;
        private System.Windows.Forms.Button BTN_excluir;
        private System.Windows.Forms.Button BTN_sair;
        private System.Windows.Forms.Button BTN_imprimir;
        private System.Windows.Forms.Button BTN_pesquisar;
        private System.Windows.Forms.Button BTN_cancelar;
        private System.Windows.Forms.Button BTN_salvar;
        private CadastroDataSet cadastroDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private CadastroDataSetTableAdapters.tb_usuarioTableAdapter tb_usuarioTableAdapter;
    }
}

