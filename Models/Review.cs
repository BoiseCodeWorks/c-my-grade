namespace c_my_grade.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int SubmissionId { get; set; }
        public string Response { get; set; }
        public int PointsReceived { get; set; }

        public Submission StudentSubmission { get; set; }
    }
}