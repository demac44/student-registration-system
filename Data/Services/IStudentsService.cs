using university.Models;

namespace university.Data.Services
{
    public interface IStudentsService
    {

        Task<IEnumerable<Student>> GetAll();

        Student GetById(int id);
        void Add(Student student);

        Student Update(int Id, Student newStudent);

        void Delete(int Id);

        Task<IEnumerable<Major>> GetMajors();

        Task<Student> Login(string email, string password);
    }
}
