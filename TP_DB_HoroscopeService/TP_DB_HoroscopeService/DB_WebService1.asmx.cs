using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using TP_DB_HoroscopeService.Models;

namespace TP_DB_HoroscopeService
{
    /// <summary>
    /// Summary description for DB_WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class DB_WebService1 : System.Web.Services.WebService
    {


        [WebMethod]
        public int INSERT_UserData(string firstName, string lastName, string computerName, string ipAddress, DateTime birthDay, DateTime currentDate, int Age, string Sign)
        {

            UserData ud = new UserData(firstName, lastName, computerName, ipAddress, birthDay, currentDate, Age, Sign);

            // The result is an integer : 1 if 1 row was succesfully inserted or 0 otherwise.
            // This result is sent back to inform the user if database interraction was succesfull
            int Result = DAO.INSERT_UserData(ud);

            return Result;


        }

        [WebMethod]
        public List<UserData> SELECT_UserData()
        {

            List <UserData> Result = DAO.SELECT_UserData();

            //Returns a list of UserData
            //Admin client itterates through the list to display for user
            return Result;


        }

    }
}
