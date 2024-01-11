using EmsApi.Models;

namespace EmsApi.ILogic
{
    public interface IOtherDepartmentLogic
    {
        List<OtherDepartment> GetOtherDepartments();
        bool InsertOtherDepartment(OtherDepartment otherDepartment);
        bool UpdateOtherDepartment(OtherDepartment otherDepartment);
        bool DeleteOtherDepartment(int id);
    }
}
