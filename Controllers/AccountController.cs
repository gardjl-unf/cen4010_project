﻿using Microsoft.AspNetCore.Mvc;

namespace OpenBed.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
