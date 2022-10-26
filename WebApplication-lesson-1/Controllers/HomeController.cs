using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication_lesson_1.Models;

namespace WebApplication_lesson_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private static string login="";
        private static string password="";

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Reg()
        {
            return View();
        }
        public void RegAction()
        {
            login = Request.Query["login"].ToString();
            password = Request.Query["password"].ToString();
            Response.Redirect("/home/login");
        }
        public IActionResult Login()
        {
            return View();
        }
        public void LoginAction()
        {
            if (login.Equals(Request.Query["login"].ToString()) && password.Equals(Request.Query["password"].ToString()))
            {
                Response.StatusCode = 200;
                Response.WriteAsync("Success");
            }
            else
            {
                Response.StatusCode = 404;
                Response.WriteAsync("Failure");
            }
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAuth()
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