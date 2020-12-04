using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assessment_Dec.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Display()
        {
            List<Student> listStudent = new List<Student>
            {
            new Student{SId=1,SName="Akash",SDob=new DateTime(day:12,month:10,year:2014),SContact="9090909090"},
            new Student{SId=2,SName="Raman",SDob=new DateTime(day:21,month:06,year:2012),SContact="9080808080"},
            new Student{SId=3,SName="Mohit",SDob=new DateTime(day:23,month:11,year:2013),SContact="9070770700"},
            new Student{SId=4,SName="Vishu",SDob=new DateTime(day:23,month:09,year:2011),SContact="9020202020"},
            new Student{SId=5,SName="Lalu",SDob=new DateTime(day:24,month:12,year:2016),SContact="9010101010"}
            };
            int x = listStudent.Count();
            ViewBag.Total = x;

            return View(listStudent);
            
        }
    }
}
