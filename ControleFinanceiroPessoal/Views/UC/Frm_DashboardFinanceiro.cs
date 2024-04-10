using ControleFinanceiroPessoal.Model;
using ControleFinanceiroPessoal.Model.Databases;
using Newtonsoft.Json.Linq;
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
    public partial class Frm_DashboardFinanceiro : UserControl
    {

        ControleFinanceiroContext _context;
        public Frm_DashboardFinanceiro()
        {
            InitializeComponent();
        }

        private void Frm_DashboardFinanceiro_Load(object sender, EventArgs e)
        {
            DTP_DataDe.MaxDate = DateTime.Now;
            DTP_DataAte.MaxDate = DateTime.Now;
            DTP_DataAte.Value = DateTime.Now.Date;
            DTP_DataDe.Value = DateTime.Now.Date;
            


        }

        private void ColetaDados()
        {
            Financeiro financeiro = new Financeiro();
            DateTime dataInicial = DTP_DataDe.Value;
            DateTime dataFinal = DTP_DataAte.Value.AddDays(1).AddTicks(-1);
            var registros = financeiro.ObterRegistrosPorData(dataInicial, dataFinal);
            Dgv_DadosFinanceiro.DataSource = registros;

            decimal valorTotalEntradas = 0;
            decimal valorTotalSaidas = 0;
            decimal valorTotalQuartaFire = 0;
            decimal valorTotalDomingo = 0;
            decimal valorTotalEvento = 0;
            decimal valorTotalDizimos = 0;
            decimal valorTotalVendas = 0;
            decimal valorTotalVotos = 0;
            decimal valorTotalGastosEssenciais = 0;
            decimal valorTotalGastosNaoEssenciais = 0;
            foreach (var valor in registros)
            {
                switch (valor.TipoLancamento)
                {
                    case "ENTRADA":
                        valorTotalEntradas += valor.Valor;
                        break;
                    case "SAIDA":
                        valorTotalSaidas += valor.Valor;
                        break;
                }
                switch (valor.TipoEvento)
                {
                    case "QUARTA-FIRE":
                        if (valor.TipoLancamento == "ENTRADA")
                        {
                            valorTotalQuartaFire += valor.Valor;
                        }
                        break;
                    case "DOMINGO":
                        if(valor.TipoLancamento == "ENTRADA")
                        {
                            valorTotalDomingo += valor.Valor;
                        }
                        break;
                    case "EVENTO":
                        valorTotalEvento += valor.Valor;
                        break;

                }
                if (valor.TipoEvento != "EVENTO")
                {
                    if (valor.Categoria == "DIZIMO/OFERTA" || valor.Categoria == "DIZIMO/OFERTA (EVENTOS)")
                    {
                        valorTotalDizimos += valor.Valor;
                    }
                }
                
                if (valor.Categoria == "VENDA ALIMENTO"||  valor.Categoria == "VENDA PRODUTOS" || valor.Categoria == "VENDA CAMISETAS")
                {
                    valorTotalVendas += valor.Valor;
                }
                if (valor.Categoria == "VOTOS")
                {
                    valorTotalVotos += valor.Valor;
                }
                if (valor.Categoria == "AGUA" || valor.Categoria == "LUZ" || valor.Categoria == "TELEFONE" || valor.Categoria == "ALUGUEL" || valor.Categoria == "INTERNET")
                {
                    valorTotalGastosEssenciais += valor.Valor;
                }
                if (valor.Categoria == "EVENTOS" || valor.Categoria == "FESTAS" || valor.Categoria == "USO INTERNO" || valor.Categoria == "EQUIPAMENTOS" || valor.Categoria == "GASOLINA")
                {
                    valorTotalGastosNaoEssenciais += valor.Valor;
                }


            }

            Txt_TotalEntrada.Text = valorTotalEntradas.ToString();
            Txt_TotalSaida.Text = valorTotalSaidas.ToString();
            Txt_OfertasEventos.Text = valorTotalEvento.ToString();
            Txt_TotalDomingo.Text = valorTotalDomingo.ToString();
            Txt_TotalQuartaFire.Text = valorTotalQuartaFire.ToString();
            Txt_Vendas.Text = valorTotalVendas.ToString();
            Txt_DizimosOfertas.Text = valorTotalDizimos.ToString();
            Txt_Votos.Text = valorTotalVotos.ToString();
            Txt_GastosEssenciais.Text = valorTotalGastosEssenciais.ToString();
            Txt_Gastos.Text = valorTotalGastosNaoEssenciais.ToString();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColetaDados();
        }
    }
}
