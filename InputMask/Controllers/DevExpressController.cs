using InputMask.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InputMask.Controllers
{
    public class DevExpressController : Controller
    {
        private readonly Context db;
        public DevExpressController(Context context)
        {
            db = context;
        }
        public IActionResult Index() => View();
        [HttpGet]
        public IActionResult DevExpressControlIndex() => View();
        [HttpPost]
        public IActionResult DevExpressControlIndex(LamiData lamiData)
        {
            db.Datas.Add(lamiData);
            db.SaveChanges();
            return View();
        }
    }
}
