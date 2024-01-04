using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dbcrud.Models;
using BOL;
using BLL;

namespace dbcrud.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }


//here the IActionResult(its an Interface Which is given by ACTIONRESULT) is used for the getting the details from the 
    public IActionResult Details(){
        List<Student> slist=StudentResources.get();
        //Here the List slist will get the data form the STUDENTRESOURCES with GET() Mehthod
        this.ViewData["student_details"]=slist;
        //this will represent the current ViewData and the ViewData["student_details"] is written in the Student_resource 
        //that we need to write as it is as it is passed to the Details.cshtml
        return View();
        //here we are returning the view() to the view(Details.cshtml)
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
