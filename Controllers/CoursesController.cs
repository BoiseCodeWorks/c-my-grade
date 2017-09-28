using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using c_my_grade.Models;
using Microsoft.AspNetCore.Mvc;

namespace c_my_grade.Controllers
{
    [Route("api/[controller]")]
    public class CoursesController : Controller
    {
        public GradeContext _db { get; private set; }

        public CoursesController(GradeContext db)
        {
            _db = db;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Course> Get()
        {
            return _db.Courses;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Course Get(int id)
        {
            return _db.Courses.Find(id);
        }

        // POST api/values
        [HttpPost]
        public string Post([FromBody]Course course)
        {
            _db.Courses.Add(course);
            _db.SaveChanges();
            return "WOOT YOU DID IT";
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            _db.Remove(_db.Courses.Find(id));
            _db.SaveChanges();
            return "cool beans";
        }
    }
}
