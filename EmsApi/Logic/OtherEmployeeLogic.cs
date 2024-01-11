using EmsApi.ILogic;
using EmsApi.IRepository;
using EmsApi.Models;

namespace EmsApi.Logic
{
    public class OtherEmployeeLogic : IOtherEmployeeLogic
    {
        private readonly IOtherEmployeeRepository repo;

        public OtherEmployeeLogic(IOtherEmployeeRepository repo)
        {
            this.repo = repo;
        }

        public bool DeleteOtherEmployee(int id)
        {
            return repo.DeleteOtherEmployee(id);
        }

        public List<OtherEmployee> GetOtherEmployees()
        {
            return repo.GetOtherEmployees();
        }

        public bool InsertOtherEmployee(OtherEmployee employee)
        {
            return repo.InsertOtherEmployee(employee);
        }

        public bool UpdateOtherEmployee(OtherEmployee employee)
        {
            return repo.UpdateOtherEmployee(employee);
        }
    }
}
