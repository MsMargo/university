﻿using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpertSystem.Helpers
{
    //public class NHibernateHelper
    //{
    //    public static ISession OpenSession()
    //    {
    //        ISessionFactory sessionFactory = Fluently.Configure()
    //            .Database(MsSqlConfiguration.MsSql2012
    //              .ConnectionString(@"Server=DESKTOP-DDG217S;initial catalog=ExpertSystem;")
    //                          .ShowSql()
    //            )
    //           //.Mappings(m =>
    //           //           m.FluentMappings
    //           //               .AddFromAssemblyOf<Employee>())
    //            .ExposeConfiguration(cfg => new SchemaExport(cfg)
    //                                            .Create(false, false))
    //            .BuildSessionFactory();
    //        return sessionFactory.OpenSession();
    //    }
    //}
}