using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProjeKampıUI.Controllers
{
    public class GaleryController : Controller
    {
        ImageFileManager ifm = new ImageFileManager(new EFImageFileDAL());

        private static IImageFileDAL EFImageFileDAL()
        {
            throw new NotImplementedException();
        }

        public IActionResult Index()
        {
            
            return View(ifm.GetList());
        }
    }
}
