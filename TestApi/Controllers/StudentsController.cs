using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestApi.Models;

namespace TestApi.Controllers
{
    //[Authorize]
    public class StudentsController : ApiController
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET api/<controller>
        public IHttpActionResult Get()
        {
            return Ok(db.Students.ToList());
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            return Ok(db.Students.FirstOrDefault(c => c.Id == id));
        }

        // POST api/<controller>
        public IHttpActionResult Post(Student student)
        {
            db.Students.Add(student);
            db.SaveChanges();

            return Ok();
        }

        // PUT api/<controller>/5
        public IHttpActionResult Put(Student student)
        {
            Student existingStudent = db.Students.FirstOrDefault(c => c.Id == student.Id);

            existingStudent.Address = student.Address;
            existingStudent.DateOfBirth = student.DateOfBirth;
            existingStudent.Name = student.Name;
            existingStudent.Phone = student.Phone;

            db.SaveChanges();

            return Ok();

        }

        // DELETE api/<controller>/5
        public IHttpActionResult Delete(int id)
        {
            db.Students.Remove(db.Students.FirstOrDefault(c => c.Id == id));
            db.SaveChanges();

            return Ok();
        }

        //Dispose Db Context
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}