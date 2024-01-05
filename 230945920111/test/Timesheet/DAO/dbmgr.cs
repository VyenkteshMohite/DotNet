using BOL;
using MySql.Data.MySqlClient;

namespace DAO;

public class dbmgr{

        public static string connectstring="server=192.168.10.150;port=3306;user=dac51;password=welcome;database=dac51";

       public static List<Employee> getall(){
        List<Employee> slist=new List<Employee>();
        MySqlConnection con=new MySqlConnection();
        con.ConnectionString=connectstring;
        string query="select * from timesheet1";
        MySqlCommand cmd=new MySqlCommand(query,con);
        try{
            con.Open();
            MySqlDataReader reader=cmd.ExecuteReader();
            while(reader.Read()){
                int id=int.Parse(reader["Id"].ToString());
                string W_Date=reader["W_date"].ToString();
                string desc=reader["Work_desc"].ToString();
                string duration=reader["duration"].ToString();
                string status=reader["Status"].ToString();

                Employee e=new Employee{
                        Id=id,
                        Date=W_Date,
                        desc=desc,
                        duration=duration,
                        status=status
                     };
                    slist.Add(e);
            }
        }
        catch(Exception e){
                Console.WriteLine(e.Message);
        }
        finally{
            con.Close();
        }
         return slist;
    } 
}               
                



