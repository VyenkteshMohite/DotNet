using MgnPortal.Controllers;
using model;
namespace services;

public interface IEmployeeService{
    public List<Employee> DisplayEmployeeService();
    public bool AddEmployeeService(Employee emp);
    public bool UpdateEmployeeService(Employee emp);
    public bool DeleteEmployeeService(int id);
}