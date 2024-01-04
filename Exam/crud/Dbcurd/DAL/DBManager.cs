using BOL;
using MySql.Data.MySqlClient;

namespace DAL.Db;

public class DBManager{

    static string Connstr="server=127.0.0.1;port=3306;user=root;password=root;database=dbt";

    public static List<Student> Getallstudent(){
        List<Student> slist=new List<Student>();
        
        MySqlConnection conn=new MySqlConnection();

        conn.ConnectionString=Connstr;

        string query="select * from dummy";

        MySqlCommand command=new MySqlCommand(query,conn);

        try{
            conn.Open();
            MySqlDataReader reader=command.ExecuteReader();
            while(reader.Read()){
                int Id=int.Parse(reader["ID"].ToString());
                string firstname=reader["FirstName"].ToString();
                string Lastname=reader["LastName"].ToString();

                Student s=new Student{Id=Id,First_Name=firstname,Last_Name=Lastname};

                slist.Add(s);
            }

        }
        catch(Exception e){
            Console.WriteLine(e.Message);
        }
        finally{
            conn.Close();
        }


        return slist;

    }

}