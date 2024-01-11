using EmsApi.ILogic;
using EmsApi.IRepository;
using EmsApi.Models;

namespace EmsApi.Logic
{
    public class InstructorLogic : IInstructorLogic
    {
        private readonly IInstructorRepository repo;

        public InstructorLogic(IInstructorRepository repo)
        {
            this.repo = repo;
        }

        public bool DeleteInstructor(int id)
        {
            return repo.DeleteInstructor(id);
        }

        public Instructor GetInstructorById(int id)
        {
            return repo.GetInstructorById(id);
        }

        public List<Instructor> GetInstructors()
        {
            return repo.GetInstructors();
        }

        public bool InsertInstructor(Instructor instructor)
        {
            return repo.InsertInstructor(instructor);
        }

        public bool UpdateInstructor(Instructor instructor)
        {
            return repo.UpdateInstructor(instructor);
        }
    }
}
