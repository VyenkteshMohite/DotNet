using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MgnPortal.Models;
using services;
using model;
using System.Runtime.CompilerServices;
namespace MgnPortal.Controllers;

public class EmployeeController : Controller
{
    private IEmployeeService _EmployeeService;

    public EmployeeController(IEmployeeService EmployeeService)
    {
        _EmployeeService = EmployeeService;
    }

    [HttpGet]
    public IActionResult Display()
    {
        var res = _EmployeeService.DisplayEmployeeService();
        this.ViewData["list"] = res;
        return View();
    }
    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Add(int id,string fname, string lname)
    {
        Employee emp = new Employee { EmpId = id, FName = fname, LName = lname };
        var res = _EmployeeService.AddEmployeeService(emp);
        if(res){
            this.ViewData["res"] = "Added Successfully";
            return RedirectToAction("Display");
        }
        this.ViewData["res"] = "Adding Failed";
        return View();
    }
    [HttpGet]
    public IActionResult Update()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Update(int id,string fname, string lname)
    {
        Employee emp = new Employee { EmpId=id,FName = fname, LName = lname };
        var res = _EmployeeService.UpdateEmployeeService(emp);
        if(res){
            this.ViewData["res"] = "Updated Successfully";
            return RedirectToAction("Display");
        }
        this.ViewData["res"] = "Updation Failed";
        return View();
    }
    [HttpGet]
    public IActionResult Delete(int id)
    {
        var res = _EmployeeService.DeleteEmployeeService(id);
        if(res){
            this.ViewData["res"] = "Deleted Successfully";
            return RedirectToAction("Display");
        }
        this.ViewData["res"] = "Deletion Failed";
        return View();
    }

    [HttpGet]
    public IActionResult Show(int id){
        var res = _EmployeeService.DisplayEmployeeService();
        var list = res.Find((e) => e.EmpId == id);
        return View(list);
    }
}
