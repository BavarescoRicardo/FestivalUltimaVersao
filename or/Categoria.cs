using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Festival.or
{
   public class Categoria
    {
        public virtual long id_categoria { get; set; }
        public virtual string categoria { get; set; }
        public virtual DateTime dia { get; set; }

        public Categoria()
        {
        }

        public Categoria(int id,string categoria,DateTime dia)
        {
            this.id_categoria = id;
            this.categoria = categoria;
            this.dia = dia;
        }
    }
}
