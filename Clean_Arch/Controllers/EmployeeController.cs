using DataAccessLayer.Models;
using DataAccessLayer.Repositories;
using DataAccessLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Clean_Arch.Controllers
{
    public class EmployeeController : ApiController
    {
        private IStudentRepository<Student> repository = null;
        public EmployeeController()
        {
            repository = new StudentRepository<Student>();
        }
        // GET api/values
        public  IEnumerable<Student> GetAll()
        {
            return repository.GetAll();
        }

        // GET api/values/5
        public Student GetStudent(int id)
        {
            return repository.GetById(id) ;
        }
        [HttpPost]
        
        // POST api/values
        public void PostStudent([FromBody] Student student)
        {
             repository.Insert(student);
        }

        // PUT api/values/5
        public void Put(Student student)
        {
            repository.Update(student);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            repository.Delete(id);
        }
    }
}
