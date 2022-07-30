using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net; //Include this namespace
using System.IO; //Include this namespace

using TP_Console_HoroscopeClient3.HoroscopeService;


namespace TP_Console_HoroscopeClient3
{
    class Program
    {
        static void Main(string[] args)
        {


            //Service Instance
            WebService1SoapClient service = new WebService1SoapClient();
            //Variables
            string FirstName, LastName, ComputerName, IpAddress;
            DateTime BirthDay, CurrentDate;
            List<string> Result;

            //Intro
            Console.WriteLine("Hello! ");
            //Returns Random String
            Console.WriteLine(service.HelloWorld());
            Console.WriteLine("");

            //Collect User Data
            Console.WriteLine("Enter your First Name :");
            FirstName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name :");
            LastName = Console.ReadLine();
            BirthDay =Utils.ValidateDateTime("Enter your birth date [yyyy-mm-dd]" , "That is not a valid date! Try again.") ;


            if (Utils.Confirm("Do you wish to proceed and get your horoscope?"))
            {

                //Get Meta Data
                ComputerName = Dns.GetHostName();
                IpAddress = Convert.ToString(GetPulicIp());
                CurrentDate = DateTime.Now;

                //Call Horoscope Service
                Result = service.Horoscope(FirstName, LastName, ComputerName, IpAddress, BirthDay, CurrentDate);

                //Format Results
                Console.WriteLine("");
                Console.WriteLine("RESULTS :");
                Console.WriteLine("{0} {1}  : {2} ", Result[2], Result[3], Result[9]);
                Console.WriteLine("");
                Console.WriteLine(Result[10]);
                Console.WriteLine("");
                Console.WriteLine(Result[11]);
                Console.WriteLine("");
                Console.WriteLine("Based on your age ({0}), our life coach says : ", Result[8]);
                Console.WriteLine(Result[12]);
                Console.WriteLine("");
                Console.WriteLine("SYSTEM :");
                Console.WriteLine("Web Service Connection: {0} {1}", Result[0], Result[1]);
                Console.WriteLine("Computer {0}, Connected from IP {1} at {2} ", Result[4], Result[5], Result[7]);
                Console.WriteLine("Database Connection : {0}", Result[13]);

            };

            Console.WriteLine("");
            Console.WriteLine("Have a Nice Day!");
            Console.ReadKey();
        }


        private static String GetPulicIp()
        {
            String PublicIpAddess = "";
            WebRequest request = WebRequest.Create("http://checkip.dyndns.org/");
            using (WebResponse response = request.GetResponse())
            using (StreamReader stream = new StreamReader(response.GetResponseStream()))
            {
                PublicIpAddess = stream.ReadToEnd();
            }

            int first = PublicIpAddess.IndexOf("Address: ") + 9;
            int last = PublicIpAddess.LastIndexOf("</body>");
            return PublicIpAddess.Substring(first, last - first);

        }
    }
}
