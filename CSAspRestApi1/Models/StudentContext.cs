using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CSAspRestApi1.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("StudentDb")
        {

        }

        public DbSet<Student> Students { get; set; }
    }

}