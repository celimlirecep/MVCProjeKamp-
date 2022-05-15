using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProjeKampıUI.Controllers
{
    public class WriterController : Controller
    {
        WriterManager wm = new WriterManager( new EFWriterDAL());
        WritterValidator validationRules = new WritterValidator();
        public IActionResult Index()
        {
            return View( wm.GetList());
        }

        public IActionResult AddWriter()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddWriter(Writer writter)
        {
       
            ValidationResult validationResult = validationRules.Validate(writter);
            if (validationResult.IsValid)
            {
                wm.WriterAdd(writter);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var error in validationResult.Errors)
                {
                    ModelState.AddModelError(error.PropertyName,error.ErrorMessage);
                }
            }
            return View(writter);
         
        }

        public  IActionResult EditWritter(int id)
        {
          
            return View(wm.GetById(id));
        }
        [HttpPost]
        public IActionResult EditWritter(Writer writer)
        {
           
            ValidationResult result = validationRules.Validate(writer);
            if (result.IsValid)
            {
                wm.WriterUpdate(writer);
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

    }
}
