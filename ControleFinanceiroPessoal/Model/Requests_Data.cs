using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace ControleFinanceiroPessoal.Model
{
    internal class Requests_Data
    {
        public static string GeraJsonCEP(string cep)
        {
            System.Net.HttpWebRequest request = (HttpWebRequest)WebRequest.Create($@"https://viacep.com.br/ws/{cep}/json/");
            HttpWebResponse response = (HttpWebResponse) request.GetResponse();

            int cont;
            byte[] buffer = new byte[1000];
            StringBuilder sb = new StringBuilder();
            string temp;
            Stream stream = response.GetResponseStream();
            do
            {
                cont = stream.Read(buffer, 0, buffer.Length);
                temp = Encoding.Default.GetString(buffer, 0 , cont).Trim();
                sb.Append(temp);
            }while (cont > 0);
            return sb.ToString();

        }
    }
}
