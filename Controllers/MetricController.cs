using System.Diagnostics;
using ASP.net_ORM_Test.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
using System;

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
            double result = 3*(standarDeviation/Math.Sqrt(values.Count));

            return  Math.Round(result, 4);
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

        public double getMiliseconds(decimal ticks)
        {
            decimal miliseconds = (decimal) (ticks / 100000);
            decimal round = Math.Round(miliseconds, 4);
            return (double)round;
        }

        public IActionResult TiempoDeRespuesta()
        {
            List<double> ms = new List<double>();

            for (int i = 1; i <= 100; i++)
            {
                ActiveDatabase();
                var watch = Stopwatch.StartNew();
                context.Students.Find(i);
                watch.Stop();
                ms.Add(getMiliseconds(watch.ElapsedTicks));
            }

            ViewBag.msList = ms;
            ViewBag.msAverage = Average(ms);
            ViewBag.msStdDev = StandardDeviation(ms);
            ViewBag.msStandardError = StandardError(ms);
          
            return View();
        }

        public IActionResult Rendimiento()
        {
            List<double> ms = new List<double>();
            var count = 0;
            for (int i = 1; i <= 100; i++)
            {
                ActiveDatabase();
                var watch = Stopwatch.StartNew();
                var j = 1;
                while (getMiliseconds(watch.ElapsedTicks) < 100)
                {
                    context.Students.Find(j + count);
                    j++;
                }
                watch.Stop();
                ms.Add(j);
                count += j;
            }

            ViewBag.msList = ms;
            ViewBag.msAverage = Average(ms);
            ViewBag.msStdDev = StandardDeviation(ms);
            ViewBag.msStandardError = StandardError(ms);

            return View();
        }

        public IActionResult UtilizacionDeMemoria()
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
            ViewBag.kbAverage = Average(kb);
            ViewBag.kbStdDev = StandardDeviation(kb);
            ViewBag.kbStandardError = StandardError(kb);

            return View();
        }

        public IActionResult UtilizacionDeCache()
        {
            List<double> ms = new List<double>();
            List<double> kb = new List<double>();

            for (int i = 1; i <= 100; i++)
            {
                ActiveDatabase();
                var watch = Stopwatch.StartNew();
                var now = GC.GetTotalMemory(false);
                context.Students.Find(1);
                var after = GC.GetTotalMemory(false);
                watch.Stop();
                kb.Add(after - now);
                ms.Add(getMiliseconds(watch.ElapsedTicks));
            }

            ViewBag.kbList = kb;
            ViewBag.kbAverage = Average(kb);
            ViewBag.kbStdDev = StandardDeviation(kb);
            ViewBag.kbStandardError = StandardError(kb);

            ViewBag.msList = ms;
            ViewBag.msAverage = Average(ms);
            ViewBag.msStdDev = StandardDeviation(ms);
            ViewBag.msStandardError = StandardError(ms);

            return View();
        }

        public IActionResult Capacidad()
        {
            List<double> ms = new List<double>();

            for (int i = 1; i <= 1000; i++)
            {
                ActiveDatabase();
                var watch = Stopwatch.StartNew();
                context.Students.Find(i);
                watch.Stop();
                ms.Add(getMiliseconds(watch.ElapsedTicks));
            }

            ViewBag.msList = ms;
            ViewBag.msAverage = Average(ms);
            ViewBag.msStdDev = StandardDeviation(ms);
            ViewBag.msStandardError = StandardError(ms);

            return View();
        }

        public IActionResult VelocidadBajoEstres()
        {
            List<double> ms = new List<double>();
            ActiveDatabase();
            var iterations = 100;
            for (int i = 1; i <= iterations; i++)
            {
                var watch = Stopwatch.StartNew();
                for (int j = 1; j <= iterations; j++)
                {
                    context.Students.Find(j + (i * iterations));
                }
                watch.Stop();
                double result = getMiliseconds(watch.ElapsedTicks) / iterations;
                decimal round = Math.Round((decimal)result, 4);
                ms.Add((double)round);
            }

            ViewBag.msList = ms;
            ViewBag.msAverage = Average(ms);
            ViewBag.msStdDev = StandardDeviation(ms);
            ViewBag.msStandardError = StandardError(ms);

            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
