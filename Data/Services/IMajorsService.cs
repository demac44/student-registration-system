using university.Models;

namespace university.Data.Services
{
    public interface IMajorsService
    {

        Task<IEnumerable<Department>> GetDepartments();

        Task<IEnumerable<Major>> GetAll();
        void Add(Major major);
    }
}
