namespace ControleFinanceiroPessoal.Views.UC
{
    partial class Frm_LancamentosFinanceiro
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
            label1 = new Label();
            Txt_ID = new TextBox();
            CB_TipoLancamento = new ComboBox();
            Dtp_Vencimento = new DateTimePicker();
            groupBox1 = new GroupBox();
            Btn_Cancelar = new Button();
            Btn_Inserir = new Button();
            label7 = new Label();
            CB_Categorias = new ComboBox();
            label6 = new Label();
            Txt_Descricao = new TextBox();
            label5 = new Label();
            CB_TipoEvento = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            Txt_Valor = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 34);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Codigo";
            // 
            // Txt_ID
            // 
            Txt_ID.Location = new Point(41, 52);
            Txt_ID.Name = "Txt_ID";
            Txt_ID.Size = new Size(46, 23);
            Txt_ID.TabIndex = 1;
            // 
            // CB_TipoLancamento
            // 
            CB_TipoLancamento.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_TipoLancamento.FormattingEnabled = true;
            CB_TipoLancamento.Items.AddRange(new object[] { "ENTRADA", "SAIDA" });
            CB_TipoLancamento.Location = new Point(39, 115);
            CB_TipoLancamento.Name = "CB_TipoLancamento";
            CB_TipoLancamento.Size = new Size(147, 23);
            CB_TipoLancamento.TabIndex = 2;
            CB_TipoLancamento.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            CB_TipoLancamento.TextUpdate += comboBox1_TextUpdate;
            // 
            // Dtp_Vencimento
            // 
            Dtp_Vencimento.CustomFormat = "";
            Dtp_Vencimento.Format = DateTimePickerFormat.Short;
            Dtp_Vencimento.Location = new Point(298, 115);
            Dtp_Vencimento.Name = "Dtp_Vencimento";
            Dtp_Vencimento.Size = new Size(114, 23);
            Dtp_Vencimento.TabIndex = 3;
            Dtp_Vencimento.Value = new DateTime(2024, 3, 30, 0, 0, 0, 0);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Btn_Cancelar);
            groupBox1.Controls.Add(Btn_Inserir);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(CB_Categorias);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(Txt_Descricao);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(CB_TipoEvento);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(Txt_Valor);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(Dtp_Vencimento);
            groupBox1.Controls.Add(Txt_ID);
            groupBox1.Controls.Add(CB_TipoLancamento);
            groupBox1.Location = new Point(13, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(802, 500);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações";
            // 
            // Btn_Cancelar
            // 
            Btn_Cancelar.Location = new Point(404, 458);
            Btn_Cancelar.Name = "Btn_Cancelar";
            Btn_Cancelar.Size = new Size(75, 23);
            Btn_Cancelar.TabIndex = 14;
            Btn_Cancelar.Text = "Cancelar";
            Btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // Btn_Inserir
            // 
            Btn_Inserir.Location = new Point(323, 458);
            Btn_Inserir.Name = "Btn_Inserir";
            Btn_Inserir.Size = new Size(75, 23);
            Btn_Inserir.TabIndex = 14;
            Btn_Inserir.Text = "Inserir";
            Btn_Inserir.UseVisualStyleBackColor = true;
            Btn_Inserir.Click += Btn_Inserir_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(578, 100);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 13;
            label7.Text = "Categoria";
            // 
            // CB_Categorias
            // 
            CB_Categorias.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_Categorias.FormattingEnabled = true;
            CB_Categorias.Location = new Point(578, 118);
            CB_Categorias.Name = "CB_Categorias";
            CB_Categorias.Size = new Size(179, 23);
            CB_Categorias.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 155);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 10;
            label6.Text = "Descrição";
            // 
            // Txt_Descricao
            // 
            Txt_Descricao.Location = new Point(24, 173);
            Txt_Descricao.Multiline = true;
            Txt_Descricao.Name = "Txt_Descricao";
            Txt_Descricao.Size = new Size(751, 236);
            Txt_Descricao.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(418, 100);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 9;
            label5.Text = "Tipo Evento";
            // 
            // CB_TipoEvento
            // 
            CB_TipoEvento.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_TipoEvento.FormattingEnabled = true;
            CB_TipoEvento.Items.AddRange(new object[] { "QUARTA-FIRE", "DOMINGO", "EVENTO" });
            CB_TipoEvento.Location = new Point(418, 118);
            CB_TipoEvento.Name = "CB_TipoEvento";
            CB_TipoEvento.Size = new Size(154, 23);
            CB_TipoEvento.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(298, 97);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 7;
            label4.Text = "Data De Vencimento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(192, 97);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 5;
            label3.Text = "Valor";
            // 
            // Txt_Valor
            // 
            Txt_Valor.Location = new Point(192, 115);
            Txt_Valor.Name = "Txt_Valor";
            Txt_Valor.Size = new Size(100, 23);
            Txt_Valor.TabIndex = 6;
            Txt_Valor.TextChanged += TXT_Valor_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 97);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 4;
            label2.Text = "Tipo lançamento";
            // 
            // Frm_LancamentosFinanceiro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "Frm_LancamentosFinanceiro";
            Size = new Size(829, 550);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox Txt_ID;
        private ComboBox CB_TipoLancamento;
        private DateTimePicker Dtp_Vencimento;
        private GroupBox groupBox1;
        private Label label2;
        private Label label4;
        private Label label3;
        private TextBox Txt_Valor;
        private Label label5;
        private ComboBox CB_TipoEvento;
        private Label label6;
        private TextBox Txt_Descricao;
        private Label label7;
        private ComboBox CB_Categorias;
        private Button Btn_Cancelar;
        private Button Btn_Inserir;
    }
}
