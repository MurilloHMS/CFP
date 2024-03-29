using ControleFinanceiroPessoal.Model;
using ControleFinanceiroPessoal.Views.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFinanceiroPessoal.Views.UC
{
    public partial class Frm_ForaDaCaixa : UserControl
    {
        private Member member = new Member();
        
        public Frm_ForaDaCaixa()
        {
            InitializeComponent();
            BuscaMembros();
        }


        private void novaToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void BuscaMembros()
        {
            try
            {
                Clb_Membros.Items.Clear();
                var retornaTodosOsMembros = member.RetornaListaDeMembros();
                foreach( var membro in retornaTodosOsMembros)
                {
                    var x = new Itembox();
                    x.Nome = membro.Nome;
                    x.ID = membro.ID;
                    Clb_Membros.Items.Add(x);
                }
            }
            
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Comunidade Kingdom", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private class Itembox
        {
            public int ID { get; set; }
            public string Nome { get; set; }
            public override string ToString()
            {
                return Nome;
            }
        }

    }
}
