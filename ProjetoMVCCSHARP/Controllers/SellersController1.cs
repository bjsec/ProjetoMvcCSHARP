﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMVCCSHARP.Controllers
{
    public class SellersController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
