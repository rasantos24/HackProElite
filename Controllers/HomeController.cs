﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HackProElite.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        // GET: Register
        public ActionResult Register()
        {
            return View();
        
        }

        public ActionResult AdminIndex()
        {
            return View();
        }
    }

    }