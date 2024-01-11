using EmsApi.ILogic;
using EmsApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectsController : ControllerBase
    {
        private readonly ISubjectLogic logic;

        public SubjectsController(ISubjectLogic logic)
        {
            this.logic = logic;
        }


        [HttpGet]
        public List<Subject> GetSubjects()
        {
            return logic.GetSubjects();
        }

        [HttpPost]

        public bool InsertSubject(Subject subject)
        {
            return logic.InsertSubject(subject);
        }

        [HttpPut]
        public bool UpdateSubject(Subject subject)
        {
            return logic.UpdateSubject(subject);
        }

        [HttpDelete]
        public bool DeleteSubject(int id)
        {
            return logic.DeleteSubject(id);
        }






    }
}
