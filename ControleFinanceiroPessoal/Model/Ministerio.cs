using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiroPessoal.Model
{
    internal class Ministerio
    {
        public string ID { get; set; }
        public string NomeMinisterio {  get; set; }
        public List<Member> Lideres { get; set; }
        public List<Member> Membros { get; set; }


        public Ministerio() 
        {
            Lideres = new List<Member>();
            Membros = new List<Member>();

        }

        //INICIO DO CRUD

        public void IncluirMinisterio(string conexao)
        {
            string ministerioJson = SerializedClassUnit(this);

            Databases.Binder B = new Databases.Binder(conexao);

            if (B.status)
            {
                B.Include(this.ID, ministerioJson);
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

        public Ministerio BuscarMembro(string id, string conexao)
        {
            Databases.Binder B = new Databases.Binder(Path.Combine(conexao));
            if (B.status)
            {
                string ministerioJson = B.Search(id);
                return DesSerializedClassUnit(ministerioJson);
            }
            else
            {
                throw new Exception(B.message);
            }

        }

        public void AlterarFichario(string conexao)
        {
            string ministerioJson = SerializedClassUnit(this);
            Databases.Binder B = new Databases.Binder(Path.Combine(conexao));
            if (B.status)
            {
                B.Update(this.ID, ministerioJson);
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

        public void ApagarMinisterio(string conexao)
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

        public List<string> ListaMinisterios(string conexao)
        {
            Databases.Binder B = new Databases.Binder(Path.Combine(conexao));
            if (B.status)
            {
                List<string> todosMinisterios = B.SearchAll();
                return todosMinisterios;
            }
            else
            {
                throw new Exception(B.message);
            }
        }

        public static Ministerio DesSerializedClassUnit(string vJason)
        {
            return JsonConvert.DeserializeObject<Ministerio>(vJason);
        }

        public static string SerializedClassUnit(Ministerio unit)
        {
            return JsonConvert.SerializeObject(unit);
        }
    }

    
}
