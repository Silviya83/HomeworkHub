using System.ComponentModel.DataAnnotations.Schema;

namespace HomeworkHub.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Class { get; set; }

        [ForeignKey(nameof(Class))]

        public int ClassId { get; set; }
    }
}
