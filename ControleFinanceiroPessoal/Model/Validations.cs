using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiroPessoal.Model
{
    internal class Validations
    {
        public static  bool validaSenhaLogin(string usuario, string senha)
        { 
            if ((senha == "ceunaterra") && (usuario == "kingdom")) 
            {
                return true;
            }
            return false;
        }

    }
}
