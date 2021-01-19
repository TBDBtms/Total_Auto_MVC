using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Total_Auto_MVC.Models;

namespace Total_Auto_MVC.Controllers
{
    public class DLH_TXController : Controller
    {
        UserLogin users = new UserLogin();
        public IActionResult Login()
        { 
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    
    }
}
