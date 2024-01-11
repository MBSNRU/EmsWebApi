using EmsApi.Models;

namespace EmsApi.ILogic
{
    public interface IOtherEmployeeLogic
    {
        List<OtherEmployee> GetOtherEmployees();
        bool InsertOtherEmployee(OtherEmployee employee);
        bool UpdateOtherEmployee(OtherEmployee employee);
        bool DeleteOtherEmployee(int id);
    }
}
