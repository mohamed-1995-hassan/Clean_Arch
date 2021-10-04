using DataAccessLayer.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace DataAccessLayer.Context
{
    public class StudentDBContext : DbContext
    {
        
        public StudentDBContext()
            : base("name=CleanRepo")
        {
        }
        public DbSet<Student> Students { get; set; }
    }
}