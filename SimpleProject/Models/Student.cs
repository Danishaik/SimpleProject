using System.ComponentModel.DataAnnotations;

namespace SimpleProject.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        
        [Required]
        public string FatherName { get; set; } 
    }
}
