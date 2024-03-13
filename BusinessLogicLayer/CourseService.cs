using DataAccessLayer;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class CourseService
    {
        // Instantiate the CourseRepository class
        CourseRepository courseRepository = new CourseRepository();

        // Method to register a course
        public string RegisterCourseService(Course courseFormDataObject)
        {
            return courseRepository.RegisterCourseRepository(courseFormDataObject);
        }
    }
}
