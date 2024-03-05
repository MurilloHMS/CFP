using ControleFinanceiroPessoal.Forms.UC;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                { ".xlsx", "excel\\xlsx" },
                { ".xlsm", "excel\\xlsm" },
                { ".csv", "excel\\csv" },
                { ".pdf" , "arquivos\\pdf" },
                { ".html", "arquivos\\html" },
                { ".json", "arquivos\\json" },
                { ".pptx", "arquivos\\powerPoint" },
                { ".docx", "arquivos\\word" },
                { ".xml" , "arquivos\\xml" },
                { ".XML" , "arquivos\\xml" },
                { ".dbf" , "arquivos\\dbf" },
                { ".DBF" , "arquivos\\dbf" },
                { ".ipynb" , "arquivos\\jupyter" },
                { ".js" , "arquivos\\javascript" },
                { ".pbix" , "arquivos\\powerBi" },
                { ".sqlite" , "arquivos\\sqlLite" },
                { ".sql" , "arquivos\\sql" },
                { ".bas" , "arquivos\\bat" },
                { ".pfx" , "arquivos\\certificados" },
                { ".css" , "arquivos\\html\\css" },
                { ".exe" , "arquivos\\executaveis" },
                { ".py" , "arquivos\\python" },
                { ".txt" , "arquivos\\txt" },
                { ".iso" , "downloads\\iso" },
                { ".ico" , "imagens\\icons" },
                { ".png" , "imagens\\png" },
                { ".jpg" , "imagens\\jpg" },
                { ".jpeg" , "imagens\\jpeg" },
                { ".mp3" , "musicas" },
                { ".mp4" , "musicas" }
            };

            ClearLog(textBoxLog);
            AddLog(textBoxLog, $"Início do processo de transferência em {DateTime.Now}");

            // Inicializa a ProgressBar
            progressBar.Minimum = 0;
            progressBar.Value = 0;

            // Obtém todos os arquivos, incluindo os das subpastas
            string[] allFiles = Directory.GetFiles(pastaOrigem, "*", SearchOption.AllDirectories);
            int totalFiles = allFiles.Length;

            // Atualiza o máximo da ProgressBar
            progressBar.Maximum = totalFiles;

            // Caminho do diretório de log
            string logDirectory = Path.Combine(pastaOrigem, "log");

            // Cria o diretório de log se não existir
            if (!Directory.Exists(logDirectory))
            {
                Directory.CreateDirectory(logDirectory);
            }

            // Caminho do arquivo de log
            string logPath = Path.Combine(logDirectory, "logs.txt");

            // Cria ou abre o arquivo de log
            using (StreamWriter logWriter = new StreamWriter(logPath, true))
            {
                // Escreve a informação de início no log
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
                        try
                        {
                            File.Move(file, caminhoDestino, true);
                        }catch (Exception ex)
                        {
                            string messageLogs = $"{DateTime.Now} - Erro ao Mover o arquivo: {ex.Message}";
                            AddLog(textBoxLog, messageLogs);
                        }


                        string messageLog = $"{DateTime.Now} - Arquivo {Path.GetFileName(file)} movido para {caminhoDestino}";
                        AddLog(textBoxLog, messageLog);

                        // Escreve o log no arquivo
                        logWriter.WriteLine(messageLog);
                    }
                    else
                    {
                        string messageLog = $"{DateTime.Now} - Extensão não mapeada: {extension}";
                        AddLog(textBoxLog, messageLog);

                        // Escreve o log no arquivo
                        logWriter.WriteLine(messageLog);
                    }
                    // Atualiza progressBar
                    progressBar.Value++;
                }

                // Escreve o fim do log
                string messageFimLog = $"Fim do processo de transferência em {DateTime.Now}";
                logWriter.WriteLine(messageFimLog);
                AddLog(textBoxLog, messageFimLog);
            }

            // Limpa progressBar após concluir
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
