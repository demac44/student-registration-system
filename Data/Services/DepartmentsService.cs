using Microsoft.EntityFrameworkCore;
using university.Models;

namespace university.Data.Services
{
    public class DepartmentsService : IDepartmentsService
    {
        private readonly AppDbContext _context;

        public DepartmentsService(AppDbContext context)
        {
            _context = context;
        }
        public void Add(string name)
        {
            var department = new Department();
            department.Name = name;
            _context.Departments.Add(department);
            _context.SaveChanges();
        }

        public async Task<IEnumerable<Department>> GetAll()
        {
            var result = await _context.Departments.ToListAsync();
            return result;
        }

        public Department GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            var department = new Department();
            department.Id = id;
            _context.Departments.Remove(department);
            _context.SaveChanges();
        }
    }
}
