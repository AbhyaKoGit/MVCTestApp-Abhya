﻿using Microsoft.AspNetCore.Mvc;

namespace MVCTestApp.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
