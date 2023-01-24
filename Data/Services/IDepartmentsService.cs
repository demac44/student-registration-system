using university.Models;

namespace university.Data.Services
{
    public interface IDepartmentsService
    {
        Task<IEnumerable<Department>> GetAll();

        Department GetById(int id);
        void Add(string name);

        void Remove(int id);
    }
}
