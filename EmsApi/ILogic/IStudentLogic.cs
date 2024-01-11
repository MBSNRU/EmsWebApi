using EmsApi.Models;

namespace EmsApi.ILogic
{
    public interface IStudentLogic
    {
        List<Student> GetStudents();
        Student GetStudentByName(string name);
        bool InsertStudent(Student student);
        bool UpdateStudent(Student student);
        bool DeleteStudent(int id);
    }
}
