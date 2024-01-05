namespace model;

public class Employee{
    public int? EmpId{ get; set; }
    public string? FName{ get; set; }
    public string? LName{ get; set; }

    public Employee():this(00,"user","user"){}

    public Employee(int id,string fname,string lname){
        this.EmpId = id;
        this.FName = fname;
        this.LName = lname;
    }
}