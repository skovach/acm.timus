using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToManyTry
{
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<Course> CoursesAttending { get; set; }

        public Person()
        {
            CoursesAttending = new HashSet<Course>();
        }
    }

    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }

        public ICollection<Person> Students { get; set; }

        public Course()
        {
            Students = new HashSet<Person>();
        }
    }

    public class SchoolContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Person> People { get; set; }

        public SchoolContext()
          : base("SchoolDb")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().
              HasMany(c => c.Students).
              WithMany(p => p.CoursesAttending).
              Map(
               m =>
               {
                   m.MapLeftKey("CourseId");
                   m.MapRightKey("PersonId");
                   m.ToTable("PersonCourses");
               });
        }
    }
}

