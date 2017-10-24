using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;

namespace AddressBook.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            List<Contact> allContacts = Contact.GetAll();
            return View(allContacts);
        }

        // [Route("/contact/{id}")]
        // public ActionResult ContactDetails(int id)
        // {
        //   Contact contact = Contact.Find(id);
        //   return View(Contact);

        [HttpPost("/contact/new")]
        public ActionResult ContactDetails()
        {
          Contact newContact = new Contact (
            Request.Form["new-contact"],
            (Request.Form["new-contactPhoneNumber"]),
            (Request.Form["new-address"])
          );
          return View(newContact);
        }

        [HttpPost("/contact/ClearContacts")]
        public ActionResult ClearContacts()
        {
          Contact.ClearAll();
          return View();
        }

        // [HttpPost("/contact/new")]
        // public ActionResult AddContacts()
        // {
        //   Contact newContact = new Contact (
        //     Request.Form["new-contact"],
        //     (Request.Form["new-contactPhoneNumber"]),
        //     (Request.Form["new-address"])
        //   );
        //   newContact.Save();
        //   return View(newContact);
        //}
    }
}
