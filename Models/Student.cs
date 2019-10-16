using System;
using System.Collections.Generic;
using ASP.netORMTest.Models;

namespace ASP.net_ORM_Test.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthday { get; set; }
        public string Address { get; set; }

        public List<LessonStudent> LessonStudents { get; set; }
    }
}
