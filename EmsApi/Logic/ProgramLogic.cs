using EmsApi.ILogic;
using EmsApi.IRepository;

namespace EmsApi.Logic
{
    public class ProgramLogic : IProgramLogic
    {
        private readonly IProgramRepository repo;

        public ProgramLogic(IProgramRepository repo)
        {
            this.repo = repo;
        }

        public bool DeleteProgram(int id)
        {
            return repo.DeleteProgram(id);
        }

        public List<Models.Program> GetPrograms()
        {
            return repo.GetPrograms();
        }

        public bool InsertProgram(Models.Program program)
        {
            return repo.InsertProgram(program);
        }

        public bool UpdateProgram(Models.Program program)
        {
            return repo.UpdateProgram(program);
        }
    }
}
