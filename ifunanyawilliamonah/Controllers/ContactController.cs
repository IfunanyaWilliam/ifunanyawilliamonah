using ifunanyawilliamonah.Models;
using ifunanyawilliamonah.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ifunanyawilliamonah.Controllers
{
    public class ContactController : Controller
    {
        private readonly EmailService _email;


        public ContactController(EmailService email)
        {
            _email = email;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(EmailModel model)
        {
            if (ModelState.IsValid)
            {
                var newEmail = new EmailModel()
                {
                    Receipient = "emekaewelike@gmail.com",
                    Title = model.Title,
                    Body = model.Body
                };
                Console.WriteLine(newEmail.Body);
                Console.WriteLine(newEmail.Title);
                await _email.SendMail(newEmail);

                return RedirectToAction("EmailSent");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> EmailSent()
        {
            return View();
        }
    }
}
