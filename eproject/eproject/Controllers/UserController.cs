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


		public IActionResult userRegistration()
		{
			return View();
		}

		[HttpPost]
		public IActionResult userRegistration(user user)
		{
			_context.tbl_user.Add(user);
			_context.SaveChanges();
			return RedirectToAction("Login");
		}

		

		public IActionResult Profile()
		{
			var user = HttpContext.Session.GetString("user_session");
			if (user != null)
			{ 
				var row = _context.tbl_user.Where(u => u.user_id == int.Parse(user)).ToList();
				return View(row);
				
			}
			else
			{
				return RedirectToAction("Login");
			}
		}
		public IActionResult updateProfile(int id)
		{
			var user = HttpContext.Session.GetString("user_session");
			if (user != null)
			{
				var userid = _context.tbl_user.Find(id);


				return View(userid);

			}
			else
			{
				return RedirectToAction("Login");
			}


		}

		[HttpPost]
		public IActionResult updateProfile(user user)
		{
			_context.tbl_user.Update(user);
			_context.SaveChanges();
			return RedirectToAction("userprofile");
		}
		public IActionResult changeprofileimage(user user, IFormFile user_image)
		{
			string ImagePath = Path.Combine(_env.WebRootPath, "user_image", user_image.FileName);
			FileStream fs = new FileStream(ImagePath, FileMode.Create);
			user_image.CopyTo(fs);
			user.user_image = user_image.FileName;
			_context.tbl_user.Update(user);
			_context.SaveChanges();
			return RedirectToAction("Profile");
		}
	}
}
