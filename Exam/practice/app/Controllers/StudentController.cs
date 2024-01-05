using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using app.Models;
using BOL;
using BLL;
using DAL;

namespace app.Controllers;

public class StudentController : Controller
{
    private readonly ILogger<StudentController> _logger;

    public StudentController(ILogger<StudentController> logger)
    {
        _logger = logger;
    }
    public IActionResult Display(){
        List<Student>slist=StudentManager.getall();
        ViewData["stud"]=slist;
        return View();
    }
    public IActionResult Insert(){
        return View();
    }
    [HttpPost]
    public IActionResult Insert(int id,string name,string contact){
        Console.WriteLine(id);
        Student s=new Student();
        s.id=id;
        s.name=name;
        s.contact=contact;
        DBmanager.Insert(s);
        return View();
    }
     public IActionResult Edit(){
        return View();
    }
    [HttpPost]
    public IActionResult Edit(int id,string name,string contact){
        Console.WriteLine(id);
        Student s=new Student();
        s.id=id;
        s.name=name;
        s.contact=contact;
        DBmanager.Edit(s);
        return View();
    }
    public IActionResult Delete(int id){
        DBmanager.Delete(id);
        return RedirectToAction("Display");
    }

}