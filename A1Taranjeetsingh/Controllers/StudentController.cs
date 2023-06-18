using A1Taranjeetsingh.Models;
using Microsoft.AspNetCore.Mvc;

namespace A1Taranjeetsingh.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Details()
        {
            var student = new Student
            {
                StudentId = 200532470,
                FirstName = "Taranjeet",
                Lastname = "Singh"
            };

            var courses = new List<Course>
    {
        new Course { CourseId = 1, CourseName = "Python" },
        new Course { CourseId = 2, CourseName = "Java" },
        new Course { CourseId = 3, CourseName = "Linux" }
    };

            var viewModel = new StudentVM
            {
                Member = student,
                Courses = courses
            };

            return View(viewModel);
        }

    }
}
