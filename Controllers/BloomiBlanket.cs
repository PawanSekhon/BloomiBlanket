 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BloomiBlanket.Controllers
{
    public class BloomiBlanket : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
