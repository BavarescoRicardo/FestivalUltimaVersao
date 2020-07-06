

namespace Festival.mapeamento
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using FluentNHibernate.Cfg;
    using FluentNHibernate.Cfg.Db;
    using NHibernate;

    public class FluentySessionFactory
    {
        private static String ConnectionString = "Server=localhost; Port=3306; User Id=root; Password=admin; Database=evento";
        private static ISessionFactory session;
        public static ISessionFactory CriarSessao()
        {
            if (session != null)
            {
                return session;
            }
            IPersistenceConfigurer dbConfig = MySQLConfiguration.Standard.ConnectionString(ConnectionString);


            var mapConfig = Fluently.Configure().Database(MySQLConfiguration.Standard
                    .ConnectionString(ConnectionString))
                .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()));

            session = mapConfig.BuildSessionFactory();
            return session;
            
        }
        public static ISession AbrirSessao()
        {
            return CriarSessao().OpenSession();
        }
    }
}