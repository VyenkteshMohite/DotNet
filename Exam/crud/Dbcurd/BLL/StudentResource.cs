using DAL.Db;
using BOL;

namespace BLL.resource;

public class StudentResource{
    public static List<Student> get(){

        List<Student> plist=new List<Student>();

        plist=DBManager.Getallstudent();

        return plist;

    }
}