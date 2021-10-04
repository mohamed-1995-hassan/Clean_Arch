using DataAccessLayer.Context;
using DataAccessLayer.Models;
using DataAccessLayer.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
   public class StudentRepository<T> : IStudentRepository<T> where T : class
    {
        private StudentDBContext _context = null;
        private DbSet<T> table = null;
        public StudentRepository()
        {
            this._context = new StudentDBContext();
            table = _context.Set<T>();  
        }
        
        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }
        public T GetById(object id)
        {
            return table.Find(id);
        }
        public void Insert(T obj)
        {
            table.Add(obj);
            Save();
        }
        public void Update(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }
        
        public void Save()
        {
            _context.SaveChanges();
        }

        public T GetById(int EmployeeID)
        {
            throw new NotImplementedException();
        }

        public void Delete(int StudentID)
        {
            T existing = table.Find(StudentID);
            table.Remove(existing);
        }
    }  
}


