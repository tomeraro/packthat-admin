using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using packthat_admin.Models;
using System.Net.Http;

namespace packthat_admin.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {           
            return View();
        }
    }
}
