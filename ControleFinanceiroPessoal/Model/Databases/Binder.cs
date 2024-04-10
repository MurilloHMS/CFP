using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.DirectoryServices.ActiveDirectory;

namespace ControleFinanceiroPessoal.Model.Databases
{
    internal class Binder
    {
        public string directory;
        public string message;
        public bool status;

        public Binder(string Path) 
        {
            status = true;
            try
            {
                if (!(Directory.Exists(Path)))
                {
                    Directory.CreateDirectory(Path);
                }
                directory = Path;
                message = "Conexão com o fichario criada com sucesso";

            }
            catch(Exception ex)
            { 
                status =false;
                message = $"Conexão falhou {ex.Message}";
            }
        }

        public void Include(string ID, string JsonUnit)
        {
            status = true;

            try
            {
                if (!(File.Exists($@"{directory}\{ID}.json")))
                {
                    File.WriteAllText($@"{directory}\{ID}.json", JsonUnit);
                    status = true;
                    message = "Inclusão efetuada com sucesso";
                }
                else
                {
                    status = false;
                    message = $"o ID: {ID} já existe";
                }
            }
            catch (Exception ex)
            {

                status = false;
                message = $"Erro ao criar o arquivo {ex.Message}";
            }            
        }

        public string Search(string ID)
        {
            status = true;

            try
            {
                if (!(File.Exists($@"{directory}\{ID}.json")))
                {
                    status = false;
                    message = "Identificador não existe";
                }
                else
                {
                    string conteudo = File.ReadAllText($@"{directory}\{ID}.json");
                    status = true;
                    return conteudo;
                }

            }
            catch (Exception ex)
            {
                status = false;
                message = $"Erro ao buscar o conteudo do identificador: {ex.Message}";
            }

            return "";
        }
        public List<string> SearchAll()
        {
            status = true;
            List<string> list = new List<string>();

            try
            {
                var files = Directory.GetFiles(directory, "*.json");
                foreach (var file in files)
                {
                    string conteudo = File.ReadAllText(file);
                    list.Add(conteudo);
                }
                return list;

            }
            catch (Exception ex)
            {
                status = false;
                message = $"Erro ao buscar o conteudo: {ex.Message}";
            }

            return list;
        }

        public void Clear(string ID)
        {
            status = true;

            try
            {
                if (!(File.Exists($@"{directory}\{ID}.json")))
                {
                    status = false;
                    message = "Identificador não existe";
                }
                else
                {
                    File.Delete($@"{directory}\{ID}.json");
                    status = true;
                    message = "Exclusão efetuada com sucesso";                    
                }

            }
            catch (Exception ex)
            {
                status = false;
                message = $"Erro ao buscar o conteudo do identificador: {ex.Message}";
            }
        }

        public void Update(string ID, string JsonUnit)
        {

            status = true;

            try
            {
                if (!(File.Exists($@"{directory}\{ID}.json")))
                {
                    status = false;
                    message = "Alteração não permitida porque o identificador não existe";
                }
                else
                {
                    File.Delete($@"{directory}\{ID}.json");
                    File.WriteAllText($@"{directory}\{ID}.json", JsonUnit);
                    status = true;
                    message = "inclusão efetuada com sucesso";
                }
            }
            catch (Exception ex)
            {

                status = false;
                message = $"Erro ao criar o arquivo {ex.Message}";
            }
        }
    }
}
