using ControleFinanceiroPessoal.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            if (CB_TipoLancamento.SelectedItem == "ENTRADA")
            {
                CB_Categorias.Items.Clear();
                CB_Categorias.Items.Add("DIZIMO/OFERTA");
                CB_Categorias.Items.Add("DIZIMO/OFERTA (EVENTOS)");
                CB_Categorias.Items.Add("VOTOS");
                CB_Categorias.Items.Add("VENDA ALIMENTO");
                CB_Categorias.Items.Add("VENDA PRODUTOS");
                CB_Categorias.Items.Add("VENDA CAMISETAS");
            }
            else if (CB_TipoLancamento.SelectedItem == "SAIDA")
            {
                CB_Categorias.Items.Clear();
                CB_Categorias.Items.Add("AGUA");
                CB_Categorias.Items.Add("LUZ");
                CB_Categorias.Items.Add("TELEFONE");
                CB_Categorias.Items.Add("INTERNET");
                CB_Categorias.Items.Add("ALUGUEL");
                CB_Categorias.Items.Add("EQUIPAMENTOS");
                CB_Categorias.Items.Add("USO INTERNO");
                CB_Categorias.Items.Add("EVENTOS");
                CB_Categorias.Items.Add("FESTAS");
                CB_Categorias.Items.Add("GASOLINA");
            }

            AlterarDadosCB(CB_TipoLancamento);

            //RECEITA
            //DESPESA
        }

        private void AlterarDadosCB(ComboBox comboBox)
        {
            switch (comboBox.SelectedItem)
            {
                case "ENTRADA":
                    Dtp_Vencimento.Enabled = false;
                    break;
                case "SAIDA":
                    Dtp_Vencimento.Enabled = true;
                    break;
            }
        }

        private void TXT_Valor_TextChanged(object sender, EventArgs e)
        {
            string value = Txt_Valor.Text.Replace(",", "")
                                         .Replace("R$", "")
                                         .Replace(".", "")
                                         .TrimStart('0');

            decimal ul;
            if (decimal.TryParse(value, out ul))
            {
                ul /= 100;
                Txt_Valor.TextChanged -= TXT_Valor_TextChanged;
                Txt_Valor.Text = string.Format(CultureInfo.CreateSpecificCulture("pt-BR"), "{0:C2}", ul);
                Txt_Valor.TextChanged += TXT_Valor_TextChanged;
                Txt_Valor.Select(Txt_Valor.Text.Length, 0);
            }
        }

        private static decimal ExtrairValorNumerico(string valor)
        {
            string valorLimpo = valor.Replace("R$", "").Trim();

            if (decimal.TryParse(valorLimpo, NumberStyles.Currency, CultureInfo.GetCultureInfo("pt-BR"), out decimal valorDecimal))
            {
                return valorDecimal;
            }
            else
            {
                return 0;                
            }
        }

        private bool TextisValid(string text)
        {
            Regex money = new Regex(@"^\$(\d{1,3}(\,\d{3})*|(\d+))(\.\d{2})?$");
            return money.IsMatch(text);
        }

        private void Btn_Inserir_Click(object sender, EventArgs e)
        {
            
            try
            {
                Financeiro F = new Financeiro();
                F = LeituraFormulario();
                F.ValidaClasse();
                F.IncluirFinanceiro();
                MessageBox.Show($"Financeiro Incluido com sucesso!", "Comunidade Kingdom", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }catch (ValidationException Ex)
            {
                MessageBox.Show(Ex.Message, "Validador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Comunidade Kingdom", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private Financeiro LeituraFormulario()
        {
            Financeiro F = new Financeiro();
            if (!string.IsNullOrEmpty(Txt_ID.Text))
            {
                F.ID = int.Parse(Txt_ID.Text);
            }
            F.Valor = ExtrairValorNumerico(Txt_Valor.Text);
            F.TipoLancamento = CB_TipoLancamento.SelectedItem.ToString();
            F.TipoEvento = CB_TipoEvento.SelectedItem.ToString();
            F.Categoria = CB_Categorias.SelectedItem.ToString();
            F.DataVencimento = Dtp_Vencimento.Enabled ? Dtp_Vencimento.Value : null;
            F.Descricao = Txt_Descricao.Text;
            
            return F;
        }

        void WriteForm(Financeiro F)
        {
            Txt_ID.Text = F.ID.ToString();
            Txt_Valor.Text = F.Valor.ToString();
            Txt_Descricao.Text = F.Descricao;
            foreach(var item in CB_TipoLancamento.Items)
            {
                if (item == F.TipoLancamento)
                {
                    CB_TipoLancamento.SelectedItem = item;
                }
            }

            /*
             for (int i = 0; i < CB_UsrConexaoRemota.Items.Count; i++)
            {
                if (CB_UsrConexaoRemota.Items[i].ToString() == resultado.CONCUSRTS)
                {
                    CB_UsrConexaoRemota.SelectedIndex = i;
                    break;
                }
            }
             */

        }
    }
}
