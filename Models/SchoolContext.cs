
using System;
using System.Collections.Generic;
using Bogus;
using Microsoft.EntityFrameworkCore;

namespace ASP.net_ORM_Test.Models
{
    public class SchoolContext: DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Lesson> Lessons { get; set; }

        public SchoolContext (DbContextOptions<SchoolContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var faker = new Faker("en");
            var students = new List<Student>();
            var teachers = new List<Teacher>();
            var lessons = new List<Lesson>();
            for (var i = 1; i <= 100000; i++) {
                students.Add(
                    new Student()
                    {
                        Id = i,
                        Name = faker.Name.FirstName(),
                        Lastname = faker.Name.LastName(),
                        Address = faker.Address.FullAddress(),
                        Birthday = faker.Date.Past(),
                    }
                );
            }

            for (var i = 1; i <= 500; i++)
            {
                teachers.Add(
                    new Teacher()
                    {
                        Id = i,
                        Name = faker.Name.FirstName(),
                        Lastname = faker.Name.LastName(),
                        Address = faker.Address.FullAddress(),
                        Birthday = faker.Date.Past(),
                        Profession = faker.Person.Company.Name,
                    }
                ); 
            }

            modelBuilder.Entity<Student>().HasData(
                students.ToArray()
            );

            modelBuilder.Entity<Teacher>().HasData(
                teachers.ToArray()
            );

        }
    }
}
