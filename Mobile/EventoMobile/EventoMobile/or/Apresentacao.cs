using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Festival.or
{
    public class Apresentacao
    {
        public Apresentacao()
        {

        }

        public Apresentacao(int id_apresentacao, string musica, string artista, int cantor, int categoria)
        {
            this.id_apresentacao = id_apresentacao;
            this.musica = musica;
            this.artista = artista;
            this.cantor = cantor;
            this.categoria = categoria;
        }

        public virtual int id_apresentacao { get; set; }
        public virtual string musica { get; set; }
        public virtual string artista { get; set; }
        public virtual int cantor { get; set; }
        public virtual int categoria { get; set; }
    }
}
