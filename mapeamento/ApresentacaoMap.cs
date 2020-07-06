    namespace Festival.mapeamento
{
    using FluentNHibernate.Mapping;

    class ApresentacaoMap : ClassMap<Festival.or.Apresentacao>
    {
        public ApresentacaoMap()
        {
            Id(c => c.id_apresentacao);
            Map(c => c.musica);
            Map(c => c.artista);
            Map(c => c.cantor);
            Map(c => c.categoria);

            // Deveria fazer isto 
            // INSERT INTO `evento`.`apresentacao` (`musica`, `artista`, `cantor`, `categoria`) VALUES ('simfonia da noite', 'cleiton rasta', '1', '3'); 

            Table("apresentacao");
        }
    }
}