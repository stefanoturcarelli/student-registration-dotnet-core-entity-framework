using DataAccessLayer;
using Entities.Entities;

namespace BusinessLogicLayer
{
    public class StudentService
    {
        StudentRepository studentRepository = new StudentRepository();

        public string RegisterStudentService(Student studentFormDataObject)
        {
            return studentRepository.RegisterStudentRepository(studentFormDataObject);
        }
    }
}
