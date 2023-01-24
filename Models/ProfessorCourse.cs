using System.ComponentModel.DataAnnotations.Schema;

namespace university.Models
{
    public class ProfessorCourse
    {

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }
    }
}
