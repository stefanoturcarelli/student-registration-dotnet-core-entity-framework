using BusinessLogicLayer;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MVC_Student_Registration.Controllers
{
    public class StudentController : Controller
    {
        // Instantiate the StudentService class
        StudentService studentService = new StudentService();

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterStudentController([FromBody] Student studentFormDataObject)
        {
            var response = studentService.RegisterStudentService(studentFormDataObject);
            return Json(response);
        }
    }
}
