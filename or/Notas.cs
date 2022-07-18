using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Festival.or
{
    class Notas
    {
        public virtual int id_nota { get; set; }
        public virtual Apresentacao apresentacao{ get; set; }
        public virtual Jurado jurado { get; set; }
        public virtual Cantor cantor { get; set; }
        public virtual Categoria categoria { get; set; }

        public virtual Double nota1 { get; set; }
        public virtual Double nota2 { get; set; }
        public virtual Double nota3 { get; set; }
        public virtual Double nota4 { get; set; }
        public virtual Double nota5 { get; set; }


        public Notas()
        {

        }

        public override string ToString()
        {
            // return "Apresentac";
            /*if (this.cantor.ToString().Length > 0)
            {
                return string.Format("{0} {1}", this.id_apresentacao, this.musica);
            }*/

            return string.Format("{0} {1}", this.id_nota, this.cantor.nome);
        }
    }
}
