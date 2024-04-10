using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleFinanceiroPessoal.Model.Databases;

namespace ControleFinanceiroPessoal.Forms.UC
{
    public partial class Frm_DataBaseSettings_UC : UserControl
    {
        public Frm_DataBaseSettings_UC()
        {
            InitializeComponent();
        }

        private void Btn_CriarTabelas_Click(object sender, EventArgs e)
        {
            ControleFinanceiroContext context = new ControleFinanceiroContext();
            context.CriarTabelaSql();
        }
    }
}
