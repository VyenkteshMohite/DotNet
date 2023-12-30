namespace DAL.Connected;
using BOL;

using MySql.Data.MySqlClient;
//using inbuilt, external Object Models
public class DBManager
{

    public static string connstr = "server=192.168.10.150;port=3306;user=dac50;password=welcome;database=dac50";

    public static List<Hobby> GetAllProducts()
    {
        List<Hobby> data = new List<Hobby>();
        MySqlConnection conn = new MySqlConnection(connstr);
        conn.ConnectionString = connstr;

        string query = "select * from HOBBY";
        try
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = query;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = int.Parse(reader["HOBBYID"].ToString());
                string name = reader["HOBBY"].ToString();
                int wid = int.Parse(reader["WALLETID"].ToString());
                Hobby dept = new Hobby
                {
                    hobbyid = id,
                    hobby = name,
                    walletid = wid
                };
                data.Add(dept);

            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            conn.Close();
        }
        return data;
    }

    public static Hobby GetHobbyById(int id)
    {
        Hobby h1 = null;

        MySqlConnection conn = new MySqlConnection(connstr);
        conn.ConnectionString = connstr;

        string query = "select * from HOBBY where HOBBYID=@id";
        try
        {
            MySqlCommand cmd = new MySqlCommand();

            cmd.Parameters.AddWithValue("@id",id);
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = query;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int hobbyid = int.Parse(reader["HOBBYID"].ToString());
                string hobby = reader["HOBBY"].ToString();
                int walletid = int.Parse(reader["WALLETID"].ToString());
                h1 = new Hobby
                {
                    hobbyid = hobbyid,
                    hobby = hobby,
                    walletid = walletid
                };
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            conn.Close();
        }
        return h1;

    }
}