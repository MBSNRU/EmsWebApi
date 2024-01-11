using EmsApi.ILogic;
using EmsApi.IRepository;
using EmsApi.Models;

namespace EmsApi.Logic
{
    public class OtherDepartmentLogic : IOtherDepartmentLogic
    {
        private readonly IOtherDepartmentRepository repo;

        public OtherDepartmentLogic(IOtherDepartmentRepository repo)
        {
            this.repo = repo;
        }

        public bool DeleteOtherDepartment(int id)
        {
            return repo.DeleteOtherDepartment(id);
        }

        public List<OtherDepartment> GetOtherDepartments()
        {
           return repo.GetOtherDepartments();
        }

        public bool InsertOtherDepartment(OtherDepartment otherDepartment)
        {
            return repo.InsertOtherDepartment(otherDepartment);
        }

        public bool UpdateOtherDepartment(OtherDepartment otherDepartment)
        {
            return repo.UpdateOtherDepartment(otherDepartment);
        }
    }
}
