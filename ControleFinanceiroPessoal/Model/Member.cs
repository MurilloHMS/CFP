using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Diagnostics;

namespace ControleFinanceiroPessoal.Model
{
    internal class Member
    {
        public class Unit
        {
            //
            //Dados do cadastro
            //
            
            [RegularExpression("([0-9]+)", ErrorMessage = "O ID deve conter apenas números.")]
            [StringLength(6, ErrorMessage ="O ID deve ter no máximo 6 caracteres.")]
            public string ID { get; set; }

            [Required(ErrorMessage = "O Nome é Obrigatório")]
            [StringLength(100, ErrorMessage = "O Nome deve ter no máximo 100 caracteres.")]
            public string Nome { get; set; }

            [Required(ErrorMessage = "O E-Mail é Obrigatório")]
            [StringLength(100, ErrorMessage = "O E-mail deve ter no máximo 100 caracteres.")]
            public string Email { get; set; }

            [Required(ErrorMessage = "O Telefone é Obrigatório")]
            //[RegularExpression("([0-9]+)", ErrorMessage = "O Telefone deve conter apenas números.")]
            //[StringLength(11, ErrorMessage = "O Telefone deve ter no máximo 11 caracteres.")]
            public string Telefone { get; set; }

            public string DataDeNascimento { get; set; }

            [Required(ErrorMessage = "A Pergunta se é cristão é Obrigatória")]
            public string PerguntaECristao { get; set; }

            [Required(ErrorMessage = "A Pergunta se frequenta igreja é Obrigatória")]
            public string PerguntaFrequentaIgreja { get; set; }
            //
            //Dados Endereço
            //

            //[RegularExpression("([0-9]+)", ErrorMessage = "O CEP deve conter apenas números.")]
            //[StringLength(8, ErrorMessage = "O CEP deve ter no máximo 8 caracteres.")]
            public string CEP { get; set; }

            [StringLength(100, ErrorMessage = "A Rua deve ter no máximo 100 caracteres.")]
            public string Rua {  get; set; }

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


            //INICIO DO CRUD

            public void IncluirMembro(string conexao)
            {
                string membroJson = Member.SerializedClassUnit(this);

                Databases.Binder B = new Databases.Binder(conexao);

                if (B.status)
                {
                    B.Include(this.ID, membroJson);
                    if (!(B.status))
                    {
                        throw new Exception(B.message);
                    }
                }
                else
                {
                    throw new Exception(B.message);
                }
            }

            public Unit BuscarMembro(string id, string conexao)
            {
                Databases.Binder B = new Databases.Binder(Path.Combine(conexao));
                if (B.status)
                {
                    string membroJson = B.Search(id);
                    return Member.DesSerializedClassUnit(membroJson);
                }
                else
                {
                    throw new Exception(B.message);
                }
                
            }

            public void AlterarFichario(string conexao)
            {
                string membroJson = Member.SerializedClassUnit(this);
                Databases.Binder B = new Databases.Binder(Path.Combine(conexao));
                if (B.status)
                {
                    B.Update(this.ID, membroJson);
                    if (!(B.status))
                    {
                        throw new Exception(B.message);
                    }
                }
                else
                {
                    throw new Exception(B.message);
                }
            }

            public void ApagarMembro(string conexao)
            {
                Databases.Binder B = new Databases.Binder(Path.Combine(conexao));
                if (B.status)
                {
                    B.Clear(this.ID);
                    if (!(B.status))
                    {
                        throw new Exception(B.message);
                    }
                }
                else
                {
                    throw new Exception(B.message);
                }
            }
            
            public List<string> ListaMembros(string conexao)
            {
                Databases.Binder B = new Databases.Binder(Path.Combine(conexao));
                if (B.status)
                {
                    List<string> todosMembros = B.SearchAll();
                    return todosMembros;
                }
                else
                {
                    throw new Exception(B.message);
                }
            }
        }       

        public class List
        {
            public List<Unit> ListUnit { get; set; }

        }
        public static Unit DesSerializedClassUnit(string vJason)
        {
            return JsonConvert.DeserializeObject<Unit>(vJason);
        }

        public static string SerializedClassUnit(Unit unit)
        {
            return JsonConvert.SerializeObject(unit);
        }



    }
}
