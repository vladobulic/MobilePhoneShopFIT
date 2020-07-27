using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Customer.Controllers
{
    [Authorize]
    [Area("Customer")]
    public class NarudzbaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
