namespace Timesheet.Models;

public class ErrorViewModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}



// using BOL;
// using MySql.Data.MySqlClient;

// namespace DAL;
// public static class DBmanager{
//     public static string constring=@"server=localhost;port=3306;user=root;password=Purvacw@24;database=dac54";
//     public static List<Student> getall(){
//         List<Student>slist=new List<Student>();
//         MySqlConnection con=new MySqlConnection();
//         con.ConnectionString=constring;
//         string query="select * from student1";
//         MySqlCommand cmd=new MySqlCommand(query,con);
//         try{
//             con.Open();
//             MySqlDataReader reader=cmd.ExecuteReader();
//             while(reader.Read()){
//                 int id=int.Parse(reader["id"].ToString());
//                 string name=reader["name"].ToString();
//                 string contact=reader["contact"].ToString();
//                 Student s=new Student{
//                     id=id,
//                     name=name,
//                     contact=contact,
//                 };
//                 slist.Add(s);

//             }
//         }catch(Exception e){
//             Console.WriteLine(e.Message);
//         }finally{
//             con.Close();
//         }
//         return slist;
//     }
//     public static void Insert(Student s){
//         Console.WriteLine(s.id);
//         MySqlConnection con=new MySqlConnection();
//         con.ConnectionString=constring;
//         string query="insert into student1 values(@id,@name,@contact)";
//         MySqlCommand cmd=new MySqlCommand(query,con);
//         cmd.Parameters.AddWithValue("@id",s.id);
//         cmd.Parameters.AddWithValue("@name",s.name);
//         cmd.Parameters.AddWithValue("@contact",s.contact);
//         try{
//             con.Open();
//             cmd.ExecuteNonQuery();
//         }catch(Exception e){
//             Console.WriteLine(e.Message);
//         }finally{
//             con.Close();
//         }
//         }
//          public static void Edit(Student s){
//         Console.WriteLine(s.id);
//         MySqlConnection con=new MySqlConnection();
//         con.ConnectionString=constring;
//         string query="update student1 set id=@id,name=@name,contact=@contact where id=@id";
//         MySqlCommand cmd=new MySqlCommand(query,con);
//         cmd.Parameters.AddWithValue("@id",s.id);
//         cmd.Parameters.AddWithValue("@name",s.name);
//         cmd.Parameters.AddWithValue("@contact",s.contact);
//         try{
//             con.Open();
//             cmd.ExecuteNonQuery();
//         }catch(Exception e){
//             Console.WriteLine(e.Message);
//         }finally{
//             con.Close();
//         }
//     }
//     public static void Delete(int id){
//         MySqlConnection con=new MySqlConnection();
//         con.ConnectionString=constring;
//         string query="delete from student1 where id=@id";
//         MySqlCommand cmd=new MySqlCommand(query,con);
//         cmd.Parameters.AddWithValue("@id",id);
//         try{
//             con.Open();
//             cmd.ExecuteNonQuery();
//         }catch(Exception e){
//             Console.WriteLine(e.Message);
//         }
//         finally{
//             con.Close();
//         }

//     }
// }