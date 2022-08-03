using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InputMask.Controllers
{
    public class DevExpressController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult DevExpressControlIndex()
        {
            return View();
        }
    }
}
