    namespace Festival.mapeamento
{
    using Festival.or;
    using FluentNHibernate.Mapping;

    class ClassificacaoMap : ClassMap<Festival.or.Classificacao>
    {
        public ClassificacaoMap()
        {
            Id(c => c.id_classificacao);
            Map(c => c.notafinal);
            References<Apresentacao>(x => x.apresentacao).Column("apresentacao").ForeignKey("id_apresentacao");
            References<Cantor>(x => x.cantor).Column("cantor").ForeignKey("id_cantor");
            References<Categoria>(x => x.categoria).Column("categoria").ForeignKey("id_categoria");

            Table("classificacao");
        }
    }
}