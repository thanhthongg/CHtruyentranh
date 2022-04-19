using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;

namespace CHtruyentranh.Controllers
{
    public class FirstController : Controller
    {
        public IActionResult Welcome(string HovaTen, int Tuoi = 1)
        {
            ViewData["Greeting"] = "Xin chao, toi la " + HovaTen + ". Tuoi cua toi la " + Tuoi.ToString() + ".";
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
