using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proj3_Aftaabuddin.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Proj3_Aftaabuddin.Controllers
{
    public class HomeController : Controller
    {
        private RegistrationContext _context;
        public HomeController(RegistrationContext registrationContext)
        {
            _context = registrationContext;

        }

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Submit(RegisteredUser registeredUser)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    registeredUser.RegistrationDate = DateTime.Now;
                    _context.Add(registeredUser);
                    _context.SaveChanges();
                }
                catch (Exception e)
                {
                    return View("Error");
                }

                RegistrationViewModel vm = new RegistrationViewModel();
                vm.UserInfo = registeredUser;
                vm.ClientInfo = Request.Headers["User-Agent"].ToString();
                return View(vm);
            }
            else
            {
                return View("Error");
            }
        }


        public ActionResult Privacy()
        {
            return View();
        }
        public ActionResult Registrations(string filter)
        {
            ViewBag.Filter = filter;
            List<RegisteredUser> registrations;
            if (string.IsNullOrEmpty(filter))
            {
                registrations = _context.Registrations.ToList();
            }
            else
            {
                registrations = (from r in _context.Registrations
                                 where r.Name.Contains(filter)
                                 select r).ToList();
            }
            return View(registrations);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public ActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
