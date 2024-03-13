using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Student
    {
        // Primary Key
        [Key]
        public int StudentId { get; set; }

        [MaxLength(100)]
        public string StudentFirstName { get; set; }

        [MaxLength(50)]
        public string StudentLastName { get; set; }

        [MaxLength(100)]
        public string StudentEmail { get; set; }

        // One Student can enroll into many courses 
        // This is called Navigation Property in Entity Framework
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
