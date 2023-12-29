using MySql.Data.MySqlClient;


    //make Sql Connection
    MySqlConnection connection=new MySqlConnection();

    //step2=Make String
    
    connection.ConnectionString ="server=192.168.10.150;port=3306;username=dac51;password=welcome;database=dac51";

    //step3=Write query

    string query="select * from student";
    //string query="select count(*) from student";

    //step4=Declare command

    MySqlCommand command=new MySqlCommand(query,connection);

    //step5=connection Open 
     
     try{

        connection.Open();

        //step6= read data object

        MySqlDataReader reader=command.ExecuteReader();

        //step7=Read the Data

        while(reader.Read()){
            int id=int.Parse(reader["ID"].ToString());
            string first_name=reader["namefirst"].ToString();
            string last_name=reader["namelast"].ToString();
            string email=reader["emailID"].ToString();
            

         Console.WriteLine(id+" "+first_name+" "+last_name+"--------"+email);
          //Console.WriteLine(query);

        }
        reader.Close();

     }
     catch(Exception e){

        Console.WriteLine(e.Message);
     }
     finally
     {
        connection.Close();
     }


































