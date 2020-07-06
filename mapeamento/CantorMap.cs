namespace Festival.mapeamento
{
    using FluentNHibernate.Mapping;

     class CantorMap : ClassMap<Festival.or.Cantor>
    {
        public CantorMap()
        {
            Id(c => c.id_cantor);
            Map(c => c.nome);
            Map(c => c.email);
            Map(c => c.contato);
            Map(c => c.cpf);
            Map(c => c.rg);
            Map(c => c.observacao);
            Table("cantor");
        } 
    }
}
