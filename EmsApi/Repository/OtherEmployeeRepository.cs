using EmsApi.IRepository;
using EmsApi.Models;

namespace EmsApi.Repository
{
    public class OtherEmployeeRepository : IOtherEmployeeRepository
    {
        private readonly EmsContext dbContext;

        public OtherEmployeeRepository(EmsContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public bool DeleteOtherEmployee(int id)
        {
            var oe = dbContext.OtherEmployees.Where(x=>x.Id == id).FirstOrDefault();
            dbContext.OtherEmployees.Remove(oe);
            dbContext.SaveChanges();
            return true;
        }

        public List<OtherEmployee> GetOtherEmployees()
        {
            return dbContext.OtherEmployees.ToList();
        }

        public bool InsertOtherEmployee(OtherEmployee employee)
        {
            dbContext.OtherEmployees.Add(employee);
            dbContext.SaveChanges();
            return true;
        }

        public bool UpdateOtherEmployee(OtherEmployee employee)
        {
            var oe = dbContext.OtherEmployees.Where(x=>x.Id==employee.Id).FirstOrDefault();
            oe.Name = employee.Name;
            oe.Mobile = employee.Mobile;
            oe.Email = employee.Email;
            oe.Adddress = employee.Adddress;
            oe.Salary = employee.Salary;
            oe.DepartmentId = employee.DepartmentId;
            dbContext.SaveChanges();
            return true;
        }
    }
}
