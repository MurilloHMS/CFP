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
            cadastroDeMembrosToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeMinistériosToolStripMenuItem = new ToolStripMenuItem();
            cadastrarNovoUsuárioToolStripMenuItem = new ToolStripMenuItem();
            ControleToolStripMenuItem = new ToolStripMenuItem();
            controleTotalDashboardToolStripMenuItem = new ToolStripMenuItem();
            membrosToolStripMenuItem = new ToolStripMenuItem();
            ministériosToolStripMenuItem = new ToolStripMenuItem();
            foraDaCaixaToolStripMenuItem = new ToolStripMenuItem();
            ferramentasToolStripMenuItem = new ToolStripMenuItem();
            configuraçõesBancoDeDadosToolStripMenuItem = new ToolStripMenuItem();
            organizarDiretóriosToolStripMenuItem = new ToolStripMenuItem();
            informarDiretórioToolStripMenuItem = new ToolStripMenuItem();
            salvarDadosNoMesmoDiretórioToolStripMenuItem = new ToolStripMenuItem();
            recuperaçãoDeAcessoToolStripMenuItem = new ToolStripMenuItem();
            tbc_Finance = new TabControl();
            Iml_Menu = new ImageList(components);
            financeiroToolStripMenuItem = new ToolStripMenuItem();
            lançamentoToolStripMenuItem = new ToolStripMenuItem();
            Mns_Finance.SuspendLayout();
            SuspendLayout();
            // 
            // Mns_Finance
            // 
            Mns_Finance.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, cadastroToolStripMenuItem, financeiroToolStripMenuItem, ControleToolStripMenuItem, ferramentasToolStripMenuItem });
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
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroDeMembrosToolStripMenuItem, cadastroDeMinistériosToolStripMenuItem, cadastrarNovoUsuárioToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(66, 20);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // cadastroDeMembrosToolStripMenuItem
            // 
            cadastroDeMembrosToolStripMenuItem.Image = Properties.Resources.Add_User_Female;
            cadastroDeMembrosToolStripMenuItem.Name = "cadastroDeMembrosToolStripMenuItem";
            cadastroDeMembrosToolStripMenuItem.Size = new Size(145, 22);
            cadastroDeMembrosToolStripMenuItem.Text = "Membros";
            cadastroDeMembrosToolStripMenuItem.Click += cadastroDeMembrosToolStripMenuItem_Click;
            // 
            // cadastroDeMinistériosToolStripMenuItem
            // 
            cadastroDeMinistériosToolStripMenuItem.Image = Properties.Resources.Add_User_Female;
            cadastroDeMinistériosToolStripMenuItem.Name = "cadastroDeMinistériosToolStripMenuItem";
            cadastroDeMinistériosToolStripMenuItem.Size = new Size(145, 22);
            cadastroDeMinistériosToolStripMenuItem.Text = "Ministérios";
            cadastroDeMinistériosToolStripMenuItem.Click += cadastroDeMinistériosToolStripMenuItem_Click;
            // 
            // cadastrarNovoUsuárioToolStripMenuItem
            // 
            cadastrarNovoUsuárioToolStripMenuItem.Image = (Image)resources.GetObject("cadastrarNovoUsuárioToolStripMenuItem.Image");
            cadastrarNovoUsuárioToolStripMenuItem.Name = "cadastrarNovoUsuárioToolStripMenuItem";
            cadastrarNovoUsuárioToolStripMenuItem.Size = new Size(145, 22);
            cadastrarNovoUsuárioToolStripMenuItem.Text = "Fora da Caixa";
            cadastrarNovoUsuárioToolStripMenuItem.Click += cadastrarNovoUsuárioToolStripMenuItem_Click;
            // 
            // ControleToolStripMenuItem
            // 
            ControleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { controleTotalDashboardToolStripMenuItem, membrosToolStripMenuItem, ministériosToolStripMenuItem, foraDaCaixaToolStripMenuItem });
            ControleToolStripMenuItem.Name = "ControleToolStripMenuItem";
            ControleToolStripMenuItem.Size = new Size(65, 20);
            ControleToolStripMenuItem.Text = "Controle";
            // 
            // controleTotalDashboardToolStripMenuItem
            // 
            controleTotalDashboardToolStripMenuItem.Name = "controleTotalDashboardToolStripMenuItem";
            controleTotalDashboardToolStripMenuItem.Size = new Size(167, 22);
            controleTotalDashboardToolStripMenuItem.Text = "Total (Dashboard)";
            controleTotalDashboardToolStripMenuItem.Click += controleTotalDashboardToolStripMenuItem_Click;
            // 
            // membrosToolStripMenuItem
            // 
            membrosToolStripMenuItem.Name = "membrosToolStripMenuItem";
            membrosToolStripMenuItem.Size = new Size(167, 22);
            membrosToolStripMenuItem.Text = "Membros";
            // 
            // ministériosToolStripMenuItem
            // 
            ministériosToolStripMenuItem.Name = "ministériosToolStripMenuItem";
            ministériosToolStripMenuItem.Size = new Size(167, 22);
            ministériosToolStripMenuItem.Text = "Ministérios";
            // 
            // foraDaCaixaToolStripMenuItem
            // 
            foraDaCaixaToolStripMenuItem.Name = "foraDaCaixaToolStripMenuItem";
            foraDaCaixaToolStripMenuItem.Size = new Size(167, 22);
            foraDaCaixaToolStripMenuItem.Text = "Fora da Caixa";
            // 
            // ferramentasToolStripMenuItem
            // 
            ferramentasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { configuraçõesBancoDeDadosToolStripMenuItem, organizarDiretóriosToolStripMenuItem, recuperaçãoDeAcessoToolStripMenuItem });
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
            // organizarDiretóriosToolStripMenuItem
            // 
            organizarDiretóriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { informarDiretórioToolStripMenuItem, salvarDadosNoMesmoDiretórioToolStripMenuItem });
            organizarDiretóriosToolStripMenuItem.Name = "organizarDiretóriosToolStripMenuItem";
            organizarDiretóriosToolStripMenuItem.Size = new Size(239, 22);
            organizarDiretóriosToolStripMenuItem.Text = "Organizar Diretórios";
            // 
            // informarDiretórioToolStripMenuItem
            // 
            informarDiretórioToolStripMenuItem.Name = "informarDiretórioToolStripMenuItem";
            informarDiretórioToolStripMenuItem.Size = new Size(248, 22);
            informarDiretórioToolStripMenuItem.Text = "Informar Diretório";
            informarDiretórioToolStripMenuItem.Click += informarDiretórioToolStripMenuItem_Click;
            // 
            // salvarDadosNoMesmoDiretórioToolStripMenuItem
            // 
            salvarDadosNoMesmoDiretórioToolStripMenuItem.Name = "salvarDadosNoMesmoDiretórioToolStripMenuItem";
            salvarDadosNoMesmoDiretórioToolStripMenuItem.Size = new Size(248, 22);
            salvarDadosNoMesmoDiretórioToolStripMenuItem.Text = "Salvar dados no mesmo diretório";
            // 
            // recuperaçãoDeAcessoToolStripMenuItem
            // 
            recuperaçãoDeAcessoToolStripMenuItem.Name = "recuperaçãoDeAcessoToolStripMenuItem";
            recuperaçãoDeAcessoToolStripMenuItem.Size = new Size(239, 22);
            recuperaçãoDeAcessoToolStripMenuItem.Text = "Recuperação de Acesso";
            recuperaçãoDeAcessoToolStripMenuItem.Click += recuperaçãoDeAcessoToolStripMenuItem_Click;
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
            // financeiroToolStripMenuItem
            // 
            financeiroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lançamentoToolStripMenuItem });
            financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            financeiroToolStripMenuItem.Size = new Size(74, 20);
            financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // lançamentoToolStripMenuItem
            // 
            lançamentoToolStripMenuItem.Name = "lançamentoToolStripMenuItem";
            lançamentoToolStripMenuItem.Size = new Size(180, 22);
            lançamentoToolStripMenuItem.Text = "Lançamento";
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
        private ToolStripMenuItem ControleToolStripMenuItem;
        private ToolStripMenuItem ferramentasToolStripMenuItem;
        private ToolStripMenuItem configuraçõesBancoDeDadosToolStripMenuItem;
        private ImageList Iml_Menu;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem cadastrarNovoUsuárioToolStripMenuItem;
        private ToolStripMenuItem conectarToolStripMenuItem;
        private ToolStripMenuItem desconectarToolStripMenuItem;
        private ToolStripMenuItem cadastroDeMinistériosToolStripMenuItem;
        private ToolStripMenuItem cadastroDeMembrosToolStripMenuItem;
        private ToolStripMenuItem organizarDiretóriosToolStripMenuItem;
        private ToolStripMenuItem informarDiretórioToolStripMenuItem;
        private ToolStripMenuItem salvarDadosNoMesmoDiretórioToolStripMenuItem;
        private ToolStripMenuItem recuperaçãoDeAcessoToolStripMenuItem;
        private ToolStripMenuItem controleTotalDashboardToolStripMenuItem;
        private ToolStripMenuItem membrosToolStripMenuItem;
        private ToolStripMenuItem ministériosToolStripMenuItem;
        private ToolStripMenuItem foraDaCaixaToolStripMenuItem;
        private ToolStripMenuItem financeiroToolStripMenuItem;
        private ToolStripMenuItem lançamentoToolStripMenuItem;
    }
}
