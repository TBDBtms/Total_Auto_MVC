﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Total_Auto_MVC.Controllers
{
    public class JcyHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ShowCard(int id=0)
        {
            ViewBag.id = id;
            return View();
        }
    }
}
