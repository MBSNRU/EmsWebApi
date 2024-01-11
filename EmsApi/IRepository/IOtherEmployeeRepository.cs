using EmsApi.Models;

namespace EmsApi.IRepository
{
    public interface IOtherEmployeeRepository
    {
        List<OtherEmployee> GetOtherEmployees();
        bool InsertOtherEmployee(OtherEmployee employee);
        bool UpdateOtherEmployee(OtherEmployee employee);
        bool DeleteOtherEmployee(int id);
    }
}
