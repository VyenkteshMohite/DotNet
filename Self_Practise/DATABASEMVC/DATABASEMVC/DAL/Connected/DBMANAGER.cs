using MySql.Data.MySqlClient;   
namespace dal.dbb.Connected;
using BOL.student;

    
public class DBManager
{
    static String conectsString="server=127.0.0.1;port=3306;user=root;password=Mysql@1234;database=pracdb";

    //this is for getting the list of the student 
    public static List<Student> getAllStudent()
    {
            List<Student> slist=new List<Student>();
                //step1:-make connection
            MySqlConnection con=new MySqlConnection();

            //step2:-connecting string
            
            con.ConnectionString=conectsString;

            //step3:-writes queries
            String query="select * from student_duplicate order by ID";


            MySqlCommand command=new MySqlCommand(query,con);


            try{
                con.Open();
            //step6:-read data object 
                MySqlDataReader reader=command.ExecuteReader();

                while(reader.Read())
                {
                    int id=int.Parse(reader["ID"].ToString());
                    String first_name=reader["namefirst"].ToString();
                    String last_name=reader["namelast"].ToString();

                    Student s=new Student{ID=id,First_name=first_name,Last_name=last_name};

                    slist.Add(s);
                }
            // reader.Close();
            }catch(Exception e){
                    Console.WriteLine(e.Message);
            }finally{
                //connection close
                con.Close();
            }
            return slist;
    }



    //this is for the validation of a user

    public static bool LoginUser(String User_name,String Password)
    {
            MySqlConnection con=new MySqlConnection();

            //step2:-connecting string
            
            con.ConnectionString=conectsString;

            //step3:-writes queries
            String query="select * from UserRegistrations where Name=@User_name and password=@Password";


            MySqlCommand command=new MySqlCommand(query,con);
            command.Parameters.AddWithValue("@User_name",User_name);
            command.Parameters.AddWithValue("@Password",Password);

            try{
                con.Open();
            //step6:-read data object 
                MySqlDataReader reader=command.ExecuteReader();

                while(reader.Read())
                {
                    
                   return true;
                    
                }
            reader.Close();
            }catch(Exception e){
                    Console.WriteLine(e.Message+"Same eroor");
            }finally{
                //connection close
                con.Close();
            }

            return false;
    }


    public static bool UpdateUser(int Id,String First_name,String Last_name)
    {
        MySqlConnection con=new MySqlConnection();

            //step2:-connecting string
            
            con.ConnectionString=conectsString;

            //step3:-writes queries
            String query="update student_duplicate set namefirst=@First_name,namelast=@Last_name where ID=@id";


            MySqlCommand command=new MySqlCommand(query,con);
            command.Parameters.AddWithValue("@First_name",First_name);
            command.Parameters.AddWithValue("@Last_name",Last_name);
            command.Parameters.AddWithValue("@id",Id);
            try{
                con.Open();
            //step6:-read data object 
                command.ExecuteNonQuery();



                return true;
                
            }catch(Exception e){
                    Console.WriteLine(e.Message+"Same eroor");
            }finally{
                //connection close
                con.Close();
            }

            return false;
    }

    public static bool DeleteUser(int Id)
    {
        MySqlConnection con=new MySqlConnection();

            //step2:-connecting string
            
            con.ConnectionString=conectsString;

            //step3:-writes queries
            String query="Delete from student_duplicate where ID=@id";


            MySqlCommand command=new MySqlCommand(query,con);
            
            command.Parameters.AddWithValue("@id",Id);
            try{
                con.Open();
            //step6:-read data object 
                command.ExecuteNonQuery();

                return true;
                
            }catch(Exception e){
                    Console.WriteLine(e.Message+"Same eroor");
            }finally{
                //connection close
                con.Close();
            }

            return false;
    }



    public static bool AddUser(int Id,String First_name,String Last_name)
    {
        MySqlConnection con=new MySqlConnection();

            //step2:-connecting string
            
            con.ConnectionString=conectsString;

            //step3:-writes queries
            String query="insert into student_duplicate(ID,namefirst,namelast) values(@Id,@First_name,@Last_name)";


            MySqlCommand command=new MySqlCommand(query,con);
            command.Parameters.AddWithValue("@Id",Id);
            command.Parameters.AddWithValue("@First_name",First_name);
            command.Parameters.AddWithValue("@Last_name",Last_name);
            try{
                con.Open();
            //step6:-read data object 
                command.ExecuteNonQuery();



                return true;
                
            }catch(Exception e){
                    Console.WriteLine(e.Message+"Same eroor");
            }finally{
                //connection close
                con.Close();
            }

            return false;
    }
}