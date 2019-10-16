using System;
using System.Collections.Generic;
using ASP.netORMTest.Models;
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

            modelBuilder.Entity<LessonStudent>()
            .HasKey(pt => new { pt.LessonId, pt.StudentId });

            modelBuilder.Entity<LessonStudent>()
                .HasOne(pt => pt.Lesson)
                .WithMany(p => p.LessonStudents)
                .HasForeignKey(pt => pt.LessonId);

            modelBuilder.Entity<LessonStudent>()
                .HasOne(pt => pt.Student)
                .WithMany(t => t.LessonStudents)
                .HasForeignKey(pt => pt.StudentId);

            var faker = new Faker("en");
            var students = new List<Student>();
            var teachers = new List<Teacher>();
            var lessons = new List<Lesson>();
            var lessonStudents = new List<LessonStudent>();
            for (var i = 1; i <= 10000; i++) {
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

            for (var i = 1; i <= 10000; i++)
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

            for (var i = 1; i <= 10000; i++)
            {
                lessons.Add(
                    new Lesson()
                    {
                        Id = i,
                        Name = faker.Name.FirstName(),
                        TeacherId = faker.Random.Number(1, 10000),
                    }
                );
            }

            for (var i = 1; i <= 10000; i++)
            {
                lessonStudents.Add(
                    new LessonStudent()
                    {
                        StudentId = i,
                        LessonId = i,
                    }
                );
            }
            
            modelBuilder.Entity<Student>().HasData(
                students.ToArray()
            );

            modelBuilder.Entity<Teacher>().HasData(
                teachers.ToArray()
            );

            modelBuilder.Entity<Lesson>().HasData(
                lessons.ToArray()
            );

            modelBuilder.Entity<LessonStudent>().HasData(
                lessonStudents.ToArray()
            );

        }
    }
}
