﻿using System.ComponentModel.DataAnnotations.Schema;

namespace HomeworkHub.Models
{
    public class Homework
    {
        public int Id { get; set; }
        public int? Grade { get; set; }
        public bool IsGraded { get; set; }
        public string? Solution { get; set; }

        [ForeignKey(nameof(Student))]
        public int StudentId { get; set; }

        [ForeignKey(nameof(Assignment))]
        public int AssignmentId { get; set; }
    }
}
