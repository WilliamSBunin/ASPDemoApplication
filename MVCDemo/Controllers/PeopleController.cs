using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListPeople()
        {
            List<PersonModel> people = new List<PersonModel>();

            people.Add(new PersonModel { FirstName = "William", LastName = "Bunin", Age = 27, IsAlive = true });
            people.Add(new PersonModel { FirstName = "Leah", LastName = "Liberman", Age = 27, IsAlive = true });
            people.Add(new PersonModel { FirstName = "Tim", LastName = "Corey", Age = 38 });
            people.Add(new PersonModel { FirstName = "JOhn", LastName = "Doe", Age = 98, IsAlive = false });

            return View(people);
        }
    }
}