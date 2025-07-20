using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using WonderLandAdventures.Models;

namespace WonderLandAdventures.Controllers
{
    public class AdminController : Controller
    {
        private readonly AdminDbContext db = new AdminDbContext();

        // GET: Admin/Login
        public ActionResult Login()
        {
            return View();
        }

        // POST: Admin/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(string adminId, string password)
        {
            var admin = db.Admins.FirstOrDefault(a => a.AdminId == adminId && a.Password == password);

            if (admin != null)
            {
                FormsAuthentication.SetAuthCookie(admin.AdminId, false);
                return RedirectToAction("Dashboard");
            }

            ModelState.AddModelError("", "无效的管理员ID或密码");
            return View();
        }

        [AllowAnonymous]
        public ActionResult Dashboard()
        {
            // 这里应该从数据库获取实际数据
            ViewBag.VisitorsToday = 1250;
            ViewBag.TicketsSold = 843;

            return View();
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}