using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DBcrud.Models;
using BOL;
using DAL;
using BLL;

namespace DBcrud.Controllers;

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

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Product(){
        
        Console.WriteLine("Controller");

        //here the List of student and Classname.method ne call kela aahe came from BLL
        List<Student> plist=Connection.getAllstudent();
        ViewData["products"]=plist;
        // here the products is the token for VIEW
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
