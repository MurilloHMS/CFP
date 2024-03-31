namespace ControleFinanceiroPessoal.Views.UC
{
    partial class Frm_ForaDaCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ForaDaCaixa));
            Clb_Lideres = new CheckedListBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            Clb_Membros = new CheckedListBox();
            groupBox3 = new GroupBox();
            Btn_SearchCep = new Button();
            label7 = new Label();
            MTxt_Cep = new MaskedTextBox();
            Txt_Complemento = new TextBox();
            Lbl_Complemento = new Label();
            Lbl_Endereco = new Label();
            Txt_UF = new TextBox();
            Txt_Logradouro = new TextBox();
            Lbl_UF = new Label();
            Lbl_Numero = new Label();
            Txt_Cidade = new TextBox();
            Txt_Numero = new TextBox();
            Lbl_Cidade = new Label();
            Lbl_Bairro = new Label();
            Txt_Bairro = new TextBox();
            Grp_codigo = new GroupBox();
            Btn_BuscaMinisterios = new Button();
            Txt_ID = new TextBox();
            toolStrip1 = new ToolStrip();
            novaToolStripButton = new ToolStripButton();
            abrirToolStripButton = new ToolStripButton();
            ApagarToolStripButton = new ToolStripButton();
            salvarToolStripButton = new ToolStripButton();
            recortarToolStripButton = new ToolStripButton();
            toolStripSeparator = new ToolStripSeparator();
            ajudaToolStripButton = new ToolStripButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            Grp_codigo.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Clb_Lideres
            // 
            Clb_Lideres.FormattingEnabled = true;
            Clb_Lideres.Location = new Point(6, 25);
            Clb_Lideres.Name = "Clb_Lideres";
            Clb_Lideres.Size = new Size(377, 220);
            Clb_Lideres.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Clb_Lideres);
            groupBox1.Location = new Point(18, 252);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(389, 245);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Lideres";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Clb_Membros);
            groupBox2.Location = new Point(415, 252);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(405, 245);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dados Membros";
            // 
            // Clb_Membros
            // 
            Clb_Membros.FormattingEnabled = true;
            Clb_Membros.Location = new Point(6, 25);
            Clb_Membros.Name = "Clb_Membros";
            Clb_Membros.Size = new Size(393, 220);
            Clb_Membros.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(Btn_SearchCep);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(MTxt_Cep);
            groupBox3.Controls.Add(Txt_Complemento);
            groupBox3.Controls.Add(Lbl_Complemento);
            groupBox3.Controls.Add(Lbl_Endereco);
            groupBox3.Controls.Add(Txt_UF);
            groupBox3.Controls.Add(Txt_Logradouro);
            groupBox3.Controls.Add(Lbl_UF);
            groupBox3.Controls.Add(Lbl_Numero);
            groupBox3.Controls.Add(Txt_Cidade);
            groupBox3.Controls.Add(Txt_Numero);
            groupBox3.Controls.Add(Lbl_Cidade);
            groupBox3.Controls.Add(Lbl_Bairro);
            groupBox3.Controls.Add(Txt_Bairro);
            groupBox3.Location = new Point(18, 108);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(802, 138);
            groupBox3.TabIndex = 52;
            groupBox3.TabStop = false;
            groupBox3.Text = "Endereço";
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
            // MTxt_Cep
            // 
            MTxt_Cep.Location = new Point(6, 46);
            MTxt_Cep.Mask = "00000-000";
            MTxt_Cep.Name = "MTxt_Cep";
            MTxt_Cep.Size = new Size(85, 23);
            MTxt_Cep.TabIndex = 10;
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
            // Lbl_Endereco
            // 
            Lbl_Endereco.AutoSize = true;
            Lbl_Endereco.Location = new Point(151, 28);
            Lbl_Endereco.Name = "Lbl_Endereco";
            Lbl_Endereco.Size = new Size(27, 15);
            Lbl_Endereco.TabIndex = 38;
            Lbl_Endereco.Text = "Rua";
            // 
            // Txt_UF
            // 
            Txt_UF.Location = new Point(571, 90);
            Txt_UF.Name = "Txt_UF";
            Txt_UF.Size = new Size(48, 23);
            Txt_UF.TabIndex = 15;
            // 
            // Txt_Logradouro
            // 
            Txt_Logradouro.Location = new Point(151, 46);
            Txt_Logradouro.Name = "Txt_Logradouro";
            Txt_Logradouro.Size = new Size(455, 23);
            Txt_Logradouro.TabIndex = 11;
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
            // Lbl_Numero
            // 
            Lbl_Numero.AutoSize = true;
            Lbl_Numero.Location = new Point(628, 28);
            Lbl_Numero.Name = "Lbl_Numero";
            Lbl_Numero.Size = new Size(51, 15);
            Lbl_Numero.TabIndex = 40;
            Lbl_Numero.Text = "Número";
            // 
            // Txt_Cidade
            // 
            Txt_Cidade.Location = new Point(393, 90);
            Txt_Cidade.Name = "Txt_Cidade";
            Txt_Cidade.Size = new Size(169, 23);
            Txt_Cidade.TabIndex = 14;
            // 
            // Txt_Numero
            // 
            Txt_Numero.Location = new Point(628, 46);
            Txt_Numero.Name = "Txt_Numero";
            Txt_Numero.Size = new Size(156, 23);
            Txt_Numero.TabIndex = 12;
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
            // Lbl_Bairro
            // 
            Lbl_Bairro.AutoSize = true;
            Lbl_Bairro.Location = new Point(6, 72);
            Lbl_Bairro.Name = "Lbl_Bairro";
            Lbl_Bairro.Size = new Size(38, 15);
            Lbl_Bairro.TabIndex = 42;
            Lbl_Bairro.Text = "Bairro";
            // 
            // Txt_Bairro
            // 
            Txt_Bairro.Location = new Point(6, 90);
            Txt_Bairro.Name = "Txt_Bairro";
            Txt_Bairro.Size = new Size(381, 23);
            Txt_Bairro.TabIndex = 13;
            // 
            // Grp_codigo
            // 
            Grp_codigo.Controls.Add(Btn_BuscaMinisterios);
            Grp_codigo.Controls.Add(Txt_ID);
            Grp_codigo.Location = new Point(18, 40);
            Grp_codigo.Name = "Grp_codigo";
            Grp_codigo.Size = new Size(200, 62);
            Grp_codigo.TabIndex = 53;
            Grp_codigo.TabStop = false;
            Grp_codigo.Text = "Código";
            // 
            // Btn_BuscaMinisterios
            // 
            Btn_BuscaMinisterios.Cursor = Cursors.Hand;
            Btn_BuscaMinisterios.FlatAppearance.BorderSize = 0;
            Btn_BuscaMinisterios.FlatStyle = FlatStyle.Flat;
            Btn_BuscaMinisterios.Image = Properties.Resources.Search;
            Btn_BuscaMinisterios.Location = new Point(130, 10);
            Btn_BuscaMinisterios.Name = "Btn_BuscaMinisterios";
            Btn_BuscaMinisterios.Size = new Size(48, 44);
            Btn_BuscaMinisterios.TabIndex = 50;
            Btn_BuscaMinisterios.UseVisualStyleBackColor = true;
            // 
            // Txt_ID
            // 
            Txt_ID.Location = new Point(6, 22);
            Txt_ID.Name = "Txt_ID";
            Txt_ID.Size = new Size(111, 23);
            Txt_ID.TabIndex = 1;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { novaToolStripButton, abrirToolStripButton, ApagarToolStripButton, salvarToolStripButton, recortarToolStripButton, toolStripSeparator, ajudaToolStripButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(837, 25);
            toolStrip1.TabIndex = 54;
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
            abrirToolStripButton.Text = "&Buscar";
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
            // salvarToolStripButton
            // 
            salvarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            salvarToolStripButton.Image = Properties.Resources.Save;
            salvarToolStripButton.ImageTransparentColor = Color.Magenta;
            salvarToolStripButton.Name = "salvarToolStripButton";
            salvarToolStripButton.Size = new Size(23, 22);
            salvarToolStripButton.Text = "&Salvar";
            // 
            // recortarToolStripButton
            // 
            recortarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            recortarToolStripButton.Image = Properties.Resources.Delete_2;
            recortarToolStripButton.ImageTransparentColor = Color.Magenta;
            recortarToolStripButton.Name = "recortarToolStripButton";
            recortarToolStripButton.Size = new Size(23, 22);
            recortarToolStripButton.Text = "&Deletar";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(6, 25);
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
            // Frm_ForaDaCaixa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(toolStrip1);
            Controls.Add(Grp_codigo);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Frm_ForaDaCaixa";
            Size = new Size(837, 529);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            Grp_codigo.ResumeLayout(false);
            Grp_codigo.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox Clb_Lideres;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private CheckedListBox Clb_Membros;
        private GroupBox groupBox3;
        private Button Btn_SearchCep;
        private Label label7;
        private MaskedTextBox MTxt_Cep;
        private TextBox Txt_Complemento;
        private Label Lbl_Complemento;
        private Label Lbl_Endereco;
        private TextBox Txt_UF;
        private TextBox Txt_Logradouro;
        private Label Lbl_UF;
        private Label Lbl_Numero;
        private TextBox Txt_Cidade;
        private TextBox Txt_Numero;
        private Label Lbl_Cidade;
        private Label Lbl_Bairro;
        private TextBox Txt_Bairro;
        private GroupBox Grp_codigo;
        private Button Btn_BuscaMinisterios;
        private TextBox Txt_ID;
        private ToolStrip toolStrip1;
        private ToolStripButton novaToolStripButton;
        private ToolStripButton abrirToolStripButton;
        private ToolStripButton ApagarToolStripButton;
        private ToolStripButton salvarToolStripButton;
        private ToolStripButton recortarToolStripButton;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton ajudaToolStripButton;
    }
}
