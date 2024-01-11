using EmsApi.IRepository;
using EmsApi.Models;

namespace EmsApi.Repository
{
    public class InstructorRepository : IInstructorRepository
    {
        private readonly EmsContext dbContext;

        public InstructorRepository(EmsContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public bool DeleteInstructor(int id)
        {
            var ins = dbContext.Instructors.Where(x=>x.Id == id).FirstOrDefault();
            dbContext.Instructors.Remove(ins);
            dbContext.SaveChanges();
            return true;
        }

        public Instructor GetInstructorById(int id)
        {
            return dbContext.Instructors.Where(x => x.Id == id).FirstOrDefault();
        }

        public List<Instructor> GetInstructors()
        {
            return dbContext.Instructors.ToList();
        }

        public bool InsertInstructor(Instructor instructor)
        {
            dbContext.Instructors.Add(instructor);
            dbContext.SaveChanges();
            return true;
        }

        public bool UpdateInstructor(Instructor instructor)
        {
            var ins = dbContext.Instructors.Where(x=>x.Id == instructor.Id).FirstOrDefault();
            ins.Name = instructor.Name;
            ins.Mobile = instructor.Mobile;
            ins.Email = instructor.Email;
            ins.Adddress = instructor.Adddress;
            ins.Salary = instructor.Salary;
            ins.Specialization = instructor.Specialization;
            ins.CourseId = instructor.CourseId;
            dbContext.SaveChanges();
            return true;
        }
    }
}
