using System.Diagnostics.Contracts;
using BOL;

using MySql.Data.MySqlClient;

namespace DAL.Connected;

public class DBManager{ 


    //here we are creating the mysql server connection 
   // static string connstr ="server=192.168.10.150;port=3306;user=dac51;password=welcome;database=dac51";

    static string connstr="server=127.0.0.1;port=3306;user=root;password=root;database=dbt";
    //here we are creating an list with static for allocating the size at once after execution and we are accesing
    //this getallstudent in the student resources i.e BLL
    public static List<Student> getallstudent(){

        //creating a list object
        List<Student> slist=new List<Student>();
        //step1=make connection
        MySqlConnection connect=new MySqlConnection();

        //step2=connect with string

        connect.ConnectionString=connstr;
        //step3=write query

        string query="select * from student";
        
        MySqlCommand command=new MySqlCommand(query,connect);

        try{
            connect.Open();

            MySqlDataReader reader=command.ExecuteReader();

            while(reader.Read()){
                int id=int.Parse(reader["ID"].ToString());
                string first_name=reader["namefirst"].ToString();
                string  last_name=reader["namelast"].ToString();

                
               Student s=new Student{Id=id,first_name=first_name,last_name=last_name};
                slist.Add(s);
            }

        }
        catch(Exception e){
            Console.WriteLine(e.Message);
        }
        finally{
            connect.Close();
        }

        return slist;

    }
}