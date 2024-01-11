using EmsApi.ILogic;
using EmsApi.IRepository;
using EmsApi.Models;

namespace EmsApi.Logic
{
    public class SubjectLogic : ISubjectLogic
    {
        private readonly ISubjectRepository repo;

        public SubjectLogic(ISubjectRepository repo)
        {
            this.repo = repo;
        }

        public bool DeleteSubject(int id)
        {
            return repo.DeleteSubject(id);
        }

        public List<Subject> GetSubjects()
        {
            return repo.GetSubjects();
        }

        public bool InsertSubject(Subject subject)
        {
            return repo.InsertSubject(subject);
        }

        public bool UpdateSubject(Subject subject)
        {
            return repo.UpdateSubject(subject);
        }
    }
}
