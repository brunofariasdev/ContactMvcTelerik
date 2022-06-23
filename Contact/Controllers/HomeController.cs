using Contact.Models;
using Contact.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contact.Controllers
{
    public class HomeController : Controller
    {
        private readonly IContactRepository _contactRepository;
        public HomeController(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public IActionResult Index()
        {
            var contacts = _contactRepository.GetAll();
            return View(contacts);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
        public void Delete(ContactModel contact)
        {
            _contactRepository.Delete(contact);
        }

        public void Update(ContactModel contact)
        {
            _contactRepository.Update(contact);
        }

        [HttpPost]
        public void Create(ContactModel contact)
        {
            _contactRepository.Add(contact);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var contacts = _contactRepository.GetAll();
            return Json(contacts);
        }


    }
}
