using ExpertSystem.Helpers;
using ExpertSystem.Models;
using ExpertSystem.Models.NhibernateModel;
using NHibernate;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExpertSystem.Controllers
{
    public class MainController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            
                return View(new PartOfTheWorldModel());
        }

        [HttpPost]
        public ActionResult Index(PartOfTheWorldModel model)
        {
            if (ModelState.IsValid && (int)model.PartOfTheWorld != 0)
            {
                return RedirectToAction("Country", new { partOfTheWorldId = (int)model.PartOfTheWorld });
            }
            return View(model);
        }

        public ActionResult Country(int partOfTheWorldId)
        {

            List<Country> countries;
            using (var db = new ExpertSystemEntities1())
            {
                countries = db.Countries.Where(x => (x.PartOfTheWorldEnum == partOfTheWorldId) && 
                (x.IsSafetyCountry.HasValue && x.IsSafetyCountry.Value)).ToList();
            };
            return View(countries);
        }
    }
}