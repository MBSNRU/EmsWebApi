using EmsApi.Models;

namespace EmsApi.ILogic
{
    public interface IInstructorLogic
    {
        List<Instructor> GetInstructors();
        Instructor GetInstructorById(int id);
        bool InsertInstructor(Instructor instructor);
        bool UpdateInstructor(Instructor instructor);
        bool DeleteInstructor(int id);
    }
}
