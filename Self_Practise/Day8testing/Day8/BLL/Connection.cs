namespace BLL;
using BOL;
using DAL;
public static class Connection
{

    public static List<Student> getAllstudent(){
        Console.WriteLine("Connection");
        List<Student> allstudent=new List<Student>();
        allstudent=DBManager.getAllstudent();
        return allstudent;

    }

}
