using System;

namespace c_my_grade.Models
{
    public class Submission
    {

        public int Id { get; set; }
        public int StudentId { get; set; }
        public int AssignmentId { get; set; }
        public int CourseId { get; set; }
        public string Data { get; set; }
        public DateTime Timestamp { get; set; }

        public Review ReviewedResponse {get; set;}

    }
}