using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.SqlClient;
using System.Data;
using Microsoft.AspNetCore.Http;

namespace TP_DB_HoroscopeService.Models
{
    public class DAO
    {

        public static string connectionString = "Data Source = (localDB)\\MSSQLlocalDB;Initial Catalog=DB_Horoscope;Integrated Security=True";
        

        public static int INSERT_UserData(UserData ud)
        {

            SqlConnection conn;
            SqlCommand cmd;

            conn = new SqlConnection(connectionString);
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "InsertUserData";
            cmd.Parameters.Add(new SqlParameter("@first_name", ud.FirstName));
            cmd.Parameters.Add(new SqlParameter("@last_name", ud.LastName));
            cmd.Parameters.Add(new SqlParameter("@computer_name", ud.ComputerName));
            cmd.Parameters.Add(new SqlParameter("@ip_address", ud.IpAddress));
            cmd.Parameters.Add(new SqlParameter("@birth_day", ud.BirthDay));
            cmd.Parameters.Add(new SqlParameter("@cur_date", ud.CurrentDate));
            cmd.Parameters.Add(new SqlParameter("@age", ud.Age));
            cmd.Parameters.Add(new SqlParameter("@astrological_sign", ud.Sign));

            cmd.Connection = conn;
            conn.Open();
            int rowCount = cmd.ExecuteNonQuery();
            conn.Close();
            return rowCount;
        }

        public static List<UserData> SELECT_UserData()
        {

            List<UserData> UserDataList = new List<UserData>();

            SqlConnection conn;
            SqlCommand cmd;
            SqlDataReader reader;

            conn = new SqlConnection(connectionString);
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SelectUserData";
            cmd.Connection = conn;

            conn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                UserData item = new UserData();
                item.ID = reader.GetInt32(0);
                item.FirstName = reader.GetString(1);
                item.LastName = reader.GetString(2);
                item.ComputerName = reader.GetString(3);
                item.IpAddress = reader.GetString(4);
                item.BirthDay = reader.GetDateTime(5);
                item.CurrentDate = reader.GetDateTime(6);
                item.Age = reader.GetInt32(7);
                item.Sign = reader.GetString(8);

                UserDataList.Add(item);
            }

            conn.Close();

            return UserDataList;
        }
    }
}