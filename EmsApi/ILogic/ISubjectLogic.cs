using EmsApi.Models;

namespace EmsApi.ILogic
{
    public interface ISubjectLogic
    {
        List<Subject> GetSubjects();
        bool InsertSubject(Subject subject);
        bool UpdateSubject(Subject subject);
        bool DeleteSubject(int id);
    }
}
