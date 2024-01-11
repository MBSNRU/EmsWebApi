using EmsApi.ILogic;
using EmsApi.IRepository;
using EmsApi.Models;

namespace EmsApi.Logic
{
    public class CourseLogic : ICourseLogic
    {
        private readonly ICourseRepository repo;

        public CourseLogic(ICourseRepository repo)
        {
            this.repo = repo;
        }

        public bool DeleteCourse(int id)
        {
            return repo.DeleteCourse(id);
        }

        public List<Course> GetCourses()
        {
            return repo.GetCourses();
        }

        public bool InsertCourse(Course course)
        {
            return repo.InsertCourse(course);
        }

        public bool UpdateCourse(Course course)
        {
            return repo.UpdateCourse(course);
        }
    }
}
