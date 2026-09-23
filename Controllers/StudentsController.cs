using System.Web.Mvc;
using MiniProjectMVC.Models;

namespace MiniProjectMVC.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult Index()
        {
            var students = StudentRepository.GetAll();
            return View(students);
        }

        // GET: Students/Details/5
        public ActionResult Details(int id)
        {
            var student = StudentRepository.GetById(id);
            if (student == null)
            {
                return HttpNotFound("No student found with that id.");
            }
            return View(student);
        }

        // GET: Students/Create
        public ActionResult Create()
        {
            var model = new Student { EnrollmentDate = System.DateTime.Today };
            return View(model);
        }

        // POST: Students/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                StudentRepository.Add(student);
                TempData["Message"] = "Student added successfully.";
                return RedirectToAction("Index");
            }
            return View(student);
        }

        // GET: Students/Edit/5
        public ActionResult Edit(int id)
        {
            var student = StudentRepository.GetById(id);
            if (student == null)
            {
                return HttpNotFound("No student found with that id.");
            }
            return View(student);
        }

        // POST: Students/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                StudentRepository.Update(student);
                TempData["Message"] = "Student updated successfully.";
                return RedirectToAction("Details", new { id = student.Id });
            }
            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            StudentRepository.Delete(id);
            TempData["Message"] = "Student removed.";
            return RedirectToAction("Index");
        }
    }
}
