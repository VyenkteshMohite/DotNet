using BOL;
// using BOL;
using DAL.Connected;
namespace BLL;


public class  StudentResources{

    //here  the List student is taken as static and we are creating a get() method and we are fetching this get() method 
    //In the home Controller 

    public static List<Student> get(){

        List<Student> plist=new List<Student>();
        //here we are creating a list named as plist which is relating with any other list its only for this class

        plist=DBManager.getallstudent();
        //here we are fetching the data from the DBManager  and storing in the plist and this plist is accessed by the controller
        // by returing PLIST  (i.e classname.method_name) why classname.method name because
        //getallstudent is an static method so to access it outside the class we need to use this format
        //and we are fetching the deatils 
        return plist;
        //here we are returning the plist to get() method and it is accessed by the controller


    }

}