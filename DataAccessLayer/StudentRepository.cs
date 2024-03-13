using Entities.Context;
using Entities.Entities;

namespace DataAccessLayer
{
    public class StudentRepository
    {
        StudentEnrollmentContext studentEnrollmentContext = new StudentEnrollmentContext();

        public string RegisterStudentRepository(Student studentFormDataObject)
        {
            if (studentFormDataObject != null)
            {
                studentEnrollmentContext.Students.Add(studentFormDataObject);
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
