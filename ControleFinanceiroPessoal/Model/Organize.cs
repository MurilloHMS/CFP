using ControleFinanceiroPessoal.Forms.UC;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiroPessoal.Model
{
    internal class Organize
    {
        public static string SelectFolder()
        {
            string ret = string.Empty;
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);
                    ret = fbd.SelectedPath;
                }
            }
            return ret;
        }

        public static void OrganizeFiles(string pastaOrigem, string pastaDestino, TextBox textBoxLog, ProgressBar progressBar)
        {
            Dictionary<string, string> mapeamentoExtensaoDiretorio = new Dictionary<string, string>
            {
                {".xlsx", "excel\\xlsx" },
                { ".xlsm", "excel\\xlsm" },
                { ".pdf", "arquivos\\pdf" }
            };

            ClearLog(textBoxLog);
            AddLog(textBoxLog, $"Início do processo de transferência em {DateTime.Now}");

            //Inicializa a ProgressBar
            progressBar.Minimum = 0;
            progressBar.Value = 0;

            //Obtém todos os arquivos, incluindo os das subpastas
            string[] allFiles = Directory.GetFiles(pastaOrigem, "*", SearchOption.AllDirectories);
            int totalFiles = allFiles.Length;

            //Atualiza o máximo da ProgressBar
            progressBar.Maximum = totalFiles;

            //caminho do arquivo de log na pasta log
            string logPath = Path.Combine(pastaDestino, "log.txt");

            //cria ou abre o arquivo de log
            using (StreamWriter logWriter = new StreamWriter(logPath, true)) 
            {
                //escreve a informação de início no log
                logWriter.WriteLine($"Início do processo de transferência em {DateTime.Now}");

                foreach (string file in allFiles)
                {
                    string extension = Path.GetExtension(file);

                    if (mapeamentoExtensaoDiretorio.TryGetValue(extension, out var subDirectory))
                    {
                        string diretorioDestino = Path.Combine(pastaDestino, subDirectory);

                        if (!Directory.Exists(diretorioDestino))
                        {
                            Directory.CreateDirectory(diretorioDestino);
                        }

                        string caminhoDestino = Path.Combine(diretorioDestino, Path.GetFileName(file));
                        File.Copy(file, caminhoDestino);

                        string messageLog = $"{DateTime.Now} - Arquivo {Path.GetFileName(file)} movido para {caminhoDestino}";
                        AddLog(textBoxLog, messageLog);

                        //escreve o log no arquivo
                        logWriter.WriteLine(messageLog);
                    }
                    else
                    {
                        string messageLog = $"{DateTime.Now} - Extensão não mapeada: {extension}";
                        AddLog(textBoxLog, messageLog);

                        //escreve o log no arquivo
                        logWriter.WriteLine(messageLog);
                    }
                    //atualiza progressBar
                    progressBar.Value++;
                }

                //Escreve o fim do log
                string messageFimLog = $"Fim do processo de transferência em {DateTime.Now}";
                logWriter.WriteLine(messageFimLog);
                AddLog(textBoxLog, messageFimLog);
            }

            //limpa progressBar após concluir
            progressBar.Value = 0;

        }

        private static void AddLog(TextBox textBox, string message)
        {
            textBox.AppendText(message + Environment.NewLine);
            textBox.Update();
            textBox.Refresh();
        }

        private static void ClearLog(TextBox textBox)
        {
            textBox.Clear();
        }
    }
}
