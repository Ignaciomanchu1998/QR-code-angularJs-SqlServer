using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QRCode.Dao;
using QRCode.Dao.Utils;
using QRCode.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace QRCode.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        private StructureResponse _struct = new StructureResponse();
        private UsersDao _u = new UsersDao();
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> UserGetAll()
        {
            _struct = await _u.UsersGetAll();
            return Ok(_struct);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
