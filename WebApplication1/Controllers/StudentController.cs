using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ASPTask2_4.Models;

namespace ASPTask2_4.Controllers
{
    public class StudentController : Controller
    {
        static List<StudentModel> students = new List<StudentModel>();

        [HttpGet]
        public ViewResult Index()
        {
            return View(students.ToList());
        }

        [HttpPost]
        //ex.: Student/Create?name=Dimas
        public IActionResult Create(string name)
        {
            StudentModel model = new StudentModel { Name = name };
            TryValidateModel(model);
            if (ModelState.IsValid)
            {
                students.Add(new StudentModel { Name = name });
                return Redirect("Index");
            }
            else return Redirect("Index");
        }

        [HttpPut]
        //ex.: Student/Update?id=0&name=Semen
        public IActionResult Update(int id, string name)
        {
            StudentModel model = new StudentModel { Name = name };
            TryValidateModel(model);
            if (ModelState.IsValid)
            {
                students[id].Name = name;
                return Redirect("Index");
            }
            else
            {
                return Redirect("Index");
            }
        }

        [HttpDelete]
        //ex.: GET: Student/Delete?id=1
        public IActionResult Delete(int id)
        {
            string name = students[id].Name;
            students.RemoveAt(id);
            return Redirect("Index");
        }

    }
}