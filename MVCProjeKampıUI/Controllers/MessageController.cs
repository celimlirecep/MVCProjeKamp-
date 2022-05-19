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
    public class MessageController : Controller
    {
        MessageManager cm = new MessageManager(new EFMessageDAL());

        public IActionResult Inbox()
        {
           
            return View(cm.GetListInbox());
        }
        public IActionResult SendBox()
        {
            return View(cm.GetListSendbox());
        }

        public IActionResult NewMessage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NewMessage(Message p)
        {
            return View();
        }
    }
}
