using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProjeKampıUI.Controllers
{
    public class HeadingController : Controller
    {
        HeadingManager hm = new HeadingManager(new EFHeadingDAL());
        HeadingValidator validationRules = new HeadingValidator();
        CategoryManager cm = new CategoryManager(new EFCategoryDAL());
        WriterManager wm = new WriterManager(new EFWriterDAL());

        public IActionResult Index()
        {

      
            return View(hm.GetHeadingCombineWriterAndCategory());
        }
        public IActionResult AddHeading()
        {
            
            ViewBag.Writer = new SelectList(wm.GetList(), "WriterId", "WriterFullName");
            ViewBag.Category = new SelectList(cm.GetList(), "CategoryId", "CategoryName");




            return View();
        }


        [HttpPost]
        public IActionResult AddHeading(Heading heading)
        {

            ValidationResult validationResult = validationRules.Validate(heading);
            if (validationResult.IsValid)
            {
                heading.HeadingDate =DateTime.Parse(DateTime.Now.ToShortDateString());
                hm.HeadingAddBL(heading);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var error in validationResult.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
            }
            return View(heading);

        }

        public IActionResult EditHeading(int id)
        {

            return View(hm.GetById(id));
        }
        [HttpPost]
        public IActionResult EditHeading(Heading heading)
        {

            ValidationResult result = validationRules.Validate(heading);
            if (result.IsValid)
            {
                hm.HeadingUpdate(heading);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();

        }

        public IActionResult ContentByHeading()
        {

            return View();
        }

    }
}
