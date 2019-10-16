using System;
using System.Collections.Generic;
using ASP.netORMTest.Models;

namespace ASP.net_ORM_Test.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        public List<LessonStudent> LessonStudents { get; set; }
    }
}
