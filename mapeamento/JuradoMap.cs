using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Festival.mapeamento
{
    public class JuradoMap : ClassMap<Festival.or.Jurado>
    {
        public JuradoMap()
        {
            Id(c => c.id_jurado);
            Map(c => c.nome);
            Map(c => c.contato);
            Map(c => c.documento);
            Map(c => c.observacao);
            Table("Jurado");
        }
    }
}
