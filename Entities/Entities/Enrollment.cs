using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Enrollment
    {
        [Key]
        public int EnrollmentId { get; set; }
        public DateTime EnrollmentDate { get; set; }

        // Foreign Key
        [ForeignKey("Student")]
        public int StudentId { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }

        // Lazy Loading
        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
    }
}
