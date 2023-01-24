using Microsoft.EntityFrameworkCore;
using university.Models;

namespace university.Data.Services
{
    public class MajorsService: IMajorsService
    {
        private readonly AppDbContext _context;

        public MajorsService(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Major major)
        {
            _context.Majors.Add(major);
            _context.SaveChanges();
        }

        public async Task<IEnumerable<Major>> GetAll()
        {
            var result = await _context.Majors.ToListAsync();
            return result;
        }

        public async Task<IEnumerable<Department>> GetDepartments()
        {
            var result = await _context.Departments.ToListAsync();
            return result;
        }
    }
}
