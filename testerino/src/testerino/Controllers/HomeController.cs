using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using testerino.Services;
using testerino.ViewModels;

namespace testerino.Controllers
{
    public class HomeController : Controller
    {
        private IEmailSender _emailSender;

        public HomeController(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModel model)
        {
            _emailSender.SendEmailAsync("n.dabrowski@kunzleigh.com", "blah", "blahblah");

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
