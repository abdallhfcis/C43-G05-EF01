using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Assignment
{
    internal class itiDbContext:DbContext
    {
        public itiDbContext():base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server = DESKTOP-V6B9KL3; Database = itiDb ; Trusted_Connection =true;TrustServerCertificate=true");
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instractor> instractors { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Stu_Course> Stu_Courses { get;set; }
        public DbSet<CourseInstructor> CoursesInstructors { get;set; }

    }
}
