using BOL;
// using BOL;
using DAL.Connected;
namespace BLL;


public class  StudentResources{

    //here

    public static List<Student> get(){

        List<Student> plist=new List<Student>();

        plist=DBManager.getallstudent();
        return plist;


    }

}