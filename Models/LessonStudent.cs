using ASP.net_ORM_Test.Models;

namespace ASP.netORMTest.Models
{
    public class LessonStudent
    {
        public int LessonId { get; set; }
        public Lesson Lesson { get; set; }

        public int StudentId { get; set; } 
        public Student Student { get; set; }
    }
}
