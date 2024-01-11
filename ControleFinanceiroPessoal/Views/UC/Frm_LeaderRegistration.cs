using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using ControleFinanceiroPessoal.Model;

namespace ControleFinanceiroPessoal.Views.UC
{
    public partial class Frm_LeaderRegistration : UserControl
    {
        public Frm_LeaderRegistration()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void novaToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                Member.Unit M = new Member.Unit();
                M.ID = Txt_ID.Text;
                M.ValidaClasse();
                MessageBox.Show("Classe foi inicializada sem erros", "Validador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch( ValidationException Ex)
            {
                MessageBox.Show(Ex.Message, "Validador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
