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
            textBox1 = new TextBox();
            CB_TipoLancamento = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            groupBox1 = new GroupBox();
            label7 = new Label();
            CB_Categorias = new ComboBox();
            label6 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            comboBox2 = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 34);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Codigo";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(24, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(46, 23);
            textBox1.TabIndex = 1;
            // 
            // CB_TipoLancamento
            // 
            CB_TipoLancamento.FormattingEnabled = true;
            CB_TipoLancamento.Items.AddRange(new object[] { "RECEITA", "DESPESA" });
            CB_TipoLancamento.Location = new Point(24, 115);
            CB_TipoLancamento.Name = "CB_TipoLancamento";
            CB_TipoLancamento.Size = new Size(109, 23);
            CB_TipoLancamento.TabIndex = 2;
            CB_TipoLancamento.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            CB_TipoLancamento.TextUpdate += comboBox1_TextUpdate;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(292, 115);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(114, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(CB_Categorias);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(CB_TipoLancamento);
            groupBox1.Location = new Point(12, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(788, 506);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(614, 97);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 13;
            label7.Text = "Categoria";
            // 
            // CB_Categorias
            // 
            CB_Categorias.FormattingEnabled = true;
            CB_Categorias.Location = new Point(614, 115);
            CB_Categorias.Name = "CB_Categorias";
            CB_Categorias.Size = new Size(109, 23);
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
            // textBox3
            // 
            textBox3.Location = new Point(24, 173);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(718, 236);
            textBox3.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(459, 97);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 9;
            label5.Text = "Tipo Evento";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "QUARTA-FIRE", "DOMINGO", "EVENTO" });
            comboBox2.Location = new Point(459, 115);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(109, 23);
            comboBox2.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(292, 97);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 7;
            label4.Text = "Data De Vencimento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(157, 97);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 5;
            label3.Text = "Valor";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(157, 115);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 97);
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
        private TextBox textBox1;
        private ComboBox CB_TipoLancamento;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private Label label5;
        private ComboBox comboBox2;
        private Label label6;
        private TextBox textBox3;
        private Label label7;
        private ComboBox CB_Categorias;
    }
}
