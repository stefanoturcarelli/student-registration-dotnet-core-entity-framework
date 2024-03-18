using Entities.Context;
using Entities.Entities;
using Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class StudentEnrollmentRepository
    {
        StudentEnrollmentContext studentEnrollmentContext = new StudentEnrollmentContext();

        public List<StudentCourseVM> GetStudentCoursesForEnrollment()
        {
            List<Student> students = studentEnrollmentContext.Students.ToList();
            List<Course> courses = studentEnrollmentContext.Courses.ToList();
            List<Enrollment> enrollments = studentEnrollmentContext.Enrollments.ToList();

            var studentCourses = students.Select(s => new StudentCourseVM
            {
                StudentId = s.StudentId,
                FirstName = s.StudentFirstName,
                Courses = courses.Select(c => c.CourseName).ToList(),
                CourseIds = courses.Select(c => c.CourseId).ToList(),
                Checked = courses.Select(
                    course => enrollments.Any(enrollment => enrollment.CourseId == course.CourseId
                    && enrollment.StudentId == s.StudentId)).ToList()
            }).ToList();

            return studentCourses;
        }

        public string UpdateEnrollments(Dictionary<int, List<int>> studentEnrollments)
        {
            studentEnrollmentContext.Enrollments.RemoveRange(studentEnrollmentContext.Enrollments.ToList());

            foreach (var studentEnrollment in studentEnrollments)
            {

                // removing all the existing enrollments from the Enrollment table so that,
                // we can insert newly selected enrollment ahead.

                int studentId = studentEnrollment.Key;
                // add newly selected enrollments

                foreach (var courseId in studentEnrollment.Value)
                {
                    var enrollment = new Enrollment
                    {
                        EnrollmentDate = DateTime.Now,
                        CourseId = courseId,
                        StudentId = studentId
                    };
                    studentEnrollmentContext.Enrollments.Add(enrollment);
                }

            }
            studentEnrollmentContext.SaveChanges();

            return "success";
        }

    }
}
