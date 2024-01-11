using EmsApi.Models;

namespace EmsApi.ILogic
{
    public interface ICourseLogic
    {
        List<Course> GetCourses();
        bool InsertCourse(Course course);
        bool UpdateCourse(Course course);
        bool DeleteCourse(int id);
    }
}
