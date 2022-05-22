using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MVCProjeKampıUI.Controllers
{

    public class LoginController : Controller
    {
    
        AdminManager ma = new AdminManager(new EFAdminDAL());
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Index(Admin admin)
        {
            var adminUserInfo = ma.Get(x => x.AdminUserName == admin.AdminUserName && x.AdminPasword == admin.AdminPasword);
            if (adminUserInfo != null)
            {
                //var claims = new List<Claim>
                //{
                //    new Claim(ClaimTypes.Name,admin.AdminUserName)
                //};
                //var userIdentity = new ClaimsIdentity(claims, "Login");
                //ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                //await HttpContext.SignInAsync(principal);
              
                HttpContext.Session.SetString("username", admin.AdminUserName);
                return RedirectToAction("Index", "AdminCategory");

            }

            return RedirectToAction("Index");


        }
    }
}
