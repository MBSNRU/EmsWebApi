using EmsApi.IRepository;
using EmsApi.Models;

namespace EmsApi.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly EmsContext dbContext;

        public StudentRepository(EmsContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public bool DeleteStudent(int id)
        {
            var stu = dbContext.Students.Where(x=>x.Id == id).FirstOrDefault();
            dbContext.Students.Remove(stu);
            dbContext.SaveChanges();
            return true;
        }

        public Student GetStudentByName(string name)
        {
            return dbContext.Students.Where(x => x.Name == name).FirstOrDefault();
        }

        public List<Student> GetStudents()
        {
            return dbContext.Students.ToList();
        }

        public bool InsertStudent(Student student)
        {
            dbContext.Students.Add(student);
            dbContext.SaveChanges();
            return true;
        }

        public bool UpdateStudent(Student student)
        {
            var stu = dbContext.Students.Where(x=>x.Id==student.Id).FirstOrDefault();
            stu.Name = student.Name;
            stu.Mobile = student.Mobile;
            stu.Email = student.Email;
            stu.Adddress = student.Adddress;
            stu.JoiningYear = student.JoiningYear;
            stu.ProgramId = student.ProgramId;
            stu.CourseId = student.CourseId;
            dbContext.SaveChanges();
            return true;
        }
    }
}
