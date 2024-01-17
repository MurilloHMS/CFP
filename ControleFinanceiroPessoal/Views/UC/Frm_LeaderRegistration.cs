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
using ControleFinanceiroPessoal.Model.Databases;
using Microsoft.VisualBasic;

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
                var vJson = Requests_Data.GeraJsonCEP("09351090");

                Cep.Unit CEP = new Cep.Unit();
                CEP = Cep.DesSeializedClassUnit(vJson);



                Member.Unit M = new Member.Unit();
                M = LeituraFormulario();
                M.ValidaClasse();
                string clienteJson = Member.SerializedClassUnit(M);

                Binder B = new Binder($@"A:\ControleFinanceiroPessoal\Binder");

                if (B.status)
                {
                    B.Include(M.ID, clienteJson);
                }

                
            }
            catch (ValidationException Ex)
            {
                MessageBox.Show(Ex.Message, "Validador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        Member.Unit LeituraFormulario()
        {
            Member.Unit M = new Member.Unit();
            M.ID = Txt_ID.Text;
            M.Nome = Txt_Nome.Text;
            M.DataDeNascimento = MTxt_DataNascimento.Text;
            M.Telefone = MTxt_Telefone.Text;
            M.Email = Txt_Email.Text;
            M.CEP = MTxt_Cep.Text;
            M.Rua = Txt_Logradouro.Text;
            M.Numero = Txt_Numero.Text;
            M.Bairro = Txt_Bairro.Text;
            M.Cidade = Txt_Cidade.Text;
            M.UF = Txt_UF.Text;
            M.Complemento = Txt_Complemento.Text;
            string response = string.Empty;
            if (Rb_CristaoNao.Checked == true)
            {
                 response = "NÃO";
            }
            else if (Rb_CristaoSim.Checked == true)
            {
                 response = "SIM";
            }

            if (Rb_FreqIgrejaNao.Checked == true)
            {
                response = "NÃO";
            }
            else if (Rb_FreqIgrejaSim.Checked == true)
            {
                response = "SIM";
            }

            M.PerguntaECristao = response!;
            M.PerguntaFrequentaIgreja = response!;

            M.DescricaoMotivoOracao = Txt_Observacoes.Text;
            
            




            return M;
        }

        private void MTxt_Cep_Leave(object sender, EventArgs e)
        {

        }

        private void Btn_SearchCep_Click(object sender, EventArgs e)
        {
            string vCep = MTxt_Cep.Text;

            if (vCep.Length == 9)
            {
                var vJson = Requests_Data.GeraJsonCEP(vCep);

                Cep.Unit CEP = new Cep.Unit();
                CEP = Cep.DesSeializedClassUnit(vJson);

                Txt_Logradouro.Text = CEP.Logradouro;
                Txt_Cidade.Text = CEP.Localidade;
                Txt_Bairro.Text = CEP.Bairro;
                Txt_UF.Text = CEP.Uf;
                Txt_Complemento.Text = CEP.Complemento;
            }
        }

        private void ApagarDados()
        {
            Txt_Bairro.Text = string.Empty;
            Txt_Cidade.Text= string.Empty;
            Txt_Complemento.Text= string.Empty;
            Txt_Email.Text = string.Empty;
            Txt_ID.Text = string.Empty;
            Txt_UF.Text= string.Empty;
            Txt_Logradouro.Text= string.Empty;
            Txt_Nome.Text= string.Empty;
            Txt_Numero.Text= string.Empty;
            Txt_Observacoes.Text= string.Empty; 
            MTxt_Cep.Text = string.Empty;
            MTxt_DataNascimento.Text= string.Empty;
            MTxt_Telefone.Text= string.Empty;

            Rb_CristaoNao.Checked = false;
            Rb_CristaoSim.Checked = false;
            Rb_FreqIgrejaNao.Checked = false;
            Rb_FreqIgrejaSim.Checked = false;
        }

        private void ApagarToolStripButton_Click(object sender, EventArgs e)
        {
            ApagarDados();
        }
    }
}
