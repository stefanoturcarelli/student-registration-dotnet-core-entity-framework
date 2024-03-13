using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [MaxLength(100)]
        public string CourseName { get; set; }
        public DateTime CourseStartDate { get; set; }
        public DateTime CourseEndDate { get; set; }

        // One Course can have many students
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
