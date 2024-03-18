using BusinessLogicLayer;
using Microsoft.AspNetCore.Mvc;

namespace MVC_Student_Registration.Controllers
{
    public class StudentEnrollmentController : Controller
    {
        StudentEnrollmentService studentEnrollmentService = new StudentEnrollmentService();

        public IActionResult Index()
        {

            var response = studentEnrollmentService.GetStudentCourseForEnrollment();
            return View(response);
        }

        [HttpPost]
        public IActionResult UpdateStudentEnrollments([FromBody] Dictionary<int, List<int>> studentEnrollments)
        {
            var response = studentEnrollmentService.UpdateEnrollment(studentEnrollments);
            return View(response);
        }

    }
}
