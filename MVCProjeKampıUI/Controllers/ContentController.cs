using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProjeKampıUI.Controllers
{
    public class ContentController : Controller
    {
        ContentManager cm = new ContentManager(new EFContentDAL());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ContentByHeading( int id)
        {
            var contentValue = cm.GetListByHeadingId(id);
            return View(contentValue);
        }

    }
}
