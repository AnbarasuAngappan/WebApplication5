using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();            
        }
      
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //public ActionResult Test()
        //{
            //return View();
            //List<Student> students = new List<Student> {
            // new Student() { StudentId = 1, StudentName = "John", Age = 18 } ,
            //                new Student() { StudentId = 2, StudentName = "Steve",  Age = 21 } ,
            //                new Student() { StudentId = 3, StudentName = "Bill",  Age = 25 } ,
            //                new Student() { StudentId = 4, StudentName = "Ram" , Age = 20 } ,
            //                new Student() { StudentId = 5, StudentName = "Ron" , Age = 31 } ,
            //                new Student() { StudentId = 4, StudentName = "Chris" , Age = 17 } ,
            //                new Student() { StudentId = 4, StudentName = "Rob" , Age = 19 }
            //};

            //var studentList = new List<Student>{
            //                new Student() { StudentId = 1, StudentName = "John", Age = 18 } ,
            //                new Student() { StudentId = 2, StudentName = "Steve",  Age = 21 } ,
            //                new Student() { StudentId = 3, StudentName = "Bill",  Age = 25 } ,
            //                new Student() { StudentId = 4, StudentName = "Ram" , Age = 20 } ,
            //                new Student() { StudentId = 5, StudentName = "Ron" , Age = 31 } ,
            //                new Student() { StudentId = 4, StudentName = "Chris" , Age = 17 } ,
            //                new Student() { StudentId = 4, StudentName = "Rob" , Age = 19 }
            //            };
            // Get the students from the database in the real application

          // return View(students);
       // }

        //public ActionResult Edit(int StudentId)
        //{
        //    List<Student> students = new List<Student>();
        //    //Get the student from studentList sample collection for demo purpose.
        //    //You can get the student from the database in the real application
        //    var std = students.Where(s => s.StudentId == StudentId).FirstOrDefault();

        //    return View(std);
        //}


        //public ActionResult DatafromDB()
        //{
            
        //    Database1Entities1 db = new Database1Entities1();
        //    return View(from table in db.CustomerDetails.Take(10)
        //                select table);
        //}
    }
}