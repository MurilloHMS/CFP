using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiroPessoal.Model
{
    internal class ForaDaCaixa
    {
        public string CEP { get; set; }

        [StringLength(100, ErrorMessage = "A Rua deve ter no máximo 100 caracteres.")]
        public string Rua { get; set; }

        [RegularExpression("([0-9]+)", ErrorMessage = "O Número da residencia deve conter apenas números.")]
        [StringLength(6, ErrorMessage = "O Número deve ter no máximo 6 caracteres.")]
        public string Numero { get; set; }

        [StringLength(100, ErrorMessage = "O Bairro deve ter no máximo 100 caracteres.")]
        public string Bairro { get; set; }

        [StringLength(100, ErrorMessage = "A Cidade deve ter no máximo 100 caracteres.")]
        public string Cidade { get; set; }

        [StringLength(2, ErrorMessage = "O UF deve ter no máximo 2 caracteres.")]
        public string UF { get; set; }
        [StringLength(100, ErrorMessage = "O Complemento deve ter no máximo 100 caracteres.")]
        public string Complemento { get; set; }
        public int IdLider { get; set; }
        public string Local { get; set; }
        public int IdMembro { get; set; }

    }
}
