using EmsApi.IRepository;
using EmsApi.Models;

namespace EmsApi.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly EmsContext dbContext;

        public CourseRepository(EmsContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public bool DeleteCourse(int id)
        {
            var cou = dbContext.Courses.Where(x=>x.Id == id).FirstOrDefault();
            dbContext.Courses.Remove(cou);
            dbContext.SaveChanges();
            return true;
        }

        public List<Course> GetCourses()
        {
            return dbContext.Courses.ToList();
        }

        public bool InsertCourse(Course course)
        {
            dbContext.Courses.Add(course);
            dbContext.SaveChanges();
            return true;
        }

        public bool UpdateCourse(Course course)
        {
            var cou = dbContext.Courses.Where(x=>x.Id==course.Id).FirstOrDefault();
            cou.Name=course.Name;
            cou.Code=course.Code;
            cou.Description=course.Description;
            dbContext.SaveChanges();
            return true;
        }
    }
}
