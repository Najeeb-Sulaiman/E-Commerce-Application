﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo.Controllers
{
    public class ContactController : Controller
    {
        // GET : /<Controller>/
        public ViewResult Index()
        {
            return View();
        }
    }
}

