using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Festival.or
{
    public class Notas
    {
        public Notas()
        {

        }

        public Notas(int id_notas, double nota1, double nota2, int cantor,
            int categoria, int jurado, int apresentacao)
        {
            this.id_notas = id_notas;
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.cantor = cantor;
            this.categoria = categoria;
            this.jurado = jurado;
            this.apresentacao = apresentacao;
        }

        public virtual int id_notas { get; set; }
        public virtual double nota1 { get; set; }
        public virtual double nota2 { get; set; }
        public virtual int cantor { get; set; }
        public virtual int categoria { get; set; }
        public virtual int jurado { get; set; }
        public virtual int apresentacao { get; set; }

/*        public override string ToString()
        {
            return string.Format("{0} {1}", this.cantor, this.nota1);
        }*/
    }
}
