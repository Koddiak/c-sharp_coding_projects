using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Knockout.Models;
using Newtonsoft.Json;

namespace Knockout.Controllers
{
    public class HomeController : Controller
    {
        private WebmailContext Context { get; }

        public HomeController(WebmailContext _context)
        {
            this.Context = _context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Email()
        {
            List<Email> emails = (from email in this.Context.Email
                                  select email).ToList();
            return Json(JsonConvert.SerializeObject(emails));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
