using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProjeKampıUI.Controllers
{
    public class ErrorPageController : Controller
    {

        //Sayfa Bulunamadı
        public IActionResult Errors400_404()
        {
            Response.StatusCode = 404;
            
            return View();
        }
        //Erişim İzni Yok
        public IActionResult Errors403()
        {
            Response.StatusCode = 403;

            return View();
        }
        //Sunucu Hatası
        public IActionResult Errors500()
        {
            Response.StatusCode = 500;

            return View();
        }
    }
}
