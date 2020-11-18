using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace PolarCape.CollegeApp.DataModel
{
    public class SubjectsDbContext : DbContext
    {
        public SubjectsDbContext(DbContextOptions opt)
            : base(opt)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }

       
    }
}
