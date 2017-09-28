using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using c_my_grade.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace c_my_grade.Controllers
{
    [Route("api/[controller]")]
    public class StudentsController : Controller
    {
        public GradeContext _db { get; private set; }

        public StudentsController(GradeContext db)
        {
            _db = db;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return _db.Students;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return _db.Students.Find(id);
        }

        // POST api/values
        [HttpPost]
        public string Post([FromBody]Student student)
        {
            _db.Students.Add(student);
            _db.SaveChanges();
            return "Student Created";
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [HttpGet("/api/students/{studentId}/courses")]
        public Student GetCourses(int studentId)
        {
            return _db.Students.Include(s => s.Courses).FirstOrDefault(s => s.Id == studentId);
        }

        [HttpPost("/api/students/{studentId}/courses/{courseId}/join")]
        public string JoinCourse(int studentId, int courseId)
        {
            var course = _db.Courses.Find(courseId);
            var student = _db.Students.Find(studentId);
            if (student != null && course != null)
            {
                student.Courses.Add(course);
                _db.SaveChanges();
                return "Success";
            }
            return "NO WAY JOSE";
        }


    }
}
