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
    public partial class Frm_Ministerios : UserControl
    {

        private List<List<Member.Unit>> membrosDisponiveis;
        public Frm_Ministerios()
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
                Member.Unit M = new Member.Unit();
                List<string> list = new List<string>();
                string conexao = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Dados", "Membros");
                list = M.ListaMembros(conexao);

                if (list == null)
                {
                    MessageBox.Show("Base de dados Vazia, Não existem membros cadastrados", "Comunidade Kingdom", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    List<List<string>> ListaBusca = new List<List<string>>();
                    foreach (string busca in list)
                    {
                        M = Member.DesSerializedClassUnit(busca);
                        ListaBusca.Add(new List<string> { M.ID, M.Nome });
                    }
                    Clb_Membros.Items.Clear();
                    foreach (var busca in ListaBusca)
                    {
                        Itembox x = new Itembox();
                        x.ID = busca[0];
                        x.Nome = busca[1];
                        Clb_Membros.Items.Add(x);
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Comunidade Kingdom", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private class Itembox
        {
            public string ID { get; set; }
            public string Nome { get; set; }
            public override string ToString()
            {
                return Nome;
            }
        }

    }
}
