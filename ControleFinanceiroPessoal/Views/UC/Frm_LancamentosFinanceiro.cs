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
    public partial class Frm_LancamentosFinanceiro : UserControl
    {
        public Frm_LancamentosFinanceiro()
        {
            InitializeComponent();
        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_TipoLancamento.SelectedItem == "RECEITA")
            {
                CB_Categorias.Items.Clear();
                CB_Categorias.Items.Add("DIZIMO/OFERTA");
                CB_Categorias.Items.Add("DIZIMO/OFERTA (EVENTOS)");
                CB_Categorias.Items.Add("VOTOS");
                CB_Categorias.Items.Add("VENDA ALIMENTO");
                CB_Categorias.Items.Add("VENDA PRODUTOS");
                CB_Categorias.Items.Add("VENDA CAMISETAS");
            }
            else if (CB_TipoLancamento.SelectedItem == "DESPESA")
            {
                CB_Categorias.Items.Clear();
                CB_Categorias.Items.Add("AGUA");
                CB_Categorias.Items.Add("LUZ");
                CB_Categorias.Items.Add("TELEFONE");
                CB_Categorias.Items.Add("ALUGUEL");
                CB_Categorias.Items.Add("EQUIPAMENTOS");
                CB_Categorias.Items.Add("USO INTERNO");
                CB_Categorias.Items.Add("EVENTOS");
                CB_Categorias.Items.Add("FESTAS");
                CB_Categorias.Items.Add("GASOLINA");
            }

            //RECEITA
            //DESPESA
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
