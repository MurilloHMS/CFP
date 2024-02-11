using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiroPessoal.Model
{
    internal class Ministerio
    {
        public string NomeMinisterio {  get; set; }
        public List<Member> Lideres { get; set; }
        public List<Member> Membros { get; set; }


        public Ministerio() 
        {
            Lideres = new List<Member>();
            Membros = new List<Member>();

        }
    }

    
}
