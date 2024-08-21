using System.ComponentModel.DataAnnotations.Schema;

namespace HomeworkHub.Models
{
    public class TeacherClass
    {
        public int Id { get; set; }
        [ForeignKey(nameof(Teacher))]
        public int TeacherId { get; set;}


        [ForeignKey(nameof(Class))]
        public int ClassId { get; set; }
    }
}
