using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiroPessoal.Model
{
    internal class ForaDaCaixa
    {
        public string CEP { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public List<Member> Lideres { get; set; }
        public string Local { get; set; }
        public List<Member> Membros { get; set; }

        public ForaDaCaixa()
        {
            Lideres = new List<Member>();
            Membros = new List<Member>();
        }
    }
}
