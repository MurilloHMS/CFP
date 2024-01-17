namespace ControleFinanceiroPessoal
{
    partial class Frm_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            Mns_Finance = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            conectarToolStripMenuItem = new ToolStripMenuItem();
            desconectarToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            cadastrarNovoUsuárioToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeLíderesToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeMembrosToolStripMenuItem = new ToolStripMenuItem();
            exibirToolStripMenuItem = new ToolStripMenuItem();
            ferramentasToolStripMenuItem = new ToolStripMenuItem();
            configuraçõesBancoDeDadosToolStripMenuItem = new ToolStripMenuItem();
            tbc_Finance = new TabControl();
            Iml_Menu = new ImageList(components);
            Mns_Finance.SuspendLayout();
            SuspendLayout();
            // 
            // Mns_Finance
            // 
            Mns_Finance.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, cadastroToolStripMenuItem, exibirToolStripMenuItem, ferramentasToolStripMenuItem });
            Mns_Finance.Location = new Point(0, 0);
            Mns_Finance.Name = "Mns_Finance";
            Mns_Finance.Size = new Size(834, 24);
            Mns_Finance.TabIndex = 0;
            Mns_Finance.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { conectarToolStripMenuItem, desconectarToolStripMenuItem, sairToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // conectarToolStripMenuItem
            // 
            conectarToolStripMenuItem.Image = (Image)resources.GetObject("conectarToolStripMenuItem.Image");
            conectarToolStripMenuItem.Name = "conectarToolStripMenuItem";
            conectarToolStripMenuItem.Size = new Size(139, 22);
            conectarToolStripMenuItem.Text = "Conectar";
            conectarToolStripMenuItem.Click += conectarToolStripMenuItem_Click;
            // 
            // desconectarToolStripMenuItem
            // 
            desconectarToolStripMenuItem.Image = (Image)resources.GetObject("desconectarToolStripMenuItem.Image");
            desconectarToolStripMenuItem.Name = "desconectarToolStripMenuItem";
            desconectarToolStripMenuItem.Size = new Size(139, 22);
            desconectarToolStripMenuItem.Text = "Desconectar";
            desconectarToolStripMenuItem.Click += desconectarToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(139, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarNovoUsuárioToolStripMenuItem, cadastroDeLíderesToolStripMenuItem, cadastroDeMembrosToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(66, 20);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // cadastrarNovoUsuárioToolStripMenuItem
            // 
            cadastrarNovoUsuárioToolStripMenuItem.Image = (Image)resources.GetObject("cadastrarNovoUsuárioToolStripMenuItem.Image");
            cadastrarNovoUsuárioToolStripMenuItem.Name = "cadastrarNovoUsuárioToolStripMenuItem";
            cadastrarNovoUsuárioToolStripMenuItem.Size = new Size(199, 22);
            cadastrarNovoUsuárioToolStripMenuItem.Text = "Cadastrar Novo Usuário";
            cadastrarNovoUsuárioToolStripMenuItem.Click += cadastrarNovoUsuárioToolStripMenuItem_Click;
            // 
            // cadastroDeLíderesToolStripMenuItem
            // 
            cadastroDeLíderesToolStripMenuItem.Image = Properties.Resources.Add_User_Female;
            cadastroDeLíderesToolStripMenuItem.Name = "cadastroDeLíderesToolStripMenuItem";
            cadastroDeLíderesToolStripMenuItem.Size = new Size(199, 22);
            cadastroDeLíderesToolStripMenuItem.Text = "Cadastro de Líderes";
            cadastroDeLíderesToolStripMenuItem.Click += cadastroDeLíderesToolStripMenuItem_Click;
            // 
            // cadastroDeMembrosToolStripMenuItem
            // 
            cadastroDeMembrosToolStripMenuItem.Image = Properties.Resources.Add_User_Female;
            cadastroDeMembrosToolStripMenuItem.Name = "cadastroDeMembrosToolStripMenuItem";
            cadastroDeMembrosToolStripMenuItem.Size = new Size(199, 22);
            cadastroDeMembrosToolStripMenuItem.Text = "Cadastro de Membros";
            cadastroDeMembrosToolStripMenuItem.Click += cadastroDeMembrosToolStripMenuItem_Click;
            // 
            // exibirToolStripMenuItem
            // 
            exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            exibirToolStripMenuItem.Size = new Size(48, 20);
            exibirToolStripMenuItem.Text = "Exibir";
            // 
            // ferramentasToolStripMenuItem
            // 
            ferramentasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { configuraçõesBancoDeDadosToolStripMenuItem });
            ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            ferramentasToolStripMenuItem.Size = new Size(84, 20);
            ferramentasToolStripMenuItem.Text = "Ferramentas";
            // 
            // configuraçõesBancoDeDadosToolStripMenuItem
            // 
            configuraçõesBancoDeDadosToolStripMenuItem.Image = (Image)resources.GetObject("configuraçõesBancoDeDadosToolStripMenuItem.Image");
            configuraçõesBancoDeDadosToolStripMenuItem.Name = "configuraçõesBancoDeDadosToolStripMenuItem";
            configuraçõesBancoDeDadosToolStripMenuItem.Size = new Size(239, 22);
            configuraçõesBancoDeDadosToolStripMenuItem.Text = "Configurações Banco de Dados";
            configuraçõesBancoDeDadosToolStripMenuItem.Click += configuraçõesBancoDeDadosToolStripMenuItem_Click;
            // 
            // tbc_Finance
            // 
            tbc_Finance.Dock = DockStyle.Fill;
            tbc_Finance.ImageList = Iml_Menu;
            tbc_Finance.Location = new Point(0, 24);
            tbc_Finance.Name = "tbc_Finance";
            tbc_Finance.SelectedIndex = 0;
            tbc_Finance.Size = new Size(834, 576);
            tbc_Finance.TabIndex = 1;
            tbc_Finance.MouseDown += tbc_Finance_MouseDown;
            // 
            // Iml_Menu
            // 
            Iml_Menu.ColorDepth = ColorDepth.Depth32Bit;
            Iml_Menu.ImageStream = (ImageListStreamer)resources.GetObject("Iml_Menu.ImageStream");
            Iml_Menu.TransparentColor = Color.Transparent;
            Iml_Menu.Images.SetKeyName(0, "Database Administrator_1.ico");
            Iml_Menu.Images.SetKeyName(1, "Add User Male.ico");
            // 
            // Frm_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 600);
            Controls.Add(tbc_Finance);
            Controls.Add(Mns_Finance);
            MainMenuStrip = Mns_Finance;
            Name = "Frm_Main";
            Text = "Controle Financeiro";
            Mns_Finance.ResumeLayout(false);
            Mns_Finance.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip Mns_Finance;
        private TabControl tbc_Finance;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem exibirToolStripMenuItem;
        private ToolStripMenuItem ferramentasToolStripMenuItem;
        private ToolStripMenuItem configuraçõesBancoDeDadosToolStripMenuItem;
        private ImageList Iml_Menu;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem cadastrarNovoUsuárioToolStripMenuItem;
        private ToolStripMenuItem conectarToolStripMenuItem;
        private ToolStripMenuItem desconectarToolStripMenuItem;
        private ToolStripMenuItem cadastroDeLíderesToolStripMenuItem;
        private ToolStripMenuItem cadastroDeMembrosToolStripMenuItem;
    }
}
