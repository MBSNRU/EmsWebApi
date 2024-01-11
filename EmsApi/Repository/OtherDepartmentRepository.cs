using EmsApi.IRepository;
using EmsApi.Models;

namespace EmsApi.Repository
{
    public class OtherDepartmentRepository : IOtherDepartmentRepository
    {
        private readonly EmsContext dbContext;

        public OtherDepartmentRepository(EmsContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public bool DeleteOtherDepartment(int id)
        {
            var od = dbContext.OtherDepartments.Where(x=> x.Id == id).FirstOrDefault();
            dbContext.OtherDepartments.Remove(od);
            dbContext.SaveChanges();
            return true;
        }

        public List<OtherDepartment> GetOtherDepartments()
        {
            return dbContext.OtherDepartments.ToList();
        }

        public bool InsertOtherDepartment(OtherDepartment otherDepartment)
        {
            dbContext.OtherDepartments.Add(otherDepartment);
            dbContext.SaveChanges();
            return true;
        }

        public bool UpdateOtherDepartment(OtherDepartment otherDepartment)
        {
            var od = dbContext.OtherDepartments.Where(x=>x.Id == otherDepartment.Id).FirstOrDefault();
            od.Name = otherDepartment.Name;
            od.Description = otherDepartment.Description;
            dbContext.SaveChanges();
            return true;

        }
    }
}
