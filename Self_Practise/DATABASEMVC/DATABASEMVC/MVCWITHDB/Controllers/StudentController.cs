using BAL.resource;
using BOL.student;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCWITHDB.Models;

namespace MVCWITHDB.Controllers;

public class StudentController : Controller
{
    private readonly ILogger<StudentController> _logger;

    public StudentController(ILogger<StudentController> logger)
    {
        _logger = logger;
    }

    public IActionResult ValidateUser()
    {
        return View();
    }

    public IActionResult Detail()
    {

        List<Student> slist=StudentResource.getAllStudent();
        this.ViewData["student_list"]=slist;
        return View();
    }
    [HttpPost]
    public IActionResult ValidateUser(String User_name,String Password)
    {
        bool status=StudentResource.validate_user(User_name,Password);
        Console.WriteLine(User_name+" "+Password);
        if(status)
        {
           return this.RedirectToAction("Detail");
           
        }
        return View();
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Edit(int Id,String First_name,String Last_name){
        bool status=StudentResource.UpdateUser(Id,First_name,Last_name);
        if(status)
           return this.RedirectToAction("Detail");
    
        return View();
    }

    // public IActionResult Edit(String Edit){
    //     Console.WriteLine("INN");
    //     return this.RedirectToAction("Edit");
    //     return View();
    // }
    
   
    public IActionResult Edit(int id)
    {
        List<Student> slist=StudentResource.getAllStudent();
        
        foreach(Student s in slist)
        {
            if(s.ID==id)
            {
                this.ViewData["particular_id"]=s;
                //return this.RedirectToAction("Detail");
            }
        }
        
        Console.WriteLine("In EDIT ");
        
        return View();
    }


    public IActionResult Delete(int id,String First_name,String Last_name)
    {
        bool status=StudentResource.DeleteUser(id);
        if(status)
             return this.RedirectToAction("Detail");
        return View();
    }


    public IActionResult Add()
    {
        return View();
    }


    [HttpPost]
    public IActionResult Add(int Id,String First_name,String Last_name)
    {
        
        bool status=StudentResource.AddUser(Id,First_name,Last_name);
        Console.WriteLine(status);
        if(status)
        {
            return this.RedirectToAction("Detail");
        }
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}