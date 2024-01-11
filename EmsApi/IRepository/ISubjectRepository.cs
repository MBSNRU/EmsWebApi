using EmsApi.Models;

namespace EmsApi.IRepository
{
    public interface ISubjectRepository
    {
        List<Subject> GetSubjects();
        bool InsertSubject(Subject subject);
        bool UpdateSubject(Subject subject);
        bool DeleteSubject(int id);
    }
}
