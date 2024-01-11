using EmsApi.ILogic;
using EmsApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentLogic logic;

        public StudentsController(IStudentLogic logic)
        {
            this.logic = logic;
        }


        [HttpGet]
        public List<Student> GetStudents()
        {
            return logic.GetStudents();
        }

        [HttpGet]
        [Route("{name}")]
        public IActionResult GetStudentByName([FromRoute] string name)
        {
            var result = logic.GetStudentByName(name);
            if(result == null) { return NotFound(); }
            return Ok(result);

        }


        [HttpPost]
        public bool InsertStudent(Student student)
        {
            return logic.InsertStudent(student);
        }

        [HttpPut]
        public bool UpdateStudent(Student student)
        {
            return logic.UpdateStudent(student);
        }

        [HttpDelete]
        public bool DeleteStudent(int id)
        {
            return logic.DeleteStudent(id);
        }






    }
}
