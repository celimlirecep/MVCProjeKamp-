using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProjeKampıUI.Controllers
{
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EFContactDAL());
        ContactValidator contactValidator = new ContactValidator();
        public IActionResult Index()
        {
          //  ValidationResult result=contactValidator.Validate()
            return View(cm.GetList());
        }
        public IActionResult GetContactDetails(int id)
        {
          
            return View(cm.GetById(id));
        }
    }
}
