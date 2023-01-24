using university.Models;

namespace university.Data.Services
{
    public interface ICoursesService
    {
        Task<IEnumerable<Course>> GetAll();
        Task<List<Course>> GetRegistered(int studentId);
        Task<List<Course>> GetUnregistered(int studentId);


        Course GetById(int id);
        void Enroll(int studentId, int courseId);

        void Remove(int studentId, int courseId);
    }
}
