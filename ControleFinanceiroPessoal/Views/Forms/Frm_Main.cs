using ControleFinanceiroPessoal.Forms;
using ControleFinanceiroPessoal.Forms.UC;
using ControleFinanceiroPessoal.Model;
using ControleFinanceiroPessoal.Views.UC;
using System.Security.Permissions;

namespace ControleFinanceiroPessoal;

public partial class Frm_Main : Form
{
    int ControlDataBaseSetting = 0;
    int ControlCustumerRegistration = 0;

    public Frm_Main()
    {
        InitializeComponent();

        AlteraOpcoesMenu(false);

    }

    private void AlteraOpcoesMenu(bool tipo)
    {

        cadastrarNovoUsu�rioToolStripMenuItem.Enabled = tipo;
        configura��esBancoDeDadosToolStripMenuItem.Enabled = tipo;
        desconectarToolStripMenuItem.Enabled = tipo;
        cadastroDeMinist�riosToolStripMenuItem.Enabled = tipo;
        cadastroDeMembrosToolStripMenuItem.Enabled = tipo;
        organizarDiret�riosToolStripMenuItem.Enabled = tipo;
        recupera��oDeAcessoToolStripMenuItem.Enabled = tipo;
        controleTotalDashboardToolStripMenuItem.Enabled = tipo;
        membrosToolStripMenuItem.Enabled = tipo;
        minist�riosToolStripMenuItem.Enabled = tipo;
        foraDaCaixaToolStripMenuItem.Enabled = tipo;




        switch (tipo)
        {
            case true:
                conectarToolStripMenuItem.Enabled = false;
                break;
            case false:
                conectarToolStripMenuItem.Enabled = true;
                break;
        }



    }

    private void configura��esBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Frm_DataBaseSettings_UC frm = new Frm_DataBaseSettings_UC();
        frm.Dock = DockStyle.Fill;
        TabPage tb = new TabPage();
        tb.Name = "Configura��es Banco de dados";
        tb.Text = "Configura��es Banco de dados";
        tb.ImageIndex = 0;
        tb.Controls.Add(frm);
        tbc_Finance.TabPages.Add(tb);

    }

    private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ConectarNoSistema();
    }

    public void ConectarNoSistema()
    {
        Frm_Login frm_Login = new Frm_Login();
        frm_Login.ShowDialog();

        if (frm_Login.DialogResult == DialogResult.OK)
        {
            string senha = frm_Login.senha;
            string usuario = frm_Login.login;

            if (Validations.validaSenhaLogin(usuario, senha))
            {
                AlteraOpcoesMenu(true);

            }
            else
            {
                MessageBox.Show("Senha Inv�lida!", "Autentica��o", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
    private void sairToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Deseja desconectar do sistema?", "Desconectar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            tbc_Finance.TabPages.Clear();
            AlteraOpcoesMenu(false);

        }
    }
    private ToolStripMenuItem CriaItemMenu(String text, string nomeDoIcone)
    {
        var vToolTip = new ToolStripMenuItem();
        vToolTip.Text = text;
        Icon myIcon = (Icon)global::ControleFinanceiroPessoal.Properties.Resources.ResourceManager.GetObject(nomeDoIcone)!;
        vToolTip.Image = myIcon.ToBitmap();
        return vToolTip;

    }

    private void tbc_Finance_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == System.Windows.Forms.MouseButtons.Right)
        {
            var ContextMenu = new ContextMenuStrip();

            var vToolTip001 = CriaItemMenu("Fechar Aba", "Close Tab");
            var vToolTip002 = CriaItemMenu("Fechar Todas as Abas", "Close All Tabs");
            var vToolTip003 = CriaItemMenu("Fechar Todas as Abas a Direita", "Close Pane");

            ContextMenu.Items.Add(vToolTip001);
            ContextMenu.Items.Add(vToolTip002);
            ContextMenu.Items.Add(vToolTip003);

            ContextMenu.Show(this, new Point(e.X, e.Y));
            vToolTip001.Click += new System.EventHandler(vToolTip001_Click);
            vToolTip002.Click += new System.EventHandler(vToolTip002_Click);
            vToolTip003.Click += new System.EventHandler(vToolTip003_Click);

        }

        void vToolTip001_Click(object sender, EventArgs e)
        {
            //apaga a aba selecionada 
            if (!(tbc_Finance.SelectedTab == null))
            {
                tbc_Finance.TabPages.Remove(tbc_Finance.SelectedTab);
            }
        }
        void vToolTip002_Click(object sender, EventArgs e)
        {
            //apaga todas as abas
            tbc_Finance.TabPages.Clear();
        }
        void vToolTip003_Click(object sender, EventArgs e)
        {
            //apaga todas as abas a direita
            if (!(tbc_Finance.SelectedTab == null))
            {
                int ItemSelecionado = tbc_Finance.SelectedIndex;

                for (int i = tbc_Finance.TabCount - 1; i > ItemSelecionado; i += -1)
                {

                    tbc_Finance.TabPages.Remove(tbc_Finance.TabPages[i]);

                }
            }
        }
    }

    private void cadastrarNovoUsu�rioToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (ControlCustumerRegistration == 0)
        {
            Frm_CustomerRegistrations frm_CustomerRegistrations = new Frm_CustomerRegistrations();
            frm_CustomerRegistrations.Dock = DockStyle.Fill;
            TabPage tb = new TabPage();
            tb.Name = "Cadastro de Usu�rio";
            tb.Text = "Cadastro de Usu�rio";
            tb.ImageIndex = 1;
            tb.Controls.Add(frm_CustomerRegistrations);
            tbc_Finance.TabPages.Add(tb);
            //ControlCustumerRegistration++;

        }
        else
        {
            MessageBox.Show("J� existe uma aba de Cadastro de Usu�rio aberta", "Controle de Abas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }



    private void cadastroDeMembrosToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Frm_CadastroDeMembros frm = new Frm_CadastroDeMembros();
        frm.Dock = DockStyle.Fill;
        TabPage tb = new TabPage();
        tb.Name = "Cadastro de Membros";
        tb.Text = "Cadastro de Membros";
        tb.ImageIndex = 1;
        tb.Controls.Add(frm);
        tbc_Finance.TabPages.Add(tb);
    }

    private void informarDiret�rioToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Frm_OrganizeDirectories frm = new Frm_OrganizeDirectories();
        frm.Dock = DockStyle.Fill;
        TabPage tb = new TabPage();
        tb.Name = "Organizar Diret�rios";
        tb.Text = "Organizar Diret�rios";
        tb.Controls.Add(frm);
        tbc_Finance.TabPages.Add(tb);
    }

    private void recupera��oDeAcessoToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Frm_Recuperacao frm = new Frm_Recuperacao();
        frm.Dock = DockStyle.Fill;
        TabPage tb = new TabPage();
        tb.Name = "Recupera��o";
        tb.Text = "Recupera��o";
        tb.Controls.Add(frm);
        tbc_Finance.TabPages.Add(tb);
    }

    private void cadastroDeForaDaCaixaToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Frm_ForaDaCaixa frm = new Frm_ForaDaCaixa();
        frm.Dock = DockStyle.Fill;
        TabPage tb = new TabPage();
        tb.Name = "Cadastro de Fora Da Caixa";
        tb.Text = "Cadastro de Fora Da Caixa";
        tb.ImageIndex = 2;
        tb.Controls.Add(frm);
        tbc_Finance.TabPages.Add(tb);
    }

    private void controleTotalDashboardToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Frm_DashboardFinanceiro frm = new Frm_DashboardFinanceiro();
        frm.Dock = DockStyle.Fill;
        TabPage tb = new TabPage();
        tb.Name = "Dashboard";
        tb.Text = "Dashboard";
        tb.Controls.Add(frm);
        tbc_Finance.TabPages.Add(tb);
    }

    private void lan�amentoToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Frm_LancamentosFinanceiro frm = new Frm_LancamentosFinanceiro();
        frm.Dock = DockStyle.Fill;
        TabPage tb = new TabPage();
        tb.Name = "Financeiro";
        tb.Text = "Financeiro";
        tb.Controls.Add(frm);
        tbc_Finance.TabPages.Add(tb);
    }

    private void Frm_Main_Load(object sender, EventArgs e)
    {
    }
}
