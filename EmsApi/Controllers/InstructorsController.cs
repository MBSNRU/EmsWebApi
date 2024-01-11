using EmsApi.ILogic;
using EmsApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorsController : ControllerBase
    {
        private readonly IInstructorLogic logic;

        public InstructorsController(IInstructorLogic logic)
        {
            this.logic = logic;
        }


        [HttpGet]
        public List<Instructor> GetInstructors()
        {
            return logic.GetInstructors();
        }


        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetInstructorById([FromRoute] int id)
        {
            var result = logic.GetInstructorById(id);
            if (result == null) { return NotFound(); }
            return Ok(result);
        }


        [HttpPost]
        public bool InsertInstructor(Instructor instructor)
        {
            return logic.InsertInstructor(instructor);
        }

        [HttpPut]
        public bool UpdateInstructor(Instructor instructor)
        {
            return logic.UpdateInstructor(instructor);
        }

        [HttpDelete]
        public bool DeleteInstructor(int id)
        {
            return logic.DeleteInstructor(id);
        }


    }
}
