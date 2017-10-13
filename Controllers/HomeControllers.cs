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

        [Route("/addresbBook")]
        public ActionResult Cars()
        {
          List<Car> allCars = Car.GetAll();
          return View(allCars);
        }

        [HttpPost("/addressbook/user")]
        public ActionResult CarsUser()
        {
          Car.ClearAll();
          return View();
        }

        [HttpPost("/addressbook/create")]
        public ActionResult CarsCreate()
        {
          Car newCar = new Car (Request.Form["new-contact"],
            int.Parse(Request.Form["new-car-phonenumber"]),
            int.Parse(Request.Form["new-address"])
          );
          newCar.Save();
          return View(newCar);
        }
    }
}
