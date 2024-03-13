using BusinessLogicLayer;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MVC_Student_Registration.Controllers
{
    public class CourseController : Controller
    {
        // Instantiate the CourseService class
        CourseService courseService = new CourseService();

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterCourseController([FromBody] Course courseFormDataObject)
        {
            var response = courseService.RegisterCourseService(courseFormDataObject);
            return Json(response);
        }
    }
}
