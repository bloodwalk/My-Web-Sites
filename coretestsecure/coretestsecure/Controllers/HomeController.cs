using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using coretestsecure.Models;
using Microsoft.AspNetCore.Identity;


namespace coretestsecure.Controllers
{
    public class HomeController : Controller
    {
        private UserManager<pluralsightuser> usermanager;

        public HomeController(UserManager<pluralsightuser> usermanager)
        {
            this.usermanager = usermanager;
        }




        public IActionResult Index()
        {

            


            return View();
        }

        public IActionResult About()
        {
           // var someperson = new pluralsightuser() {ID="4" ,UserName = "tak"};

            //var resultaat = await usermanager.CreateAsync(someperson);

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
