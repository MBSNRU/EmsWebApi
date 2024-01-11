using EmsApi.Models;

namespace EmsApi.IRepository
{
    public interface IStudentRepository
    {
        List<Student> GetStudents();
        Student GetStudentByName(string name);
        bool InsertStudent(Student student);
        bool UpdateStudent(Student student);
        bool DeleteStudent(int id);
    }
}
