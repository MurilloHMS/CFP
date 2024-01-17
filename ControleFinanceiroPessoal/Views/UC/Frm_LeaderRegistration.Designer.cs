namespace ControleFinanceiroPessoal.Views.UC
{
    partial class Frm_LeaderRegistration
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_LeaderRegistration));
            Txt_ID = new TextBox();
            MTxt_DataNascimento = new MaskedTextBox();
            Grp_codigo = new GroupBox();
            Grp_dadosPessoais = new GroupBox();
            groupBox3 = new GroupBox();
            Rb_FreqIgrejaNao = new RadioButton();
            Rb_FreqIgrejaSim = new RadioButton();
            groupBox2 = new GroupBox();
            Rb_CristaoNao = new RadioButton();
            Rb_CristaoSim = new RadioButton();
            label4 = new Label();
            MTxt_Telefone = new MaskedTextBox();
            Txt_Email = new TextBox();
            label3 = new Label();
            label2 = new Label();
            Txt_Nome = new TextBox();
            label1 = new Label();
            Txt_Complemento = new TextBox();
            Lbl_Complemento = new Label();
            Txt_UF = new TextBox();
            Lbl_UF = new Label();
            Txt_Cidade = new TextBox();
            Lbl_Cidade = new Label();
            Txt_Bairro = new TextBox();
            Lbl_Bairro = new Label();
            Txt_Numero = new TextBox();
            Lbl_Numero = new Label();
            Txt_Logradouro = new TextBox();
            Lbl_Endereco = new Label();
            MTxt_Cep = new MaskedTextBox();
            label7 = new Label();
            groupBox1 = new GroupBox();
            Btn_SearchCep = new Button();
            groupBox4 = new GroupBox();
            Txt_Observacoes = new TextBox();
            checkedListBox1 = new CheckedListBox();
            toolStrip1 = new ToolStrip();
            novaToolStripButton = new ToolStripButton();
            abrirToolStripButton = new ToolStripButton();
            salvarToolStripButton = new ToolStripButton();
            ApagarToolStripButton = new ToolStripButton();
            toolStripSeparator = new ToolStripSeparator();
            recortarToolStripButton = new ToolStripButton();
            copiarToolStripButton = new ToolStripButton();
            colarToolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            ajudaToolStripButton = new ToolStripButton();
            Grp_codigo.SuspendLayout();
            Grp_dadosPessoais.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Txt_ID
            // 
            Txt_ID.Location = new Point(6, 22);
            Txt_ID.Name = "Txt_ID";
            Txt_ID.Size = new Size(111, 23);
            Txt_ID.TabIndex = 1;
            // 
            // MTxt_DataNascimento
            // 
            MTxt_DataNascimento.Location = new Point(397, 37);
            MTxt_DataNascimento.Mask = "00/00/0000";
            MTxt_DataNascimento.Name = "MTxt_DataNascimento";
            MTxt_DataNascimento.Size = new Size(133, 23);
            MTxt_DataNascimento.TabIndex = 3;
            // 
            // Grp_codigo
            // 
            Grp_codigo.Controls.Add(Txt_ID);
            Grp_codigo.Location = new Point(14, 28);
            Grp_codigo.Name = "Grp_codigo";
            Grp_codigo.Size = new Size(200, 62);
            Grp_codigo.TabIndex = 3;
            Grp_codigo.TabStop = false;
            Grp_codigo.Text = "Código";
            // 
            // Grp_dadosPessoais
            // 
            Grp_dadosPessoais.Controls.Add(groupBox3);
            Grp_dadosPessoais.Controls.Add(groupBox2);
            Grp_dadosPessoais.Controls.Add(label4);
            Grp_dadosPessoais.Controls.Add(MTxt_Telefone);
            Grp_dadosPessoais.Controls.Add(Txt_Email);
            Grp_dadosPessoais.Controls.Add(label3);
            Grp_dadosPessoais.Controls.Add(label2);
            Grp_dadosPessoais.Controls.Add(Txt_Nome);
            Grp_dadosPessoais.Controls.Add(MTxt_DataNascimento);
            Grp_dadosPessoais.Controls.Add(label1);
            Grp_dadosPessoais.Location = new Point(14, 96);
            Grp_dadosPessoais.Name = "Grp_dadosPessoais";
            Grp_dadosPessoais.Size = new Size(802, 125);
            Grp_dadosPessoais.TabIndex = 4;
            Grp_dadosPessoais.TabStop = false;
            Grp_dadosPessoais.Text = "Dados Pessoais";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(Rb_FreqIgrejaNao);
            groupBox3.Controls.Add(Rb_FreqIgrejaSim);
            groupBox3.Location = new Point(615, 19);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(169, 85);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Frequenta alguma Igreja?";
            // 
            // Rb_FreqIgrejaNao
            // 
            Rb_FreqIgrejaNao.AutoSize = true;
            Rb_FreqIgrejaNao.Location = new Point(13, 47);
            Rb_FreqIgrejaNao.Name = "Rb_FreqIgrejaNao";
            Rb_FreqIgrejaNao.Size = new Size(47, 19);
            Rb_FreqIgrejaNao.TabIndex = 9;
            Rb_FreqIgrejaNao.TabStop = true;
            Rb_FreqIgrejaNao.Text = "Não";
            Rb_FreqIgrejaNao.UseVisualStyleBackColor = true;
            // 
            // Rb_FreqIgrejaSim
            // 
            Rb_FreqIgrejaSim.AutoSize = true;
            Rb_FreqIgrejaSim.Location = new Point(13, 22);
            Rb_FreqIgrejaSim.Name = "Rb_FreqIgrejaSim";
            Rb_FreqIgrejaSim.Size = new Size(45, 19);
            Rb_FreqIgrejaSim.TabIndex = 8;
            Rb_FreqIgrejaSim.TabStop = true;
            Rb_FreqIgrejaSim.Text = "Sim";
            Rb_FreqIgrejaSim.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Rb_CristaoNao);
            groupBox2.Controls.Add(Rb_CristaoSim);
            groupBox2.Location = new Point(536, 19);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(73, 85);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "É Cristão?";
            // 
            // Rb_CristaoNao
            // 
            Rb_CristaoNao.AutoSize = true;
            Rb_CristaoNao.Location = new Point(12, 47);
            Rb_CristaoNao.Name = "Rb_CristaoNao";
            Rb_CristaoNao.Size = new Size(47, 19);
            Rb_CristaoNao.TabIndex = 7;
            Rb_CristaoNao.TabStop = true;
            Rb_CristaoNao.Text = "Não";
            Rb_CristaoNao.UseVisualStyleBackColor = true;
            // 
            // Rb_CristaoSim
            // 
            Rb_CristaoSim.AutoSize = true;
            Rb_CristaoSim.Location = new Point(12, 22);
            Rb_CristaoSim.Name = "Rb_CristaoSim";
            Rb_CristaoSim.Size = new Size(45, 19);
            Rb_CristaoSim.TabIndex = 6;
            Rb_CristaoSim.TabStop = true;
            Rb_CristaoSim.Text = "Sim";
            Rb_CristaoSim.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(393, 63);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 11;
            label4.Text = "Telefone";
            // 
            // MTxt_Telefone
            // 
            MTxt_Telefone.Location = new Point(393, 81);
            MTxt_Telefone.Mask = "(00) 0 0000-0000";
            MTxt_Telefone.Name = "MTxt_Telefone";
            MTxt_Telefone.Size = new Size(133, 23);
            MTxt_Telefone.TabIndex = 5;
            // 
            // Txt_Email
            // 
            Txt_Email.Location = new Point(6, 81);
            Txt_Email.Name = "Txt_Email";
            Txt_Email.Size = new Size(381, 23);
            Txt_Email.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 63);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 8;
            label3.Text = "E-Mail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(397, 19);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 7;
            label2.Text = "Nascimento";
            // 
            // Txt_Nome
            // 
            Txt_Nome.Location = new Point(6, 37);
            Txt_Nome.Name = "Txt_Nome";
            Txt_Nome.Size = new Size(381, 23);
            Txt_Nome.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 5;
            label1.Text = "Nome";
            // 
            // Txt_Complemento
            // 
            Txt_Complemento.Location = new Point(627, 90);
            Txt_Complemento.Name = "Txt_Complemento";
            Txt_Complemento.Size = new Size(157, 23);
            Txt_Complemento.TabIndex = 16;
            // 
            // Lbl_Complemento
            // 
            Lbl_Complemento.AutoSize = true;
            Lbl_Complemento.Location = new Point(628, 72);
            Lbl_Complemento.Name = "Lbl_Complemento";
            Lbl_Complemento.Size = new Size(143, 15);
            Lbl_Complemento.TabIndex = 48;
            Lbl_Complemento.Text = "Complemento (Opcional)";
            // 
            // Txt_UF
            // 
            Txt_UF.Location = new Point(571, 90);
            Txt_UF.Name = "Txt_UF";
            Txt_UF.Size = new Size(48, 23);
            Txt_UF.TabIndex = 15;
            // 
            // Lbl_UF
            // 
            Lbl_UF.AutoSize = true;
            Lbl_UF.Location = new Point(572, 72);
            Lbl_UF.Name = "Lbl_UF";
            Lbl_UF.Size = new Size(21, 15);
            Lbl_UF.TabIndex = 46;
            Lbl_UF.Text = "UF";
            // 
            // Txt_Cidade
            // 
            Txt_Cidade.Location = new Point(393, 90);
            Txt_Cidade.Name = "Txt_Cidade";
            Txt_Cidade.Size = new Size(169, 23);
            Txt_Cidade.TabIndex = 14;
            // 
            // Lbl_Cidade
            // 
            Lbl_Cidade.AutoSize = true;
            Lbl_Cidade.Location = new Point(397, 72);
            Lbl_Cidade.Name = "Lbl_Cidade";
            Lbl_Cidade.Size = new Size(44, 15);
            Lbl_Cidade.TabIndex = 44;
            Lbl_Cidade.Text = "Cidade";
            // 
            // Txt_Bairro
            // 
            Txt_Bairro.Location = new Point(6, 90);
            Txt_Bairro.Name = "Txt_Bairro";
            Txt_Bairro.Size = new Size(381, 23);
            Txt_Bairro.TabIndex = 13;
            // 
            // Lbl_Bairro
            // 
            Lbl_Bairro.AutoSize = true;
            Lbl_Bairro.Location = new Point(6, 72);
            Lbl_Bairro.Name = "Lbl_Bairro";
            Lbl_Bairro.Size = new Size(38, 15);
            Lbl_Bairro.TabIndex = 42;
            Lbl_Bairro.Text = "Bairro";
            // 
            // Txt_Numero
            // 
            Txt_Numero.Location = new Point(628, 46);
            Txt_Numero.Name = "Txt_Numero";
            Txt_Numero.Size = new Size(156, 23);
            Txt_Numero.TabIndex = 12;
            // 
            // Lbl_Numero
            // 
            Lbl_Numero.AutoSize = true;
            Lbl_Numero.Location = new Point(628, 28);
            Lbl_Numero.Name = "Lbl_Numero";
            Lbl_Numero.Size = new Size(51, 15);
            Lbl_Numero.TabIndex = 40;
            Lbl_Numero.Text = "Número";
            // 
            // Txt_Logradouro
            // 
            Txt_Logradouro.Location = new Point(151, 46);
            Txt_Logradouro.Name = "Txt_Logradouro";
            Txt_Logradouro.Size = new Size(455, 23);
            Txt_Logradouro.TabIndex = 11;
            // 
            // Lbl_Endereco
            // 
            Lbl_Endereco.AutoSize = true;
            Lbl_Endereco.Location = new Point(151, 28);
            Lbl_Endereco.Name = "Lbl_Endereco";
            Lbl_Endereco.Size = new Size(27, 15);
            Lbl_Endereco.TabIndex = 38;
            Lbl_Endereco.Text = "Rua";
            // 
            // MTxt_Cep
            // 
            MTxt_Cep.Location = new Point(6, 46);
            MTxt_Cep.Mask = "00000-000";
            MTxt_Cep.Name = "MTxt_Cep";
            MTxt_Cep.Size = new Size(85, 23);
            MTxt_Cep.TabIndex = 10;
            MTxt_Cep.Leave += MTxt_Cep_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 28);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 35;
            label7.Text = "CEP";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Btn_SearchCep);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(MTxt_Cep);
            groupBox1.Controls.Add(Txt_Complemento);
            groupBox1.Controls.Add(Lbl_Complemento);
            groupBox1.Controls.Add(Lbl_Endereco);
            groupBox1.Controls.Add(Txt_UF);
            groupBox1.Controls.Add(Txt_Logradouro);
            groupBox1.Controls.Add(Lbl_UF);
            groupBox1.Controls.Add(Lbl_Numero);
            groupBox1.Controls.Add(Txt_Cidade);
            groupBox1.Controls.Add(Txt_Numero);
            groupBox1.Controls.Add(Lbl_Cidade);
            groupBox1.Controls.Add(Lbl_Bairro);
            groupBox1.Controls.Add(Txt_Bairro);
            groupBox1.Location = new Point(14, 227);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(802, 138);
            groupBox1.TabIndex = 51;
            groupBox1.TabStop = false;
            groupBox1.Text = "Endereço";
            // 
            // Btn_SearchCep
            // 
            Btn_SearchCep.Cursor = Cursors.Hand;
            Btn_SearchCep.FlatAppearance.BorderSize = 0;
            Btn_SearchCep.FlatStyle = FlatStyle.Flat;
            Btn_SearchCep.Image = Properties.Resources.Search;
            Btn_SearchCep.Location = new Point(97, 28);
            Btn_SearchCep.Name = "Btn_SearchCep";
            Btn_SearchCep.Size = new Size(48, 44);
            Btn_SearchCep.TabIndex = 49;
            Btn_SearchCep.UseVisualStyleBackColor = true;
            Btn_SearchCep.Click += Btn_SearchCep_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(Txt_Observacoes);
            groupBox4.Controls.Add(checkedListBox1);
            groupBox4.Location = new Point(14, 371);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(802, 170);
            groupBox4.TabIndex = 52;
            groupBox4.TabStop = false;
            groupBox4.Text = "Apoio Espiritual";
            // 
            // Txt_Observacoes
            // 
            Txt_Observacoes.Location = new Point(6, 117);
            Txt_Observacoes.Multiline = true;
            Txt_Observacoes.Name = "Txt_Observacoes";
            Txt_Observacoes.Size = new Size(790, 47);
            Txt_Observacoes.TabIndex = 0;
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = SystemColors.Menu;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Quero receber Jesus como meu único e suficiente Salvador.", "Quero conhecer melhor a bíblia e gostaria de ajuda.", "Gostaria de uma visita para uma oração na minha casa.", "Gostaria de conhecer melhor a Kingdom", "Gostaria de pedir oração (especifique o motivo abaixo)" });
            checkedListBox1.Location = new Point(6, 22);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(790, 94);
            checkedListBox1.TabIndex = 0;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { novaToolStripButton, abrirToolStripButton, salvarToolStripButton, ApagarToolStripButton, toolStripSeparator, recortarToolStripButton, copiarToolStripButton, colarToolStripButton, toolStripSeparator1, ajudaToolStripButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(830, 25);
            toolStrip1.TabIndex = 53;
            toolStrip1.Text = "toolStrip1";
            // 
            // novaToolStripButton
            // 
            novaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            novaToolStripButton.Image = Properties.Resources.Add_New;
            novaToolStripButton.ImageTransparentColor = Color.Magenta;
            novaToolStripButton.Name = "novaToolStripButton";
            novaToolStripButton.Size = new Size(23, 22);
            novaToolStripButton.Text = "&Nova";
            novaToolStripButton.Click += novaToolStripButton_Click;
            // 
            // abrirToolStripButton
            // 
            abrirToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            abrirToolStripButton.Image = (Image)resources.GetObject("abrirToolStripButton.Image");
            abrirToolStripButton.ImageTransparentColor = Color.Magenta;
            abrirToolStripButton.Name = "abrirToolStripButton";
            abrirToolStripButton.Size = new Size(23, 22);
            abrirToolStripButton.Text = "&Abrir";
            // 
            // salvarToolStripButton
            // 
            salvarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            salvarToolStripButton.Image = Properties.Resources.Save;
            salvarToolStripButton.ImageTransparentColor = Color.Magenta;
            salvarToolStripButton.Name = "salvarToolStripButton";
            salvarToolStripButton.Size = new Size(23, 22);
            salvarToolStripButton.Text = "&Salvar";
            // 
            // ApagarToolStripButton
            // 
            ApagarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ApagarToolStripButton.Image = Properties.Resources.Erase;
            ApagarToolStripButton.ImageTransparentColor = Color.Magenta;
            ApagarToolStripButton.Name = "ApagarToolStripButton";
            ApagarToolStripButton.Size = new Size(23, 22);
            ApagarToolStripButton.Text = "&Apagar";
            ApagarToolStripButton.Click += ApagarToolStripButton_Click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(6, 25);
            // 
            // recortarToolStripButton
            // 
            recortarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            recortarToolStripButton.Image = (Image)resources.GetObject("recortarToolStripButton.Image");
            recortarToolStripButton.ImageTransparentColor = Color.Magenta;
            recortarToolStripButton.Name = "recortarToolStripButton";
            recortarToolStripButton.Size = new Size(23, 22);
            recortarToolStripButton.Text = "R&ecortar";
            // 
            // copiarToolStripButton
            // 
            copiarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            copiarToolStripButton.Image = (Image)resources.GetObject("copiarToolStripButton.Image");
            copiarToolStripButton.ImageTransparentColor = Color.Magenta;
            copiarToolStripButton.Name = "copiarToolStripButton";
            copiarToolStripButton.Size = new Size(23, 22);
            copiarToolStripButton.Text = "&Copiar";
            // 
            // colarToolStripButton
            // 
            colarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            colarToolStripButton.Image = (Image)resources.GetObject("colarToolStripButton.Image");
            colarToolStripButton.ImageTransparentColor = Color.Magenta;
            colarToolStripButton.Name = "colarToolStripButton";
            colarToolStripButton.Size = new Size(23, 22);
            colarToolStripButton.Text = "&Colar";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // ajudaToolStripButton
            // 
            ajudaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ajudaToolStripButton.Image = (Image)resources.GetObject("ajudaToolStripButton.Image");
            ajudaToolStripButton.ImageTransparentColor = Color.Magenta;
            ajudaToolStripButton.Name = "ajudaToolStripButton";
            ajudaToolStripButton.Size = new Size(23, 22);
            ajudaToolStripButton.Text = "Aju&da";
            // 
            // Frm_LeaderRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(toolStrip1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Controls.Add(Grp_dadosPessoais);
            Controls.Add(Grp_codigo);
            Name = "Frm_LeaderRegistration";
            Size = new Size(830, 559);
            Grp_codigo.ResumeLayout(false);
            Grp_codigo.PerformLayout();
            Grp_dadosPessoais.ResumeLayout(false);
            Grp_dadosPessoais.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Txt_ID;
        private MaskedTextBox MTxt_DataNascimento;
        private GroupBox Grp_codigo;
        private GroupBox Grp_dadosPessoais;
        private Label label1;
        private TextBox Txt_Nome;
        private TextBox Txt_Email;
        private Label label3;
        private Label label2;
        private TextBox Txt_Complemento;
        private Label Lbl_Complemento;
        private TextBox Txt_UF;
        private Label Lbl_UF;
        private TextBox Txt_Cidade;
        private Label Lbl_Cidade;
        private TextBox Txt_Bairro;
        private Label Lbl_Bairro;
        private TextBox Txt_Numero;
        private Label Lbl_Numero;
        private TextBox Txt_Logradouro;
        private Label Lbl_Endereco;
        private MaskedTextBox MTxt_Cep;
        private Label label7;
        private GroupBox groupBox2;
        private RadioButton Rb_CristaoNao;
        private RadioButton Rb_CristaoSim;
        private Label label4;
        private MaskedTextBox MTxt_Telefone;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private RadioButton Rb_FreqIgrejaNao;
        private RadioButton Rb_FreqIgrejaSim;
        private GroupBox groupBox4;
        private CheckedListBox checkedListBox1;
        private TextBox Txt_Observacoes;
        private ToolStrip toolStrip1;
        private ToolStripButton novaToolStripButton;
        private ToolStripButton abrirToolStripButton;
        private ToolStripButton salvarToolStripButton;
        private ToolStripButton ApagarToolStripButton;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton recortarToolStripButton;
        private ToolStripButton copiarToolStripButton;
        private ToolStripButton colarToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton ajudaToolStripButton;
        private Button Btn_SearchCep;
    }
}
