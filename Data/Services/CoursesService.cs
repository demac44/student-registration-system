using Azure.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using university.Models;

namespace university.Data.Services
{
    public class CoursesService : ICoursesService
    {
        private readonly AppDbContext _context;

        public CoursesService(AppDbContext context)
        {
            _context = context;
        }
        public void Enroll(int studentId, int courseId)
        {            
            var crs = new StudentCourse();
            crs.StudentId = studentId;
            crs.CourseId = courseId;

            _context.StudentCourses.Add(crs);
            _context.SaveChanges();
        }

        public Task<IEnumerable<Course>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Course GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Course>> GetRegistered(int studentId)
        {
            //var result = await _context.StudentCourses.Where(sc => sc.StudentId == studentId)
            //    .Join(c )

            var query = (from student_course in _context.StudentCourses
                        join course in _context.Courses on student_course.CourseId equals course.Id
                        where student_course.StudentId == studentId
                        select course);

            return await query.ToListAsync();
        }

        public async Task<List<Course>> GetUnregistered(int studentId)
        {
            var student = await _context.Students.SingleOrDefaultAsync(s => s.Id == studentId);

            var query = (from course in _context.Courses
                         where !(from student_course in _context.StudentCourses
                                 select student_course.CourseId).Contains(course.Id)
                         where course.MajorId == student.MajorId
                         select course
                         );

            return await query.ToListAsync();
        }

        public void Remove(int studentId, int courseId)
        {
            var crs = new StudentCourse();
            crs.StudentId = studentId;
            crs.CourseId = courseId;

            _context.StudentCourses.Remove(crs);
            _context.SaveChanges();
        }
    }
}
