namespace ControleFinanceiroPessoal.Views.UC
{
    partial class Frm_OrganizeDirectories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_OrganizeDirectories));
            Txt_CaminhoOrigem = new TextBox();
            Lbl_CaminhoOrigem = new Label();
            Lbl_CaminhoDestino = new Label();
            Txt_CaminhoDestino = new TextBox();
            Txt_Log = new TextBox();
            Btn_CaminhoOrigem = new Button();
            Btn_CaminhoDestino = new Button();
            toolStrip1 = new ToolStrip();
            novaToolStripButton = new ToolStripButton();
            abrirToolStripButton = new ToolStripButton();
            salvarToolStripButton = new ToolStripButton();
            imprimirToolStripButton = new ToolStripButton();
            toolStripSeparator = new ToolStripSeparator();
            recortarToolStripButton = new ToolStripButton();
            copiarToolStripButton = new ToolStripButton();
            colarToolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            ajudaToolStripButton = new ToolStripButton();
            Pgb_Log = new ProgressBar();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Txt_CaminhoOrigem
            // 
            Txt_CaminhoOrigem.Location = new Point(27, 57);
            Txt_CaminhoOrigem.Name = "Txt_CaminhoOrigem";
            Txt_CaminhoOrigem.Size = new Size(248, 23);
            Txt_CaminhoOrigem.TabIndex = 0;
            // 
            // Lbl_CaminhoOrigem
            // 
            Lbl_CaminhoOrigem.AutoSize = true;
            Lbl_CaminhoOrigem.Location = new Point(27, 39);
            Lbl_CaminhoOrigem.Name = "Lbl_CaminhoOrigem";
            Lbl_CaminhoOrigem.Size = new Size(99, 15);
            Lbl_CaminhoOrigem.TabIndex = 1;
            Lbl_CaminhoOrigem.Text = "Caminho Origem";
            // 
            // Lbl_CaminhoDestino
            // 
            Lbl_CaminhoDestino.AutoSize = true;
            Lbl_CaminhoDestino.Location = new Point(319, 39);
            Lbl_CaminhoDestino.Name = "Lbl_CaminhoDestino";
            Lbl_CaminhoDestino.Size = new Size(99, 15);
            Lbl_CaminhoDestino.TabIndex = 4;
            Lbl_CaminhoDestino.Text = "Caminho Destino";
            // 
            // Txt_CaminhoDestino
            // 
            Txt_CaminhoDestino.Location = new Point(319, 57);
            Txt_CaminhoDestino.Name = "Txt_CaminhoDestino";
            Txt_CaminhoDestino.Size = new Size(248, 23);
            Txt_CaminhoDestino.TabIndex = 3;
            // 
            // Txt_Log
            // 
            Txt_Log.Location = new Point(27, 102);
            Txt_Log.Multiline = true;
            Txt_Log.Name = "Txt_Log";
            Txt_Log.ReadOnly = true;
            Txt_Log.ScrollBars = ScrollBars.Both;
            Txt_Log.Size = new Size(578, 208);
            Txt_Log.TabIndex = 5;
            Txt_Log.WordWrap = false;
            // 
            // Btn_CaminhoOrigem
            // 
            Btn_CaminhoOrigem.Location = new Point(281, 57);
            Btn_CaminhoOrigem.Name = "Btn_CaminhoOrigem";
            Btn_CaminhoOrigem.Size = new Size(32, 23);
            Btn_CaminhoOrigem.TabIndex = 6;
            Btn_CaminhoOrigem.Text = "...";
            Btn_CaminhoOrigem.UseVisualStyleBackColor = true;
            Btn_CaminhoOrigem.Click += Btn_CaminhoOrigem_Click;
            // 
            // Btn_CaminhoDestino
            // 
            Btn_CaminhoDestino.Location = new Point(573, 57);
            Btn_CaminhoDestino.Name = "Btn_CaminhoDestino";
            Btn_CaminhoDestino.Size = new Size(32, 23);
            Btn_CaminhoDestino.TabIndex = 7;
            Btn_CaminhoDestino.Text = "...";
            Btn_CaminhoDestino.UseVisualStyleBackColor = true;
            Btn_CaminhoDestino.Click += Btn_CaminhoDestino_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { novaToolStripButton, abrirToolStripButton, salvarToolStripButton, imprimirToolStripButton, toolStripSeparator, recortarToolStripButton, copiarToolStripButton, colarToolStripButton, toolStripSeparator1, ajudaToolStripButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(635, 25);
            toolStrip1.TabIndex = 8;
            toolStrip1.Text = "toolStrip1";
            // 
            // novaToolStripButton
            // 
            novaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            novaToolStripButton.Image = (Image)resources.GetObject("novaToolStripButton.Image");
            novaToolStripButton.ImageTransparentColor = Color.Magenta;
            novaToolStripButton.Name = "novaToolStripButton";
            novaToolStripButton.Size = new Size(23, 22);
            novaToolStripButton.Text = "&Nova";
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
            salvarToolStripButton.Image = (Image)resources.GetObject("salvarToolStripButton.Image");
            salvarToolStripButton.ImageTransparentColor = Color.Magenta;
            salvarToolStripButton.Name = "salvarToolStripButton";
            salvarToolStripButton.Size = new Size(23, 22);
            salvarToolStripButton.Text = "&Salvar";
            salvarToolStripButton.Click += salvarToolStripButton_Click;
            // 
            // imprimirToolStripButton
            // 
            imprimirToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            imprimirToolStripButton.Image = (Image)resources.GetObject("imprimirToolStripButton.Image");
            imprimirToolStripButton.ImageTransparentColor = Color.Magenta;
            imprimirToolStripButton.Name = "imprimirToolStripButton";
            imprimirToolStripButton.Size = new Size(23, 22);
            imprimirToolStripButton.Text = "&Imprimir";
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
            // Pgb_Log
            // 
            Pgb_Log.Location = new Point(27, 341);
            Pgb_Log.Name = "Pgb_Log";
            Pgb_Log.Size = new Size(578, 23);
            Pgb_Log.TabIndex = 9;
            // 
            // Frm_OrganizeDirectories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Pgb_Log);
            Controls.Add(toolStrip1);
            Controls.Add(Btn_CaminhoDestino);
            Controls.Add(Btn_CaminhoOrigem);
            Controls.Add(Txt_Log);
            Controls.Add(Lbl_CaminhoDestino);
            Controls.Add(Txt_CaminhoDestino);
            Controls.Add(Lbl_CaminhoOrigem);
            Controls.Add(Txt_CaminhoOrigem);
            Name = "Frm_OrganizeDirectories";
            Size = new Size(635, 376);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Txt_CaminhoOrigem;
        private Label Lbl_CaminhoOrigem;
        private Label Lbl_CaminhoDestino;
        private TextBox Txt_CaminhoDestino;
        private TextBox Txt_Log;
        private Button Btn_CaminhoOrigem;
        private Button Btn_CaminhoDestino;
        private ToolStrip toolStrip1;
        private ToolStripButton novaToolStripButton;
        private ToolStripButton abrirToolStripButton;
        private ToolStripButton salvarToolStripButton;
        private ToolStripButton imprimirToolStripButton;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton recortarToolStripButton;
        private ToolStripButton copiarToolStripButton;
        private ToolStripButton colarToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton ajudaToolStripButton;
        private ProgressBar Pgb_Log;
    }
}
