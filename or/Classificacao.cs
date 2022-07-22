using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Festival.or
{
    class Classificacao
    {
        public Classificacao()
        {

        }

        public Classificacao(int id_classificacao, double notafinal, Apresentacao apresentacao)
        {
            this.id_classificacao = id_classificacao;
            this.notafinal = notafinal;
            this.apresentacao = apresentacao;
        }

        public virtual int id_classificacao { get; set; }
        public virtual double notafinal { get; set; }
        public virtual Apresentacao apresentacao { get; set; }
        public virtual Cantor cantor { get; set; }
        public virtual Categoria categoria { get; set; }
    }
}
