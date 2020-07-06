namespace Festival.mapeamento
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Festival.or;
    using FluentNHibernate.Mapping;

    public class EventoMap : ClassMap<Festival.or.Evento>
    {
        public EventoMap()
        {
            Id(c => c.id_evento);
            Map(c => c.titulo);
            Map(c => c.descricao);
            Map(c => c.dataInicial);
            Map(c => c.dataFinal);
            Table("festival");
        }
    }
}
