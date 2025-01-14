using Exercices.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exercices.Controllers
{
    public class ContactController : Controller
    {
        //GET
        public IActionResult Index()
        {
            var contact = new Contact
            {
                Id = 1,
                Name = "Austin",
                Firstname = "Steve"
            };
            ViewData["data"] = "Je suis une liste de contacts";

            return View(contact);
        }

        //GET
        public IActionResult ContactById(int id)
        {
            var contact = new Contact 
            {
                Id = 1,
                Name = "Austin",
                Firstname = "Steve"
            };
            ViewBag.Data = "Je suis un contact unique";
            return View(contact);
        }

        //POST
        public IActionResult AddContact()
        {
            return View();
        }
    }
}
