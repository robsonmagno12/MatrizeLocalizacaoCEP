using Mix.Models;
using Newtonsoft.Json;
using System.Net;

namespace Mix.Controllers
{
    class ViaCEPServicoController
    {
        private static string EnderecoURL = "http://viacep.com.br/ws/{0}/json/";
        public static cepModel BuscarEnderecoViaCEP(string cep)
        {
            string NovoEnderecoURL = string.Format(EnderecoURL, cep);
            string Conteudo = "";
            cepModel End = new cepModel();
            WebClient wc = new WebClient();
            Conteudo = wc.DownloadString(NovoEnderecoURL);
            End = JsonConvert.DeserializeObject<cepModel>(Conteudo);
            if (End.Cep == null) return null;
            return End;
        }
    }
}
