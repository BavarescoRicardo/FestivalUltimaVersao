using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Festival.or
{
    public class Cantor
    {
        public virtual int id_cantor { get; set; }
        public virtual string nome { get; set; }
        public virtual string email { get; set; }
        public virtual string contato { get; set; }
        public virtual string cpf { get; set; }
        public virtual string rg { get; set; }
        public virtual string observacao { get; set; }

        public Cantor()
        {

        }

        public Cantor(int id_cantor, string nome, string email, string contato, string cpf, string rg, string observacao)
        {
            this.id_cantor = id_cantor;
            this.nome = nome;
            this.email = email;
            this.contato = contato;
            this.cpf = cpf;
            this.rg = rg;
            this.observacao = observacao;
        }

    }
}
