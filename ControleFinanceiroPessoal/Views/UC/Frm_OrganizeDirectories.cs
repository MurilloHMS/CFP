using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleFinanceiroPessoal.Model;

namespace ControleFinanceiroPessoal.Views.UC
{
    public partial class Frm_OrganizeDirectories : UserControl
    {
        public Frm_OrganizeDirectories()
        {
            InitializeComponent();
        }

        private void Btn_CaminhoOrigem_Click(object sender, EventArgs e)
        {
            Txt_CaminhoOrigem.Text = Organize.SelectFolder();
        }

        private void Btn_CaminhoDestino_Click(object sender, EventArgs e)
        {
            Txt_CaminhoDestino.Text = Organize.SelectFolder();
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            string pastaOrigem = Txt_CaminhoOrigem.Text;
            string pastaDestino = Txt_CaminhoDestino.Text;

            Organize.OrganizeFiles(pastaOrigem, pastaDestino, Txt_Log, Pgb_Log);
        }
    }
}
