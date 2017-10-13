using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;

namespace AddressBook.Controllers
{
    public class HomeController : Controller
    {

        [Route("/")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("/addresbook")]
        public ActionResult Contacts()
        {
          List<Contacts> allContacts = Contacts.GetAll();
          return View(allContacts);
        }

        [HttpPost("/addressbook/user")]
        public ActionResult ContactUser()
        {
          Car.ClearAll();
          return View();
        }

        [HttpPost("/addressbook/create")]
        public ActionResult ContactCreate()
        {
          Contacts newCar = new Contacts (Request.Form["new-contact"],
            int.Parse(Request.Form["new-car-phonenumber"]),
            int.Parse(Request.Form["new-address"])
          );
          newContact.Save();
          return View(newContact);
        }
    }
}
