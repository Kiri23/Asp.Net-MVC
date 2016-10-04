using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test1MVC.Models;

namespace Test1MVC.Controllers
{
    public class CustomerController : Controller
    {
        // GET: all Customer
        public ActionResult Index()
        {
            var customer = new Customer()
            {
                Name = "Jhon Smith"
            };
            return View(customer);
        }
    }
}