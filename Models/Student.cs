using System.Collections.Generic;

namespace c_my_grade.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public float GPA { get; set; }

        // RELATIONSHIPS
        public List<Course> Courses { get; set; } = new List<Course>();
        public List<Submission> Submissions { get; set; } = new List<Submission>();


        public void CalculateGPA()
        {

            var allCoursePoints = 0;
            var allCoursePointsRecieved = 0;
            foreach (var course in Courses)
            {
                var totalCoursePoints = 0;
                var totalCoursePointsRecieved = 0;
                foreach (var assignment in course.Assignments)
                {
                    var submission = assignment.Submissions.Find(s => s.StudentId == Id);
                    var response = submission.ReviewedResponse;
                    totalCoursePoints += assignment.PossiblePoints;
                    totalCoursePointsRecieved += response.PointsReceived;
                }
                allCoursePoints += totalCoursePoints;
                allCoursePointsRecieved += totalCoursePointsRecieved;
            }
            GPA = (allCoursePointsRecieved / allCoursePoints) * 4;
        }


    }
}