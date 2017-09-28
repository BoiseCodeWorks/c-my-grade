using System.Collections.Generic;

namespace c_my_grade.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


        //RELATIONSHIP LETS SAVE PREREQS 

        public List<Student> Students { get; set; }
        public List<Assignment> Assignments { get; set; }

    }   
}