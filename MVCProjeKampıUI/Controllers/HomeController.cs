using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCProjeKampıUI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProjeKampıUI.Controllers
{
    public class HomeController : Controller
    {
      

        public IActionResult Index()
        {
            return View();
        }

       

    }
}
