using Festival.bo;

namespace Festival.or
{
    public class Apresentacao
    {
        public Apresentacao()
        {

        }

        public Apresentacao(int id_apresentacao, string tom, string gravacao, string musica, string artista, string nomeartistico,
             string ordem, string senha, char ativo, Cantor cantor, Categoria categoria)
        {
            this.id_apresentacao = id_apresentacao;
            this.tom = tom;
            this.gravacao = gravacao;
            this.musica = musica;
            this.artista = artista;
            this.nomeartistico = nomeartistico;
            this.ordem = ordem;
            this.senha = senha;
            this.ativo = ativo;
            this.cantor = cantor;
            this.categoria = categoria;
        }

        public Apresentacao(string tom, string gravacao, string musica, string artista, Cantor cantor, Categoria categoria, string nomeartistico)
        {
            this.id_apresentacao = id_apresentacao;
            this.gravacao = gravacao;
            this.tom = tom;
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
        public virtual string ordem { get; set; }
        public virtual string senha { get; set; }
        public virtual char ativo { get; set; }
        public virtual bool presenca { get; set; }
        public virtual Cantor cantor { get; set; }
        public virtual Categoria categoria { get; set; }

        private CantorBo bo = new CantorBo();

        public override string ToString()
        {
            return string.Format("{0} {1}", this.musica, this.bo.RetornePeloId(this.cantor.id_cantor));
        }

    }
}
