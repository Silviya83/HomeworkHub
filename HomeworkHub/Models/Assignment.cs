using System.ComponentModel.DataAnnotations.Schema;

namespace HomeworkHub.Models
{
    public class Assignment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateOnly? DeadLine { get; set; }

        [ForeignKey(nameof(Subject))]
        public int SubjectId { get; set; }

        [ForeignKey(nameof(Teacher))]
        public int TeacherId { get; set; }


    }
}
