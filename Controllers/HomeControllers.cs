using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;

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
          Contact.ClearAll();
          return View();
        }

        [HttpPost("/addressbook/create")]
        public ActionResult ContactCreate()
        {
          Contacts newContact = new Contacts (Request.Form["new-contact"],
            int.Parse(Request.Form["new-contact-phonenumber"]),
            int.Parse(Request.Form["new-address"])
          );
          newContact.Save();
          return View(newContact);
        }
    }
}
