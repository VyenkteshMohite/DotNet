namespace services;
using dao;
using System.Collections.Generic;
using model;
public class EmployeeService : IEmployeeService
{
    public List<Employee>? DisplayEmployeeService()
    {
        var res = EmployeeDao.DisplayEmployeeDao();
        return res;
    }

    public bool AddEmployeeService(Employee emp)
    {
        var res = EmployeeDao.AddEmployeeDao(emp);
        return res;
    }

    public bool UpdateEmployeeService(Employee emp)
    {
        var res = EmployeeDao.UpdateEmployeeDao(emp);
        return res;
    }

    public bool DeleteEmployeeService(int id){
        var res = EmployeeDao.DeleteEmployeeDao(id);
        return res;
    }

}