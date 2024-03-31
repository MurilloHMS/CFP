using ControleFinanceiroPessoal.Model.Databases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiroPessoal.Model
{
    public class Financeiro
    {
        [Key]
        [NotNull]
        public int ID { get; set; }
        [Required(ErrorMessage = "O Tipo de Lançamento é Obrigatório!")]
        [NotNull]
        public string TipoLancamento { get; set; }
        [Required(ErrorMessage = "O Valor é Obrigatório! ")]
        [NotNull]
        public decimal Valor {  get; set; }
        public DateTime? DataVencimento { get; set; }
        [Required(ErrorMessage = "O Tipo do Evento é Obrigatório")]
        [NotNull]
        public string TipoEvento { get; set; }
        [Required(ErrorMessage = "A Categoria é Obrigatória")]
        [NotNull]
        public string Categoria { get; set; }
        public string? Descricao { get; set; }

        ControleFinanceiroContext _context = new ControleFinanceiroContext();

        public void ValidaClasse()
        {
            ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(this, context, results, true);

            if ( !isValid)
            {
                StringBuilder sbrErrors = new StringBuilder();
                foreach(var validationResult in results) 
                {
                    sbrErrors.AppendLine(validationResult.ErrorMessage);

                }
                throw new ValidationException(sbrErrors.ToString());
            }
        }

        // INICIO DO CRUD 

        public void IncluirFinanceiro()
        {
            var financeiro = new DAL<Financeiro>(_context);
            financeiro.Adicionar(this);            
        }

        public Financeiro RetornaFinanceiroPorID(int id)
        {
            var financeiro = new DAL<Financeiro>(_context);
            return financeiro.RetornaPor(f => f.ID.Equals(id));
        }

        public void AlterarFinanceiro()
        {
            var financeiro = new DAL<Financeiro>(_context);
            financeiro.Atualizar(this);
        }

        public void ApagarFinanceiro()
        {
            var financeiro = new DAL<Financeiro>(_context);
            financeiro.Deletar(this);
        }

        public IEnumerable<Financeiro> RetornaListaDeFinanceiro()
        {
            var financeiro = new DAL<Financeiro>(_context);
            return financeiro.ObterTodosOsRegistros();
        }
    }
}
