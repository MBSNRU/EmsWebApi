using EmsApi.Models;

namespace EmsApi.IRepository
{
    public interface ICourseRepository
    {
        List<Course> GetCourses();
        bool InsertCourse(Course course);
        bool UpdateCourse(Course course);
        bool DeleteCourse(int id);
    }
}
