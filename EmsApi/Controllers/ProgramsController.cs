using EmsApi.ILogic;
using EmsApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//when writing Program it is taking the main Program.cs file instead from the models, that's why wrote as below
//Avoid using keyword names for database tables

namespace EmsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgramsController : ControllerBase
    {
        private readonly IProgramLogic logic;

        public ProgramsController(IProgramLogic logic)
        {
            this.logic = logic;
        }


        [HttpGet]
        public List<EmsApi.Models.Program> GetPrograms() 
        {
            return logic.GetPrograms();
        }

        [HttpPost]
        public bool InsertProgram(EmsApi.Models.Program program)
        {
            return logic.InsertProgram(program);
        }

        [HttpPut]
        public bool UpdateProgram(EmsApi.Models.Program program)
        {
            return logic.UpdateProgram(program);
        }

        [HttpDelete]
        public bool DeleteProgram(int id)
        {
            return logic.DeleteProgram(id);
        }





    }
}
