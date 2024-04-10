using ControleFinanceiroPessoal.Model;
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
        List<ItemBox> _ListaBusca = new List<ItemBox>();
        public int idSelect { get; set; }

        Member membros = new Member();
        public Frm_SearchMembers()
        {
           
            InitializeComponent();
            PreencherLista();
            Lst_Busca.Sorted = true;

        }

        private void PreencherLista()
        {
            Lst_Busca.Items.Clear();
            _ListaBusca.Clear();

            var retornoTodosOsMembros = membros.RetornaListaDeMembros();
            foreach (var membro in retornoTodosOsMembros)
            {
                ItemBox x = new ItemBox();
                x.Id = membro.ID;
                x.Nome = membro.Nome;
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
            public int Id { get; set; }
            public string Nome { get; set; }

            public override string ToString()
            {
                return Nome;
            }
        }
    }
}
