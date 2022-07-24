using Festival.bo;

namespace Festival.or
{
    public class ApresentacaoDtoReport
    {
        public ApresentacaoDtoReport()
        {

        }

        public ApresentacaoDtoReport(int id_apresentacao, string tom, string gravacao, string musica, string artista, int id_cantor, int id_categoria)
        {
            CategoriaBo categoriaBo = new CategoriaBo();
            CantorBo cantorBo = new CantorBo();

            this.id_apresentacao = id_apresentacao;

            this.musica = musica;
            this.tom = tom;
            this.gravacao = gravacao;
            this.artista = artista;
            this.cantor = cantorBo.RetornePeloId(id_cantor);
            this.categoria = categoriaBo.RetornePeloId(id_categoria);
        }

        public virtual int id_apresentacao { get; set; }
        public virtual string tom { get; set; }
        public virtual string gravacao { get; set; }
        public virtual string musica { get; set; }
        public virtual string artista { get; set; }
        public virtual Cantor cantor { get; set; }
        public virtual Categoria categoria { get; set; }

        private CantorBo bo = new CantorBo();

        public override string ToString()
        {
            return string.Format("{0} {1}", this.musica, this.bo.RetornePeloId(this.cantor.id_cantor));
        }

    }
}
