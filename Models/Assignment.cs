using System.Collections.Generic;

namespace c_my_grade.Models
{
    public class Assignment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int PossiblePoints { get; set; }

        //WHO DO I BELONG TO?
        public int CourseId { get; set; }

        public List<Submission> Submissions { get; set; }

    }
}