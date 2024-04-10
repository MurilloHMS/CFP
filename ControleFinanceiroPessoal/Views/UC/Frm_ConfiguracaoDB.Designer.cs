namespace ControleFinanceiroPessoal.Forms.UC
{
    partial class Frm_DataBaseSettings_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DataBaseSettings_UC));
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            pictureBox1 = new PictureBox();
            Btn_CriarTabelas = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(42, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(330, 23);
            textBox1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(42, 128);
            label2.Name = "label2";
            label2.Size = new Size(133, 31);
            label2.TabIndex = 3;
            label2.Text = "Usuário";
            label2.TextAlign = ContentAlignment.BottomCenter;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(42, 166);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(330, 23);
            textBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(42, 205);
            label3.Name = "label3";
            label3.Size = new Size(133, 31);
            label3.TabIndex = 5;
            label3.Text = "Senha";
            label3.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(42, 40);
            label1.Name = "label1";
            label1.Size = new Size(246, 31);
            label1.TabIndex = 6;
            label1.Text = "Endereço do Banco de Dados";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Location = new Point(42, 243);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(330, 23);
            textBox3.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(430, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 195);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Btn_CriarTabelas
            // 
            Btn_CriarTabelas.Location = new Point(506, 279);
            Btn_CriarTabelas.Name = "Btn_CriarTabelas";
            Btn_CriarTabelas.Size = new Size(75, 23);
            Btn_CriarTabelas.TabIndex = 9;
            Btn_CriarTabelas.Text = "Criar Tabelas SQL";
            Btn_CriarTabelas.UseVisualStyleBackColor = true;
            Btn_CriarTabelas.Click += Btn_CriarTabelas_Click;
            // 
            // Frm_DataBaseSettings_UC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Btn_CriarTabelas);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Frm_DataBaseSettings_UC";
            Size = new Size(678, 410);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Label label1;
        private TextBox textBox3;
        private PictureBox pictureBox1;
        private Button Btn_CriarTabelas;
    }
}
