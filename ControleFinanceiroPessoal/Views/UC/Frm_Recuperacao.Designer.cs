namespace ControleFinanceiroPessoal.Views.UC
{
    partial class Frm_Recuperacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Recuperacao));
            toolStrip1 = new ToolStrip();
            salvarToolStripButton = new ToolStripButton();
            LimparToolStripButton = new ToolStripButton();
            toolStripSeparator = new ToolStripSeparator();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            toolStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { salvarToolStripButton, LimparToolStripButton, toolStripSeparator });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(809, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // salvarToolStripButton
            // 
            salvarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            salvarToolStripButton.Image = (Image)resources.GetObject("salvarToolStripButton.Image");
            salvarToolStripButton.ImageTransparentColor = Color.Magenta;
            salvarToolStripButton.Name = "salvarToolStripButton";
            salvarToolStripButton.Size = new Size(23, 22);
            salvarToolStripButton.Text = "&Salvar";
            // 
            // LimparToolStripButton
            // 
            LimparToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            LimparToolStripButton.Image = Properties.Resources.Broom;
            LimparToolStripButton.ImageTransparentColor = Color.Magenta;
            LimparToolStripButton.Name = "LimparToolStripButton";
            LimparToolStripButton.Size = new Size(23, 22);
            LimparToolStripButton.Text = "&Limpar";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(6, 25);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(3, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(789, 284);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados de Recuperação";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(21, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(511, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 42);
            label1.Name = "label1";
            label1.Size = new Size(128, 15);
            label1.TabIndex = 1;
            label1.Text = "E-mail de Recuperação";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 97);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 3;
            label2.Text = "Código de Verificação";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(21, 115);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(511, 23);
            textBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 141);
            label3.Name = "label3";
            label3.Size = new Size(210, 15);
            label3.TabIndex = 4;
            label3.Text = "Não recebeu o Código de Verificação? ";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(237, 141);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(107, 15);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Enviar Novamente!";
            // 
            // Frm_Recuperacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(toolStrip1);
            Name = "Frm_Recuperacao";
            Size = new Size(809, 333);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton salvarToolStripButton;
        private ToolStripButton LimparToolStripButton;
        private ToolStripSeparator toolStripSeparator;
        private GroupBox groupBox1;
        private LinkLabel linkLabel1;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
    }
}
