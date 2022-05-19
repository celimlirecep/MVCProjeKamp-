using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProjeKampıUI.Controllers
{
    public class AboutController : Controller
    {
        AboutManager abm = new AboutManager( new EFAboutDAL());
        public IActionResult Index()
        {
            return View(abm.GetList());
        }
        public IActionResult AddAbout(About p)
        {
            abm.AboutAddBL(p);
            return RedirectToAction("Index");
        }
       
    }
}
