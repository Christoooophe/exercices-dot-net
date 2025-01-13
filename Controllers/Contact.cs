using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exercices.Controllers
{
    public class Contact : Controller
    {
        //GET
        public IActionResult Index()
        {
            return View();
        }

        //GET
        public IActionResult ContactById()
        {
            return View();
        }

        //POST
        public IActionResult AddContact()
        {
            return View();
        }
    }
}
