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
using System.Globalization;
using ControleFinanceiroPessoal.Views.Forms;

namespace ControleFinanceiroPessoal.Views.UC
{
    public partial class Frm_CadastroDeMembros : UserControl
    {
        public Frm_CadastroDeMembros()
        {
            InitializeComponent();
        }

        private readonly Member member= new Member();

        private void novaToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {

                Member M = new Member();
                M = LeituraFormulario();
                M.ValidaClasse();
                M.IncluirMembro();
                MessageBox.Show("Membro incluido com sucesso!", "Comunidade Kingdom", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ValidationException Ex)
            {
                MessageBox.Show(Ex.Message, "Validador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Comunidade Kingdom", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            Txt_Cidade.Text = string.Empty;
            Txt_Complemento.Text = string.Empty;
            Txt_Email.Text = string.Empty;
            Txt_ID.Text = string.Empty;
            Txt_UF.Text = string.Empty;
            Txt_Logradouro.Text = string.Empty;
            Txt_Nome.Text = string.Empty;
            Txt_Numero.Text = string.Empty;
            MTxt_Cep.Text = string.Empty;
            MTxt_DataNascimento.Text = string.Empty;
            MTxt_Telefone.Text = string.Empty;

            Rb_CristaoNao.Checked = false;
            Rb_CristaoSim.Checked = false;
            Rb_FreqIgrejaNao.Checked = false;
            Rb_FreqIgrejaSim.Checked = false;
        }

        private void ApagarToolStripButton_Click(object sender, EventArgs e)
        {
            ApagarDados();
        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            if (Txt_ID.Text == string.Empty)
            {
                MessageBox.Show("Código do Membro Vazio.", "Comunidade Kingdom", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    Member m = new Member();
                    m = member.RetornaMembroPorId(int.Parse(Txt_ID.Text));
                    if (m == null)
                    {
                        MessageBox.Show("Membro não encontrado", "Comunidade Kingdom", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        WriteForm(m);
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "Comunidade Kingdom", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void recortarToolStripButton_Click(object sender, EventArgs e)
        {
            if (Txt_ID.Text == string.Empty)
            {
                MessageBox.Show("Código do Membro Vazio.", "Comunidade Kingdom", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    Member m = new Member();
                    m = m.RetornaMembroPorId(int.Parse(Txt_ID.Text));
                    if (m == null)
                    {
                        MessageBox.Show("Membro não encontrado", "Comunidade Kingdom", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        WriteForm(m);
                        DialogResult result = MessageBox.Show("Deseja excluir os dados do Membro informado?", "Comunidade Kingdom", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            result = MessageBox.Show("Tem certeza que deseja excluir os dados? essa ação é irreversível", "Comunidade Kingdom", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (result == DialogResult.Yes)
                            {
                                m.ApagarMembro();
                                MessageBox.Show($"Membro Excluido com sucesso!", "Comunidade Kingdom", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ApagarDados();
                            }
                        }

                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "Comunidade Kingdom", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            if (Txt_ID.Text == string.Empty)
            {
                MessageBox.Show("Código do Membro Vazio.", "Comunidade Kingdom", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    Member M = new Member();
                    M = LeituraFormulario();
                    M.ValidaClasse();
                    M.AlterarDados();
                    MessageBox.Show($"Membro alterado com sucesso!", "Comunidade Kingdom", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (ValidationException Ex)
                {
                    MessageBox.Show(Ex.Message, "Validador", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "Comunidade Kingdom", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Btn_BuscaMembros_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_SearchMembers F = new Frm_SearchMembers();
                F.ShowDialog();
                if (F.DialogResult == DialogResult.OK)
                {
                    var idSelect = F.idSelect;
                    //M = M.RetornaMembroPorId(idSelect);
                    if (idSelect != null)
                    {
                        WriteForm(member.RetornaMembroPorId(idSelect));
                    }
                    else
                    {
                        MessageBox.Show("Membro não encontrado", "Comunidade Kingdom", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Comunidade Kingdom", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        Member LeituraFormulario()
        {

            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            Member M = new Member();
            if (!string.IsNullOrEmpty(Txt_ID.Text))
            {
                M.ID = int.Parse(Txt_ID.Text);
            }
            M.Nome = textInfo.ToTitleCase(Txt_Nome.Text);
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

            return M;
        }

        void WriteForm(Member M)
        {
            Txt_ID.Text = M.ID.ToString();
            Txt_Nome.Text = M.Nome;
            MTxt_DataNascimento.Text = M.DataDeNascimento;
            MTxt_Telefone.Text = M.Telefone;
            Txt_Email.Text = M.Email;
            MTxt_Cep.Text = M.CEP;
            Txt_Logradouro.Text = M.Rua;
            Txt_Numero.Text = M.Numero;
            Txt_Bairro.Text = M.Bairro;
            Txt_Cidade.Text = M.Cidade;
            Txt_UF.Text = M.UF;
            Txt_Complemento.Text = M.Complemento;

            if (M.PerguntaECristao == "NÃO")
            {
                Rb_CristaoNao.Checked = true;
            }
            else
            {
                Rb_CristaoSim.Checked = true;
            }

            if (M.PerguntaFrequentaIgreja == "NÃO")
            {
                Rb_FreqIgrejaNao.Checked = true;
            }
            else
            {
                Rb_FreqIgrejaSim.Checked = true;
            }


        }
    }
}
