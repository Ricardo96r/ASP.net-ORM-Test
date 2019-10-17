using System.Diagnostics;
using ASP.net_ORM_Test.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.InteropServices;
using Bogus;
using ASP.netORMTest.Models;

namespace ASP.net_ORM_Test.Controllers
{
    public class MetricController : Controller
    {
        private SchoolContext context;

        public MetricController(SchoolContext context)
        {
            this.context = context;
        }

        public double StandardDeviation(List<double> values)
        {
            double avg = values.Average();
            double result = Math.Sqrt(values.Average(v => Math.Pow(v - avg, 2)));

            return Math.Round(result, 4);
        }

        public double StandardError(List<double> values)
        {
            double standarDeviation = StandardDeviation(values);
            double result = 3 * (standarDeviation / Math.Sqrt(values.Count));

            return Math.Round(result, 4);
        }

        public double Average(List<double> values)
        {
            double result = values.Average();
            return Math.Round(result, 4);
        }

        public void ActiveDatabase()
        { 
            context.Students.Find(10000);
        }

        public double getMiliseconds(Stopwatch watch)
        {
           
            decimal round = Math.Round((decimal) watch.Elapsed.TotalMilliseconds, 4);
            return (double)round;
        }

        public IActionResult TiempoMedioDeRespuesta()
        {
            List<double> ms = new List<double>();

            for (int i = 1; i <= 10000; i++)
            {
                ActiveDatabase();
                var watch = Stopwatch.StartNew();
                context.Students.Find(i);
                watch.Stop();
                ms.Add(getMiliseconds(watch));
            }

            ViewBag.msList = ms;
            ViewBag.xResult = Math.Round((ms.Sum() / ms.Count), 4);
            ViewBag.msAverage = Average(ms);
            ViewBag.msStdDev = StandardDeviation(ms);
            ViewBag.msStandardError = StandardError(ms);

            return View();
        }

        public IActionResult RendimientoMedio()
        {
            List<double> ms = new List<double>();
            var count = 0;
            for (int i = 1; i <= 100; i++)
            {
                ActiveDatabase();
                var watch = Stopwatch.StartNew();
                var j = 1;
                while (getMiliseconds(watch) < 100)
                {
                    context.Students.Find(j + count);
                    j++;
                }
                watch.Stop();
                ms.Add(j);
                count += j;
            }

            ViewBag.xResult = Math.Round(((ms.Sum() / 0.100) / ms.Count()), 4);
            ViewBag.msList = ms;
            ViewBag.msAverage = ms.Average();
            ViewBag.msStdDev = StandardDeviation(ms);
            ViewBag.msStandardError = StandardError(ms);

            return View();
        }

        public IActionResult CantidadMediaDeMemoriaUtilizada()
        {
            List<double> kb = new List<double>();
            ActiveDatabase();
            for (int i = 1; i <= 100; i++)
            {
                var now = GC.GetTotalMemory(false);
                context.Students.Find(i);
                var after = GC.GetTotalMemory(false);
                kb.Add(after - now);
            }

            ViewBag.kbList = kb;
            ViewBag.kbAverage = kb.Average();
            ViewBag.kbStdDev = StandardDeviation(kb);
            ViewBag.kbStandardError = StandardError(kb);

            return View();
        }

        public IActionResult UtilizacionMediaDelProcesador()
        {
            List<double> processorMs = new List<double>();
            List<double> operationMs = new List<double>();
            for (int i = 1; i <= 100; i++)
            {
                var processorMsSum = 0.00;
                ActiveDatabase();
                var watchOperation = Stopwatch.StartNew();

                var watchProcessor1 = Stopwatch.StartNew();
                context.Students.Find(i + 1);
                watchProcessor1.Stop();
                processorMsSum += getMiliseconds(watchProcessor1);

                var watchProcessor2 = Stopwatch.StartNew();
                context.Teachers.Find(i + 1);
                watchProcessor2.Stop();
                processorMsSum += getMiliseconds(watchProcessor2);

                var watchProcessor3 = Stopwatch.StartNew();
                context.Lessons.Find(i + 1);
                watchProcessor3.Stop();
                processorMsSum += getMiliseconds(watchProcessor3);

                watchOperation.Stop();

                processorMs.Add(Math.Round(processorMsSum, 4));
                operationMs.Add(getMiliseconds(watchOperation));
            }

            var xResult = 0.00;

            for (int i = 0; i < 100; i++)
            {
                xResult += processorMs[i] / operationMs[i];
            }

            xResult = xResult / 100;

            ViewBag.xResult = Math.Round(xResult, 4);

            ViewBag.processorList = processorMs;
            ViewBag.processorAverage = Average(processorMs);
            ViewBag.processorStdDev = StandardDeviation(processorMs);
            ViewBag.processorStandardError = StandardError(processorMs);

            ViewBag.operationList = operationMs;
            ViewBag.operationAverage = Average(processorMs);
            ViewBag.operationStdDev = StandardDeviation(operationMs);
            ViewBag.operationStandardError = StandardError(operationMs);

            return View();
        }

        public IActionResult CapacidadDeProcesamientoDeTransacciones()
        {
            List<double> ms = new List<double>();

            for (int i = 1; i <= 100; i++)
            {
                var faker = new Faker("en");
                var students = new List<Student>();
                var teacher = new Teacher();
                var lesson = new Lesson();
                var lessonStudent = new List<LessonStudent>();
                for (var j = 1; j <= 20; j++)
                {
                    students.Add(
                        new Student()
                        {
                            Name = faker.Name.FirstName(),
                            Lastname = faker.Name.LastName(),
                            Address = faker.Address.FullAddress(),
                            Birthday = faker.Date.Past(),
                        }
                    );
                }

                teacher = new Teacher()
                {
                    Name = faker.Name.FirstName(),
                    Lastname = faker.Name.LastName(),
                    Address = faker.Address.FullAddress(),
                    Birthday = faker.Date.Past(),
                    Profession = faker.Person.Company.Name,
                };

                lesson = new Lesson()
                {
                    Name = faker.Name.FirstName(),
                    Teacher = teacher,
                };

                for (var j = 0; j < 20; j++)
                {
                    lessonStudent.Add(
                        new LessonStudent()
                        {
                            Lesson = lesson,
                            Student = students[j],
                        }
                    );
                }

                lesson.LessonStudents = lessonStudent;

                ActiveDatabase();
                var watch = Stopwatch.StartNew();
                using (var dbContextTransaction = context.Database.BeginTransaction())
                {
                    context.Lessons.Add(lesson);
                    context.SaveChanges();
                    dbContextTransaction.Commit();
                }

                watch.Stop();
                ms.Add(getMiliseconds(watch));
            }

            ViewBag.xResult = Average(ms);
            ViewBag.msList = ms;
            ViewBag.msAverage = Average(ms);
            ViewBag.msStdDev = StandardDeviation(ms);
            ViewBag.msStandardError = StandardError(ms);

            return View();
        }
    }
}