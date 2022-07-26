using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Festival.or
{
   public class Categoria
    {
        public virtual int id_categoria { get; set; }
        public virtual string categoria { get; set; }
        public virtual DateTime dia { get; set; }

        public Categoria()
        {
        }

        public Categoria(int id,string categoria)
        {
            this.id_categoria = id;
            this.categoria = categoria;
            this.dia = dia;
        }

        public override string ToString()
        {
            return this.categoria + " " + this.id_categoria;
        }

    } 
}
