using eproject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eproject.Controllers
{

    public class UserController : Controller
    {
        private mycontext _context;
        private IWebHostEnvironment _env;

        public UserController(mycontext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            string user_session = HttpContext.Session.GetString("user_session");
            if (user_session != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("login");
            }
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string userEmail, string userPassword)
        {
            var row = _context.tbl_user.FirstOrDefault(a => a.user_email == userEmail);
            if (row != null && row.user_password == userPassword)
            {
                HttpContext.Session.SetString("user_session", row.user_id.ToString());
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.message = "Incorrect Username or Password";
                return View();
            }


		}


		public IActionResult Logout()
		{
			HttpContext.Session.Remove("user_session");
			return RedirectToAction("Login");
		}
	}
}
