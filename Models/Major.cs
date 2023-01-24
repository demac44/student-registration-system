using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace university.Models
{
    public class Major
    {
        [Key]
        public int Id { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set;}
        public string Name { get; set; }
        public string Description { get; set; }
        public int TotalHours { get; set; }

        public List<Course> Courses { get; set; }

        public List<Student> Students { get; set; }
        public Major()
        {

        }
    }
}
