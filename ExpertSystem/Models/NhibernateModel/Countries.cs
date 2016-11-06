using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpertSystem.Models.NhibernateModel
{
    public class Countries
    {
        public virtual int Id { get; set;}

        public virtual string CountryName { get; set; }

        public virtual PartOfTheWorldEnum PartOfTheWorldEnum { get; set; }

        public virtual bool IsSafetyCountry { get; set; }
    }
}