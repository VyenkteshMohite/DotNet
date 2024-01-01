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

        List<Student> plist=Connection.getAllstudent();
        ViewData["products"]=plist;
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
