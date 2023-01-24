using System.ComponentModel.DataAnnotations;

namespace university.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Majors")]
        public IEnumerable<Major> Majors { get; set; }
        public Department()
        {

        }
    }
}
