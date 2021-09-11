using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Message()
        {
            return View();
        }
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult ShowPerson()
        {
            List<Person> persons = new List<Person>()
            {
                    new Person { firstName = "Fahmeeda", lastName = "Nazneen" },
                    new Person { firstName = "Zakia", lastName = "Farheen" },
                    new Person { firstName = "Abdul Qayyum", lastName = "Hazari" },

            };
            return View(persons);
        }

    }
}