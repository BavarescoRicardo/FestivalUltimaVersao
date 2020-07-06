using Festival.or;
using Festival.bo;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Web.Http;
using System.Xml;
using System.Web.Http.Description;
using System.Net.Http;
using System.Threading.Tasks;

namespace Servidor.Controllers
{
    public class juriController : ApiController
    {
        
        private static List<Jurado> juri = new List<Jurado>();

        [HttpGet]
        public async Task<List<Jurado>> Get()
        {
            JuradoBo bo = new JuradoBo();
            IList<Festival.or.Jurado> lista = bo.Listar();

            juri = lista.ToList();
            return juri;
        }

        public async void Post(string id)
        {
            JuradoBo bo = new JuradoBo();
            IList<Festival.or.Jurado> lista = bo.Listar();
            int identificador = 0;
            try
            {
                identificador = Int32.Parse(id);
                if (identificador > 0) { 
                    Jurado juradoAtual = lista.ToList().Where(x => x.id_jurado == identificador).Take(1).SingleOrDefault<Jurado>();
                    Console.WriteLine("O jurado selecionado foi " + juradoAtual.nome);
                }
            }
            catch (Exception)
            {
                throw;
            }
            
        }
    }
}