    namespace Festival.mapeamento
{
    using Festival.or;
    using FluentNHibernate.Mapping;

    class ApresentacaoMap : ClassMap<Festival.or.Apresentacao>
    {
        public ApresentacaoMap()
        {
            Id(c => c.id_apresentacao);
            Map(c => c.musica);
            Map(c => c.artista);
            References<Cantor>(x => x.cantor).Column("cantor").ForeignKey("id_cantor");
            References<Categoria>(x => x.categoria).Column("categoria").ForeignKey("id_categoria");

            // Deveria fazer isto 
            // INSERT INTO `evento`.`apresentacao` (`musica`, `artista`, `cantor`, `categoria`) VALUES ('simfonia da noite', 'cleiton rasta', '1', '3'); 

            Table("apresentacao");
        }
    }
}