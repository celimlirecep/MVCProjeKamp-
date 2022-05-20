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
    public class MessageController : Controller
    {
        MessageManager cm = new MessageManager(new EFMessageDAL());
        MessageValidator validationRules = new MessageValidator();
        public IActionResult Inbox()
        {
           
            return View(cm.GetListInbox());
        }
        public IActionResult SendBox()
        {
            return View(cm.GetListSendbox());
        }
        public IActionResult GetInboxMessageDetails(int id)
        {

            return View(cm.GetById(id));
        }
        public IActionResult GetSendboxMessageDetails(int id)
        {

            return View(cm.GetById(id));
        }

        public IActionResult NewMessage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NewMessage(Message p)
        {
            ValidationResult result = validationRules.Validate(p);
            if (result.IsValid)
            {
                p.SenderMail = "admin@gmail.com";
                p.MessageDate =DateTime.Parse( DateTime.Now.ToShortDateString());
                cm.MessageAddBL(p);
                return RedirectToAction("SendBox");

            }
            foreach (var item in result.Errors)
            {
                ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            }

            return View();
        }
    }
}
