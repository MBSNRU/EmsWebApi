using EmsApi.IRepository;
using EmsApi.Models;

namespace EmsApi.Repository
{
    public class ProgramRepository : IProgramRepository
    {
        private readonly EmsContext dbContext;

        public ProgramRepository(EmsContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public bool DeleteProgram(int id)
        {
            var pro = dbContext.Programs.Where(x=>x.Id == id).FirstOrDefault();
            dbContext.Programs.Remove(pro);
            dbContext.SaveChanges();
            return true;
        }

        public List<Models.Program> GetPrograms()
        {
            return dbContext.Programs.ToList();
        }

        public bool InsertProgram(Models.Program program)
        {
            dbContext.Programs.Add(program);
            dbContext.SaveChanges();
            return true;
        }

        public bool UpdateProgram(Models.Program program)
        {
            var pro = dbContext.Programs.Where(x => x.Id == program.Id).FirstOrDefault();
            pro.Name = program.Name;
            pro.Code = program.Code;
            pro.Description = program.Description;
            pro.Duration = program.Duration;
            dbContext.SaveChanges();
            return true;
        }
    }
}
