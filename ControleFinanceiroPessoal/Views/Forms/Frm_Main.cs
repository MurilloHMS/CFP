using ControleFinanceiroPessoal.Forms;
using ControleFinanceiroPessoal.Forms.UC;
using ControleFinanceiroPessoal.Model;
using ControleFinanceiroPessoal.Views.UC;

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

        cadastrarNovoUsuárioToolStripMenuItem.Enabled = tipo;
        configuraçõesBancoDeDadosToolStripMenuItem.Enabled = tipo;
        desconectarToolStripMenuItem.Enabled = tipo;
        cadastroDeMinistériosToolStripMenuItem.Enabled = tipo;
        cadastroDeMembrosToolStripMenuItem.Enabled = tipo;
        organizarDiretóriosToolStripMenuItem.Enabled = tipo;
        recuperaçãoDeAcessoToolStripMenuItem.Enabled = tipo;
        controleTotalDashboardToolStripMenuItem.Enabled = tipo;
        membrosToolStripMenuItem.Enabled = tipo;
        ministériosToolStripMenuItem.Enabled = tipo;
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

    private void configuraçõesBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Frm_DataBaseSettings_UC frm = new Frm_DataBaseSettings_UC();
        frm.Dock = DockStyle.Fill;
        TabPage tb = new TabPage();
        tb.Name = "Configurações Banco de dados";
        tb.Text = "Configurações Banco de dados";
        tb.ImageIndex = 0;
        tb.Controls.Add(frm);
        tbc_Finance.TabPages.Add(tb);

    }

    private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
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
                MessageBox.Show("Senha Inválida!", "Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

    private void cadastrarNovoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (ControlCustumerRegistration == 0)
        {
            Frm_CustomerRegistrations frm_CustomerRegistrations = new Frm_CustomerRegistrations();
            frm_CustomerRegistrations.Dock = DockStyle.Fill;
            TabPage tb = new TabPage();
            tb.Name = "Cadastro de Usuário";
            tb.Text = "Cadastro de Usuário";
            tb.ImageIndex = 1;
            tb.Controls.Add(frm_CustomerRegistrations);
            tbc_Finance.TabPages.Add(tb);
            //ControlCustumerRegistration++;

        }
        else
        {
            MessageBox.Show("Já existe uma aba de Cadastro de Usuário aberta", "Controle de Abas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

    private void informarDiretórioToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Frm_OrganizeDirectories frm = new Frm_OrganizeDirectories();
        frm.Dock = DockStyle.Fill;
        TabPage tb = new TabPage();
        tb.Name = "Organizar Diretórios";
        tb.Text = "Organizar Diretórios";
        tb.Controls.Add(frm);
        tbc_Finance.TabPages.Add(tb);
    }

    private void recuperaçãoDeAcessoToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Frm_Recuperacao frm = new Frm_Recuperacao();
        frm.Dock = DockStyle.Fill;
        TabPage tb = new TabPage();
        tb.Name = "Recuperação";
        tb.Text = "Recuperação";
        tb.Controls.Add(frm);
        tbc_Finance.TabPages.Add(tb);
    }

    private void cadastroDeMinistériosToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Frm_Ministerios frm = new Frm_Ministerios();
        frm.Dock = DockStyle.Fill;
        TabPage tb = new TabPage();
        tb.Name = "Cadastro de Ministérios";
        tb.Text = "Cadastro de Ministérios";
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
}
