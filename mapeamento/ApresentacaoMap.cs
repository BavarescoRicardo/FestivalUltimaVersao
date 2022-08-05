    namespace Festival.mapeamento
{
    using Festival.or;
    using FluentNHibernate.Mapping;

    class ApresentacaoMap : ClassMap<Festival.or.Apresentacao>
    {
        // Classe correta mapeamento com fk
        public ApresentacaoMap()
        {
            Id(c => c.id_apresentacao);
            Map(c => c.tom);
            Map(c => c.gravacao);
            Map(c => c.musica);
            Map(c => c.artista);
            Map(c => c.nomeartistico);
            Map(c => c.ordem);
            Map(c => c.senha);
            Map(c => c.ativo);
            References<Cantor>(x => x.cantor).Column("cantor").ForeignKey("id_cantor");
            References<Categoria>(x => x.categoria).Column("categoria").ForeignKey("id_categoria");

            Table("apresentacao");
        }
    }
}