using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserApp.Models;

namespace UserApp.Controllers
{
    public class StudentController : Controller
    {


      

        //DB_Student objStudent = new DB_Student();







        public ActionResult Index()
        {
            //var list = objStudent.GetAllStudents();
            //ViewBag.Message = list;
            //TempData["Student"] = list;


            List<Student> stu = new List<Student>();
                
                stu.Add( new Student(1,"ABC",20,"Address1"));
            stu.Add(new Student(2,"XYZ",21,"Address2"));
            stu.Add(new Student(3,"Mob",22, "Address3"));
            stu.Add(new Student(4,"Raj",22,"Address4"));
            stu.Add(new Student(5,"Ram",21, "Address5"));
            stu.Add(new Student(6,"Mandy",22, "Address6"));
            stu.Add(new Student(7,"Billy",23, "Address7"));
            stu.Add(new Student(8,"Steve",20, "Address8"));
            stu.Add(new Student(9,"Saitama",20, "Address9"));
            stu.Add(new Student(10,"Morty",22,"Address10"));
            stu.Add(new Student(11,"Rick",21, "Address11"));
            stu.Add(new Student(12,"Jerry",20, "Address12"));
            stu.Add(new Student(13,"Bill",21,"Address13"));
            stu.Add(new Student(14,"Tom",22, "Address14"));


            return View("Student",stu);

        }
        





        }
    }
