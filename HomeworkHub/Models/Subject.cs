using System.ComponentModel.DataAnnotations.Schema;

namespace HomeworkHub.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //[ForeignKey(nameof(Teacher))]
        //public int TeacherId { get; set; }

        //public virtual Teacher? Teacher { get; set; }


    }
}
