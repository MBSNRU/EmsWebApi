using EmsApi.ILogic;
using EmsApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseLogic logic;

        public CoursesController(ICourseLogic logic)
        {
            this.logic = logic;
        }


        [HttpGet]
        public List<Course> GetCourses()
        {
            return logic.GetCourses();
        }

        [HttpPost]
        public bool InsertCourse(Course course)
        {
            return logic.InsertCourse(course);
        }

        [HttpPut]
        public bool UpdateCourse(Course course)
        {
            return logic.UpdateCourse(course);
        }

        [HttpDelete]
        public bool DeleteCourse(int id) 
        {
            return logic.DeleteCourse(id);
        }






    }
}
