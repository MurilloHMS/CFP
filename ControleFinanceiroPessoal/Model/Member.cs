using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ControleFinanceiroPessoal.Model
{
    internal class Member
    {
        public class Unit
        {
            //
            //Dados do cadastro
            //
            [Required(ErrorMessage ="O ID é Obrigatório")]
            [RegularExpression("([0-9]+)", ErrorMessage = "O ID deve conter apenas números.")]
            [StringLength(6, ErrorMessage ="O ID deve ter no máximo 6 caracteres.")]
            public string ID { get; set; }


            public void ValidaClasse () 
            {
                ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
                List<ValidationResult> results = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(this, context, results, true);

                if (!isValid) 
                {
                    StringBuilder sbrErrors = new StringBuilder();
                    foreach (var validationResult in results)
                    {
                        sbrErrors.AppendLine(validationResult.ErrorMessage);
                    }
                    throw new ValidationException(sbrErrors.ToString()); 
                }
            }
        }

    }
}
