using EmsApi.ILogic;
using EmsApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OtherDepartmentsController : ControllerBase
    {
        private readonly IOtherDepartmentLogic logic;

        public OtherDepartmentsController(IOtherDepartmentLogic logic)
        {
            this.logic = logic;
        }


        [HttpGet]
        public List<OtherDepartment> GetOtherDepartments()
        {
            return logic.GetOtherDepartments();
        }

        [HttpPost]
        public bool InsertOtherDepartment(OtherDepartment otherDepartment)
        {
            return logic.InsertOtherDepartment(otherDepartment);
        }

        [HttpPut]
        public bool UpdateOtherDepartment(OtherDepartment otherDepartment)
        {
            return logic.UpdateOtherDepartment(otherDepartment);
        }

        [HttpDelete]
        public bool DeleteOtherDepartment(int id) 
        {
            return logic.DeleteOtherDepartment(id);
        }






    }
}
