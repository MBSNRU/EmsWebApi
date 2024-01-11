using EmsApi.ILogic;
using EmsApi.IRepository;
using EmsApi.Models;

namespace EmsApi.Logic
{
    public class StudentLogic : IStudentLogic
    {
        private readonly IStudentRepository repo;

        public StudentLogic(IStudentRepository repo)
        {
            this.repo = repo;
        }

        public bool DeleteStudent(int id)
        {
            return repo.DeleteStudent(id);
        }

        public Student GetStudentByName(string name)
        {
           return repo.GetStudentByName(name);
        }

        public List<Student> GetStudents()
        {
            return repo.GetStudents();
        }

        public bool InsertStudent(Student student)
        {
           return repo.InsertStudent(student);
        }

        public bool UpdateStudent(Student student)
        {
            return repo.UpdateStudent(student);
        }
    }
}
