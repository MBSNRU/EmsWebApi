using EmsApi.IRepository;
using EmsApi.Models;

namespace EmsApi.Repository
{
    public class SubjectRepository : ISubjectRepository
    {
        private readonly EmsContext dbContext;

        public SubjectRepository(EmsContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public bool DeleteSubject(int id)
        {
            var sub = dbContext.Subjects.Where(x=>x.Id == id).FirstOrDefault();
            dbContext.Subjects.Remove(sub);
            dbContext.SaveChanges();
            return true;
        }

        public List<Subject> GetSubjects()
        {
            return dbContext.Subjects.ToList();
        }

        public bool InsertSubject(Subject subject)
        {
            dbContext.Subjects.Add(subject);
            dbContext.SaveChanges();
            return true;
        }

        public bool UpdateSubject(Subject subject)
        {
            var sub = dbContext.Subjects.Where(x=>x.Id==subject.Id).FirstOrDefault();
            sub.Name=subject.Name;
            sub.CourseId=subject.CourseId;
            sub.Syllabus=subject.Syllabus;
            dbContext.SaveChanges();
            return true;
        }
    }
}
