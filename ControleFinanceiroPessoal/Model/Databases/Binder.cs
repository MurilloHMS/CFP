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
                if (!(File.Exists($@"{directory}\{ID}")))
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
    }
}
