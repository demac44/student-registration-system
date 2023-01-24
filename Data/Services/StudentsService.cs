using Microsoft.EntityFrameworkCore;
using university.Models;

namespace university.Data.Services
{
    public class StudentsService : IStudentsService
    {
        private readonly AppDbContext _context;

        public StudentsService(AppDbContext context)
        {
            _context = context;
        }
        public void Add(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Student>> GetAll()
        {
            var result = await _context.Students.ToListAsync();
            return result;
        }

        public Student GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Student Update(int Id, Student newStudent)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Major>> GetMajors()
        {
            var result = await _context.Majors.ToListAsync();
            return result;
        }

        public async Task<Student> Login(string email, string password)
        {
            var result = await _context.Students.FirstOrDefaultAsync(s => s.Email == email && s.Password == password);
            return result;
        }
    }
}
