using Entities.Context;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CourseRepository
    {
        StudentEnrollmentContext studentEnrollmentContext = new StudentEnrollmentContext();

        public string RegisterCourseRepository(Course courseFormDataObject)
        {
            if (courseFormDataObject != null)
            {
                studentEnrollmentContext.Courses.Add(courseFormDataObject);
                studentEnrollmentContext.SaveChanges();
                return "success";
            }
            else
            {
                return "error";
            }
        }
    }
}
