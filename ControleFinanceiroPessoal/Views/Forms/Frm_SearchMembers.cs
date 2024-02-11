using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFinanceiroPessoal.Views.Forms
{
    public partial class Frm_SearchMembers : Form
    {
        List<List<string>> _ListaBusca = new List<List<string>>();
        public string idSelect { get; set; }
        public Frm_SearchMembers(List<List<string>> ListaBusca)
        {
            _ListaBusca = ListaBusca;
            InitializeComponent();
            PreencherLista();
            Lst_Busca.Sorted = true;

        }

        private void PreencherLista()
        {
            Lst_Busca.Items.Clear();

            foreach (var busca in _ListaBusca)
            {
                ItemBox x = new ItemBox();
                x.Id = busca[0];
                x.Nome = busca[1];
                Lst_Busca.Items.Add(x);
            }
        }

        private void Lst_Busca_DoubleClick(object sender, EventArgs e)
        {
            ItemBox itemSelecionado = (ItemBox) Lst_Busca.Items[Lst_Busca.SelectedIndex];
            DialogResult = DialogResult.OK;
            idSelect = itemSelecionado.Id;
            this.Close();
        }

        private class ItemBox
        {
            public string Id { get; set; }
            public string Nome { get; set; }

            public override string ToString()
            {
                return Nome;
            }
        }
    }
}
