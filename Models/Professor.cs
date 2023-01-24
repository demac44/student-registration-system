using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace university.Models
{
    public class Professor
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public List<ProfessorCourse> Courses { get; set; }
    }
}
