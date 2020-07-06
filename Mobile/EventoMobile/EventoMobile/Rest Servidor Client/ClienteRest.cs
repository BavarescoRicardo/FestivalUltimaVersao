using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace EventoMobile.Rest_Servidor_Client
{
    class ClienteRest
    {
        private static readonly HttpClient client = new HttpClient();
        public string endPoint { get; set; }

        public ClienteRest()
        {
            endPoint = string.Empty;
        }

        public async Task<string> obterDados(string url)
        {
            string resposta = string.Empty;
            try
            {
                HttpWebRequest webRequest = HttpWebRequest.Create(url) as HttpWebRequest;
                webRequest.Method = WebRequestMethods.Http.Get;
                //webRequest.Credentials = new NetworkCredential("", "");
                webRequest.ContentType = "application/json";
                using (HttpWebResponse response = webRequest.GetResponse() as HttpWebResponse)
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        Stream stream = response.GetResponseStream(); 
                         using (StreamReader reader = new StreamReader(stream))
                        {
                            resposta = reader.ReadToEnd();
                        }
                        return resposta;

                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erros foram cometidos ao ler  "+ ex.Message);
            }
            return resposta;
        }

        public async Task enviarDadosAsync(string url, string id)
        {

            StringContent content = new StringContent(id, Encoding.UTF8, "application/json");

            HttpResponseMessage response = null;
            response = await client.PostAsync(url, content);
            
        }
    }
}

