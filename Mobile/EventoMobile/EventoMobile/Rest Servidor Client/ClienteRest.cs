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
using System.Runtime.ExceptionServices;
using Newtonsoft.Json.Linq;

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
                using (HttpWebResponse response = await webRequest.GetResponseAsync().ConfigureAwait(false) as HttpWebResponse)
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

        public async Task<string> readResponseAsync(string inputAddress)
        {
            HttpWebRequest request = HttpWebRequest.Create(inputAddress) as HttpWebRequest;
            request.Method = WebRequestMethods.Http.Get;
            request.ContentType = "application/json";
            HttpWebResponse response;
            try
            {
                response = (HttpWebResponse)(await request.GetResponseAsync().ConfigureAwait(false));
            }
            catch (WebException we)
            {
                response = (HttpWebResponse)we.Response;
            }

            string responseJson;
            using (var responseStream = new StreamReader(response.GetResponseStream()))
            {
                var responseStr = await responseStream.ReadToEndAsync().ConfigureAwait(false);
                responseJson = responseStr.ToString(); // I'm fine throwing a parse error here.
            }

            if (response.StatusCode == HttpStatusCode.OK) // Could probably relax this to "non-failing" codes.
            {
                return responseJson.ToString();
            }
            else
            {
                throw new Exception("Erro leitura do json web metodo async");
            }
        }

    }
}

