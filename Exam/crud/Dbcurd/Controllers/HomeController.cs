using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Dbcurd.Models;
using BOL;
using BLL.resource;


namespace Dbcurd.Controllers;

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

    public IActionResult Details()
    {
        List<Student> plist=StudentResource.get();
        this.ViewData["Student_details"]=plist;
        return View();
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
