using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Services
{
    public interface IStudentRepository<T> where T:class
    {
        IEnumerable<T> GetAll();
        T GetById(int EmployeeID);
        void Insert(T student);
        void Update(T student);
        void Delete(int StudentID);
        void Save();
    }
}
