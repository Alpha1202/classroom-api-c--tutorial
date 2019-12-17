using System.ComponentModel.DataAnnotations;

namespace classroom_api_c__tutorial.Models
{
    public class Student
    {
        public long Id { get; set; }

        [Required]
        public string Name { get; set; }

         [Required]
        public int Age { get; set; }
    }
}

