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

        [Route("/contacts")]
        public ActionResult AddressBook()
        {
          List<Contact> allContacts = Contact.GetAll();
          return View(allContacts);
        }

        [HttpPost("/addressbook/detail")]
        public ActionResult ContactDetails()
        {
          Contact.ClearAll();
          return View();
        }

        [HttpPost("/addressbook/create")]
        public ActionResult CreateContact()
        {
          Contact newContact = new Contact (Request.Form["new-contact"],
            Request.Form["new-contact-phonenumber"],
            Request.Form["new-address"]);

          newContact.Save();
          return View(newContact);
        }
    }
}
