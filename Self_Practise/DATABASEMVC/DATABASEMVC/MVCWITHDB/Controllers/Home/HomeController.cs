using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCWITHDB.Models;
using BOL.student;
using BAL.resource;
namespace MVCWITHDB.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<Student> slist=StudentResource.getAllStudent();
        this.ViewData["student_list"]=slist;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

  

    
    public IActionResult Welcome()
    {
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
