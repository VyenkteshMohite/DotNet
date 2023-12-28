using BOL;
using MySql.Data.MySqlClient;

namespace DAL;

public class DBManager
{
    public static List<Student> getAllstudent()
    {
        List<Student> allstudent = new List<Student>();
        MySqlConnection connection = new MySqlConnection();
        connection.ConnectionString = "server=192.168.10.150;port=3306;username=dac51;password=welcome;database=dac51";
        string query = "select * from student";
        MySqlCommand command = new MySqlCommand();
        try
        {
            Console.WriteLine("DBmanager");
            command.Connection = connection;
            connection.Open();
            command.CommandText = query;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int iD = int.Parse(reader["id"].ToString());
                string First_name = reader["namefirst"].ToString();
                string Last_name = reader["namelast"].ToString();


                Student stud = new Student(iD,First_name,Last_name);
                allstudent.Add(stud);
            }
            reader.Close();
        }
        catch (Exception e){}
        finally
        {
            connection.Close();
        }
        return allstudent;

    }

}
