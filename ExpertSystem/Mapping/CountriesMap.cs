using ExpertSystem.Models.NhibernateModel;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpertSystem.Mapping
{
    public class CountriesMap : ClassMap<Countries>
    {
        public CountriesMap()
        {
            Table("Countries");
            Id(x => x.Id);
            Map(x => x.CountryName, "CountryName");
            Map(x => x.PartOfTheWorldEnum, "PartOfTheWorldEnum");
            Map(x => x.IsSafetyCountry, "IsSafetyCountry");
        }
    }
}