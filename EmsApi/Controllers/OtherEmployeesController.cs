using EmsApi.ILogic;
using EmsApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OtherEmployeesController : ControllerBase
    {
        private readonly IOtherEmployeeLogic logic;

        public OtherEmployeesController(IOtherEmployeeLogic logic)
        {
            this.logic = logic;
        }


        [HttpGet]
        public List<OtherEmployee> GetOtherEmployees() 
        {
            return logic.GetOtherEmployees();
        }

        [HttpPost]
        public bool InsertOtherEmployee(OtherEmployee employee)
        {
            return logic.InsertOtherEmployee(employee);
        }

        [HttpPut]
        public bool UpdateOtherEmployee(OtherEmployee employee)
        {
            return logic.UpdateOtherEmployee(employee);
        }

        [HttpDelete]
        public bool DeleteOtherEmployee(int id)
        {
            return logic.DeleteOtherEmployee(id);
        }






    }
}
