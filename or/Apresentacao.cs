﻿using Festival.bo;
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

        public Apresentacao(string tom, string gravacao, string musica, string artista, Cantor cantor, Categoria categoria, string nomeartistico)
        {
            this.id_apresentacao = id_apresentacao;
            this.gravacao = gravacao;
            this.nomeartistico = nomeartistico;
            this.musica = musica;
            this.artista = artista;
            this.cantor = cantor;
            this.categoria = categoria;
        }

        public virtual int id_apresentacao { get; set; }
        public virtual string tom { get; set; }
        public virtual string gravacao { get; set; }
        public virtual string musica { get; set; }
        public virtual string artista { get; set; }
        public virtual string nomeartistico { get; set; }
        public virtual Cantor cantor { get; set; }
        public virtual Categoria categoria { get; set; }

        private CantorBo bo = new CantorBo();

        public override string ToString()
        {
            return string.Format("{0} {1}", this.musica, this.bo.RetornePeloId(this.cantor.id_cantor));
        }

    }
}
