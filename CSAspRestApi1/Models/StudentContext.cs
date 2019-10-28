using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace CSAspRestApi1.Models
{
    public partial class StudentContext : DbContext
    {
        public StudentContext() : base("StudentDb")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }

        public DbSet<Student> Students { get; set; }
    }

}