//using EmsApi.Models;
//when writing Program it is taking the main Program.cs file instead from the models, that's why wrote as below
//Avoid using keyword names for database tables

namespace EmsApi.ILogic
{
    public interface IProgramLogic
    {
        List<EmsApi.Models.Program> GetPrograms();
        bool InsertProgram(EmsApi.Models.Program program);
        bool UpdateProgram(EmsApi.Models.Program program);
        bool DeleteProgram(int id);
    }
}
