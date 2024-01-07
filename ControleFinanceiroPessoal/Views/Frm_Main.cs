using ControleFinanceiroPessoal.Forms;
using ControleFinanceiroPessoal.Forms.UC;
using ControleFinanceiroPessoal.Model;
using Microsoft.VisualBasic;
using System.Drawing.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace ControleFinanceiroPessoal;

public partial class Frm_Main : Form
{
    int ControlDataBaseSetting = 0;

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

            if (Validations.validaSenhaLogin(senha) == true)
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
        Icon myIcon = (Icon)global::ControleFinanceiroPessoal.Properties.Resources.ResourceManager.GetObject(nomeDoIcone);
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
            if(!(tbc_Finance.SelectedTab == null))
            {
                tbc_Finance.TabPages.Remove(tbc_Finance.SelectedTab);
            }
        }
        void vToolTip002_Click(object sender, EventArgs e)
        {
            tbc_Finance.TabPages.Clear();
        }
        void vToolTip003_Click(object sender, EventArgs e)
        {

        }
    }
}
