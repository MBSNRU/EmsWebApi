using EmsApi.Models;

namespace EmsApi.IRepository
{
    public interface IInstructorRepository
    {
        List<Instructor> GetInstructors();
        Instructor GetInstructorById(int id);
        bool InsertInstructor(Instructor instructor);
        bool UpdateInstructor(Instructor instructor);
        bool DeleteInstructor(int id);
    }
}
