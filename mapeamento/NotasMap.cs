    namespace Festival.mapeamento
{
    using Festival.or;
    using FluentNHibernate.Mapping;

    class NotasMap : ClassMap<Festival.or.Notas>
    {
        public NotasMap()
        {
            Id(c => c.id_notas);
            Map(c => c.nota1);
            Map(c => c.nota2);
            Map(c => c.nota3);
            Map(c => c.nota4);
            Map(c => c.cantor);
            Map(c => c.categoria);
            Map(c => c.jurado);
            Map(c => c.apresentacao);
            Map(c => c.notafinal);
            /*            References<Cantor>(x => x.cantor).Column("cantor").ForeignKey("id_cantor");
                        References<Categoria>(x => x.categoria).Column("categoria").ForeignKey("id_categoria");
                        References<Jurado>(x => x.jurado).Column("jurado").ForeignKey("id_jurado");
                        References<Apresentacao>(x => x.apresentacao).Column("apresentacao").ForeignKey("id_apresentacao");*/

            Table("notas");
        }
    }
}