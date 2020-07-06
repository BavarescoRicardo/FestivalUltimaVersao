using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Festival.or
{
    public class xJurado
    {
        public xJurado(int id_jurado, string nome, string contato, string documento, string observacao)
        {
            this.id_jurado = id_jurado;
            this.nome = nome;
            this.contato = contato;
            this.documento = documento;
            this.observacao = observacao;
        }

        public xJurado()
        {

        }

        public override string ToString()
        {
            return this.nome;
        }
        public virtual int id_jurado { get; set; }
        public virtual string nome { get; set; }
        public virtual string contato { get; set; }
        public virtual string documento { get; set; }
        public virtual string observacao { get; set; }
        
    }
}
