using System.Dynamic;

namespace BOL;

public class Student
{

    public int id{get;set;}
    public string firstname{get;set;}
    public string lastname{get;set;}
    public Student(int a,string b,string c){
        this.id=a;
        this.firstname=b;
        this.lastname=c;
    }


}
