using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ViewModels
{
    public class StudentCourseVM
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public List<string> Courses { get; set; }
        public List<int> CourseIds { get; set; }
        public List<bool> Checked { get; set; }
    }
}
