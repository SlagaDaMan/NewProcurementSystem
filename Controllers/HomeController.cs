using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProcurementSystem.Helpers;
using ProcurementSystem.Models;

namespace ProcurementSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult Login(string Email,string Password)
        {
            UsersQueries Test = new UsersQueries();
            DataTable dt = new DataTable();
            dt = Test.ExecuteQueryFunction("Select * from User Where EmailAddress = '" + Email + "' AND Password = '" + Password + "'");
            var ID = "";



            if (dt.Rows.Count > 0)
            {

                ID = dt.Rows[0][0].ToString();
                //var IDe = Request.Cookies["ID"].ToString();

                CookieOptions cookies = new CookieOptions();
                cookies.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Append("ID", ID, cookies);
                return RedirectToAction("Index", "DashBoard");
            }
            else
            {
                return RedirectToAction("Index");
            }

        }





        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
