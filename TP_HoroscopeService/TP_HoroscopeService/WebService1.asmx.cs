using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;


using TP_HoroscopeService.DB_HoroscopeService;




namespace TP_HoroscopeService
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return Utils.RandomMsg();
        }


        [WebMethod]
        public List<string> Horoscope(string firstName, string lastName, string computerName, string ipAddress, DateTime birthDay, DateTime currentDate)
        {

            /* The output of the Service is a List String
             * Strings are easier to work with, generally
             * It's not clear to me how to pass and return a custom object (like User Data) to and from services
             * */
            List<string> Result = new List<string>() {"","","","","","","","","","","","","",""};

            try
            {
                //Reconstruct User Data object based on service input parameters
                Models.UserData ud = new Models.UserData(firstName, lastName, computerName, ipAddress, birthDay, currentDate);


                //Populate String List : Result



                //UserData
                Result[2] = ud.FirstName;
                Result[3] = ud.LastName;
                Result[4] = ud.ComputerName;
                Result[5] = ud.IpAddress;
                Result[6] = Convert.ToString(ud.BirthDay);
                Result[7] = Convert.ToString(ud.CurrentDate);

                // Calculate Age
                int Age = Utils.CalculateAge(ud.BirthDay, ud.CurrentDate);

                if (Age < 0)
                {
                    Result[8] =  "... not born yet...";

                }
                else
                {
                    Result[8] =Convert.ToString(Age);
                }

                // Atrological Sign and description based on birthday
                List<string> SignResult = Utils.AstologicalSign(ud.BirthDay);
                Result[9] = SignResult[0];
                Result[10] = SignResult[1];
                Result[11] = SignResult[2];

                // Life Coach advise based on birth Year
                Result[12] = Utils.LifeCoach(ud.BirthDay.Year);


                // Instantiating Database Service
                DB_WebService1SoapClient db_service = new DB_WebService1SoapClient();

                int DB_Result = db_service.INSERT_UserData(
                    ud.FirstName,
                    ud.LastName,
                    ud.ComputerName,
                    ud.IpAddress,
                    ud.BirthDay,
                    ud.CurrentDate,
                    Age,
                    SignResult[0] // Sign;
                );

                // Will return 1 if method successfully inserted 1 Row 
                if (DB_Result == 1)
                {
                    Result[13] = "Interface Succesfull!";
                } else
                {
                    Result[13] = "Interface Failled";
                }

                //Connection Message
                //Evaluates that all strings are not empty and that the database insert succeeded.

                if (Result[2] !="" && Result[3] != "" && Result[4] != "" && Result[5] != "" && Result[6] != "" &&
                    Result[7] != "" && Result[8] != "" && Result[9] != "" && Result[10] != "" && Result[11] != "" &&
                    Result[12] != "" && Result[13] != "" && DB_Result == 1
                    )
                {
                    Result[0] = "Success!";
                    Result[1] = "Horoscope Web Service was consulted without difficulty.";
                } else
                {
                    Result[0] = "Error!";
                    Result[1] = "Something went horribly, horribly Wrong... My AI overLord screams : DoeS nOt cOmpUtE!!!";
                }


            }
            catch
            {

                //In case anything goes wrong...
                Result[0] = "Error!";
                Result[1] = "Something went horribly, horribly Wrong... My AI overLord screams : DoeS nOt cOmpUtE!!!";

            }

            return Result;
        }


    }
}
