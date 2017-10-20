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

        [Route("/addressbook")]
        public ActionResult AddContact()
        {
          List<Contact> allContact = Contact.GetAll();
          return View(allContact);
        }

        [HttpPost("/addressbook/user")]
        public ActionResult ContactDetails()
        {
          Contact.ClearAll();
          return View();
        }

        [HttpPost("/addressbook/createcontact")]
        public ActionResult ContactCreate()
        {
          Contact newContact = new Contact (
            Request.Form["new-contact"],
            (Request.Form["new-contactPhoneNumber"]),
            (Request.Form["new-address"])
          );
          newContact.Save();
          return View(newContact);
        }
    }
}
