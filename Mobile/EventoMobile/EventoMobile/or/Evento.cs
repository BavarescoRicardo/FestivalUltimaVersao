using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Festival.or
{
    public class Evento
    {
        public Evento(long id, string titulo, string descricao, DateTime dataInicial, DateTime dataFinal)
        {
            this.id_evento = id;
            this.titulo = titulo;
            this.descricao = descricao;
            this.dataInicial = dataInicial;
            this.dataFinal = dataFinal;
        }

        public Evento()
        {

        }

        // Atributos do objeto evento
        public virtual long id_evento { get; set; }
        public virtual string titulo { get; set; }
        public virtual string descricao { get; set; }
        public virtual DateTime dataInicial { get; set; }
        public virtual DateTime dataFinal { get; set; }
    }
}
