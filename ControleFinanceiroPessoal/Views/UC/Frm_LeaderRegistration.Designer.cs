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
            maskedTextBox1 = new MaskedTextBox();
            Grp_codigo = new GroupBox();
            Grp_dadosPessoais = new GroupBox();
            groupBox3 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            groupBox2 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label4 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox9 = new TextBox();
            Lbl_Complemento = new Label();
            textBox8 = new TextBox();
            Lbl_UF = new Label();
            textBox7 = new TextBox();
            Lbl_Cidade = new Label();
            textBox6 = new TextBox();
            Lbl_Bairro = new Label();
            textBox5 = new TextBox();
            Lbl_Numero = new Label();
            textBox4 = new TextBox();
            Lbl_Endereco = new Label();
            button2 = new Button();
            maskedTextBox5 = new MaskedTextBox();
            label7 = new Label();
            groupBox1 = new GroupBox();
            groupBox4 = new GroupBox();
            textBox10 = new TextBox();
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
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(397, 37);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(133, 23);
            maskedTextBox1.TabIndex = 3;
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
            Grp_dadosPessoais.Controls.Add(maskedTextBox2);
            Grp_dadosPessoais.Controls.Add(textBox3);
            Grp_dadosPessoais.Controls.Add(label3);
            Grp_dadosPessoais.Controls.Add(label2);
            Grp_dadosPessoais.Controls.Add(textBox2);
            Grp_dadosPessoais.Controls.Add(maskedTextBox1);
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
            groupBox3.Controls.Add(radioButton3);
            groupBox3.Controls.Add(radioButton4);
            groupBox3.Location = new Point(615, 19);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(169, 85);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Frequenta alguma Igreja?";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(13, 47);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(47, 19);
            radioButton3.TabIndex = 9;
            radioButton3.TabStop = true;
            radioButton3.Text = "Não";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(13, 22);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(45, 19);
            radioButton4.TabIndex = 8;
            radioButton4.TabStop = true;
            radioButton4.Text = "Sim";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Location = new Point(536, 19);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(73, 85);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "É Cristão?";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(12, 47);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(47, 19);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "Não";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(12, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(45, 19);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "Sim";
            radioButton1.UseVisualStyleBackColor = true;
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
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(393, 81);
            maskedTextBox2.Mask = "(00) 0 0000-0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(133, 23);
            maskedTextBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(6, 81);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(381, 23);
            textBox3.TabIndex = 4;
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
            // textBox2
            // 
            textBox2.Location = new Point(6, 37);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(381, 23);
            textBox2.TabIndex = 2;
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
            // textBox9
            // 
            textBox9.Location = new Point(627, 90);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(157, 23);
            textBox9.TabIndex = 16;
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
            // textBox8
            // 
            textBox8.Location = new Point(571, 90);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(48, 23);
            textBox8.TabIndex = 15;
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
            // textBox7
            // 
            textBox7.Location = new Point(393, 90);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(169, 23);
            textBox7.TabIndex = 14;
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
            // textBox6
            // 
            textBox6.Location = new Point(6, 90);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(381, 23);
            textBox6.TabIndex = 13;
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
            // textBox5
            // 
            textBox5.Location = new Point(628, 46);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(156, 23);
            textBox5.TabIndex = 12;
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
            // textBox4
            // 
            textBox4.Location = new Point(151, 46);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(455, 23);
            textBox4.TabIndex = 11;
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
            // button2
            // 
            button2.Location = new Point(112, 46);
            button2.Name = "button2";
            button2.Size = new Size(33, 23);
            button2.TabIndex = 37;
            button2.Text = "...";
            button2.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox5
            // 
            maskedTextBox5.Location = new Point(6, 46);
            maskedTextBox5.Name = "maskedTextBox5";
            maskedTextBox5.Size = new Size(100, 23);
            maskedTextBox5.TabIndex = 10;
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
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(maskedTextBox5);
            groupBox1.Controls.Add(textBox9);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(Lbl_Complemento);
            groupBox1.Controls.Add(Lbl_Endereco);
            groupBox1.Controls.Add(textBox8);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(Lbl_UF);
            groupBox1.Controls.Add(Lbl_Numero);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(Lbl_Cidade);
            groupBox1.Controls.Add(Lbl_Bairro);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Location = new Point(14, 227);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(802, 138);
            groupBox1.TabIndex = 51;
            groupBox1.TabStop = false;
            groupBox1.Text = "Endereço";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBox10);
            groupBox4.Controls.Add(checkedListBox1);
            groupBox4.Location = new Point(14, 371);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(802, 170);
            groupBox4.TabIndex = 52;
            groupBox4.TabStop = false;
            groupBox4.Text = "Apoio Espiritual";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(6, 117);
            textBox10.Multiline = true;
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(790, 47);
            textBox10.TabIndex = 0;
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
        private MaskedTextBox maskedTextBox1;
        private GroupBox Grp_codigo;
        private GroupBox Grp_dadosPessoais;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label3;
        private Label label2;
        private TextBox textBox9;
        private Label Lbl_Complemento;
        private TextBox textBox8;
        private Label Lbl_UF;
        private TextBox textBox7;
        private Label Lbl_Cidade;
        private TextBox textBox6;
        private Label Lbl_Bairro;
        private TextBox textBox5;
        private Label Lbl_Numero;
        private TextBox textBox4;
        private Label Lbl_Endereco;
        private Button button2;
        private MaskedTextBox maskedTextBox5;
        private Label label7;
        private GroupBox groupBox2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label4;
        private MaskedTextBox maskedTextBox2;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private GroupBox groupBox4;
        private CheckedListBox checkedListBox1;
        private TextBox textBox10;
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
    }
}
