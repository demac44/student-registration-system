using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace university.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        public int MajorId { get; set; }
        public Major Major { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CreditHours { get; set; }

        public List<StudentCourse> Students { get; set; }

        public List<ProfessorCourse> Professors { get; set; }

        public Course()
        {

        }
    }
}
