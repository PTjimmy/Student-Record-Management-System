using System.Web.Mvc;
using MiniProjectMVC.Models;

namespace MiniProjectMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Title = "Home";
            ViewBag.StudentCount = StudentRepository.GetAll().Count;
            return View();
        }

        // GET: Home/About
        public ActionResult About()
        {
            ViewBag.Title = "About Us";
            return View();
        }

        // GET: Home/Contact
        public ActionResult Contact()
        {
            ViewBag.Title = "Contact Us";
            return View(new ContactModel());
        }

        // POST: Home/Contact
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Contact(ContactModel model)
        {
            ViewBag.Title = "Contact Us";

            if (ModelState.IsValid)
            {
                // In a real app you'd email/save this. Here we just confirm receipt.
                ViewBag.Success = true;
                ModelState.Clear();
                return View(new ContactModel());
            }

            return View(model);
        }
    }
}
