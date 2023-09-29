using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

/// <summary>
/// Summary description for db_handler
/// </summary>
public class db_handler
{


    private static db_handler db;
    public static db_handler getInstance()
    {
        if (db != null) return db;
        db = new db_handler();
        return db;
    }


	public db_handler()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ahmad\\source\\repos\\Meetings\\Meetings\\app_data\\meetings.mdf;Integrated Security=True";




    public DataTable RetriveFromDB(string query)
    {

        using (SqlConnection sqlConn = new SqlConnection(connectionString))
        using (SqlCommand cmd = new SqlCommand(query, sqlConn))
        {
            sqlConn.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
    }

    public bool Execute(string query)
    {

        using (SqlConnection sqlConn = new SqlConnection(connectionString))
        using (SqlCommand cmd = new SqlCommand(query, sqlConn))
        {
            sqlConn.Open();
            return cmd.ExecuteNonQuery() > 0;

        }
    }


    public int ExecuteAndReturnID(string query)
    {

        using (SqlConnection sqlConn = new SqlConnection(connectionString))
        using (SqlCommand cmd = new SqlCommand(query, sqlConn))
        {
            sqlConn.Open();
            int modified = (int)cmd.ExecuteScalar();
            return modified;

        }
    }

}