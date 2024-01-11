using EmsApi.Models;

namespace EmsApi.IRepository
{
    public interface IOtherDepartmentRepository
    {
        List<OtherDepartment> GetOtherDepartments();
        bool InsertOtherDepartment(OtherDepartment otherDepartment);
        bool UpdateOtherDepartment(OtherDepartment otherDepartment);
        bool DeleteOtherDepartment(int id);
    }
}
