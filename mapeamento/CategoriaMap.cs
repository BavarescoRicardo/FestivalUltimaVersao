namespace Festival.mapeamento
{
    using FluentNHibernate.Mapping;

    class CategoriaMap : ClassMap<Festival.or.Categoria>
    {
        public CategoriaMap()
        {
            Id(c => c.id_categoria);
            Map(c => c.categoria);
            Map(c => c.dia);
            Table("categoria");
        }
    }
}
