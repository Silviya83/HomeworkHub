using System.ComponentModel.DataAnnotations.Schema;

namespace HomeworkHub.Models
{
    public class StudentAssignment
    {
        public int Id { get; set; }

        [ForeignKey(nameof(Student))]
        public int StudentId { get; set; }


        [ForeignKey(nameof(Assignment))]
        public int AssignmentId { get; set; }
    }
}
