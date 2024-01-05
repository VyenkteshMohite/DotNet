namespace dao;

using System.Collections.Generic;
using System.Configuration;
using model;
using MySql.Data.MySqlClient;

public static class EmployeeDao{
    public static string ConStr = "server=localhost; port=3306; user=root; password=root; database=dbt";
    public static List<Employee>? DisplayEmployeeDao()
    {
        MySqlConnection conn = new MySqlConnection();
        conn.ConnectionString = ConStr;
        string query = "SELECT * FROM newemployee";
        MySqlCommand cmd = new MySqlCommand(query,conn);
        List<Employee> list = new List<Employee>();
        try{
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read()){
                Employee emp = new Employee();
                emp.EmpId = int.Parse(reader["empid"].ToString());
                emp.FName = reader["fname"].ToString();
                emp.LName = reader["lname"].ToString();
                list.Add(emp);
            }
            return list;
        }catch(Exception e){
            Console.WriteLine(e.Message);
            return null;
        }finally{
            conn.Close();
        }
    }

    public static bool AddEmployeeDao(Employee emp)
    {
        MySqlConnection conn = new MySqlConnection();
        conn.ConnectionString = ConStr;
        string query = "INSERT INTO newemployee(fname,lname) VALUES('"+emp.FName+"','"+emp.LName+"')";
        MySqlCommand cmd = new MySqlCommand(query, conn);
        try{
            conn.Open();
            cmd.ExecuteNonQuery();
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return false;
        }
        finally
        {
            conn.Close();
        }
    }

    public static bool UpdateEmployeeDao(Employee emp)
    {
        MySqlConnection conn = new MySqlConnection();
        conn.ConnectionString = ConStr;
        string query = "UPDATE newemployee SET empid='" + emp.EmpId + "',fname='" + emp.FName+"',lname='"+emp.LName+"'WHERE empid='"+emp.EmpId+"'";
        MySqlCommand cmd = new MySqlCommand(query, conn);
        try
        {
            conn.Open();
            cmd.ExecuteNonQuery();
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return false;
        }
        finally
        {
            conn.Close();
        }
    }
    public static bool DeleteEmployeeDao(int id)
    {
        MySqlConnection conn = new MySqlConnection();
        conn.ConnectionString = ConStr;
        string query = "DELETE FROM newemployee WHERE empid='" + id + "'";
        MySqlCommand cmd = new MySqlCommand(query, conn);
        try
        {
            conn.Open();
            cmd.ExecuteNonQuery();
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return false;
        }
        finally
        {
            conn.Close();
        }
    }
}