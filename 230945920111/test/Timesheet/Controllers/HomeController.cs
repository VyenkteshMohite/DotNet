using System.Data.Common;
using System.Diagnostics;
using BOL;
using DAO;
using Microsoft.AspNetCore.Mvc;
using Timesheet.Models;

namespace Timesheet.Controllers;

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

     public IActionResult Empoyee()
    {
        List<Employee> plist=dbmgr.getall();
        this.ViewData
        return View();
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
