using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TP_MVC_HoroscopeClient1.Models;

using System.Net; //Include this namespace

using HoroscopeService;
using System.IO;

namespace TP_MVC_HoroscopeClient1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            //USER META INFO

            // Retrive the Name of HOST
            string hostName = Dns.GetHostName();

            // Get the MAC address... don't need this
            string MACadd = Dns.GetHostEntry(hostName).AddressList[0].ToString();

            // Get the LOCAL ip address... don't need this either
            IPHostEntry ipEntry = Dns.GetHostEntry(hostName);
            IPAddress[] addr = ipEntry.AddressList;
            string LocalIpAddess =addr[addr.Length - 1].ToString();


            // Get the PUBLIC ip address... use this
            String PublicIpAddess = GetPulicIp();

            //Populate ViewBag for use in Index View
            ViewBag.ComputerName = hostName;
            ViewBag.IpAddress = PublicIpAddess;
            ViewBag.CurrentDate = DateTime.Now;


            //WEB SERVICE

            // Instantiate Connected Soap WebService
            WebService1SoapClient service = new WebService1SoapClient(WebService1SoapClient.EndpointConfiguration.WebService1Soap);
            // Call HelloWorld Web Service Method
            Task<HelloWorldResponse> Msg = service.HelloWorldAsync();
            // .Result.Body.HelloWorldResult  <---- Necessary
            ViewBag.Msg = Msg.Result.Body.HelloWorldResult;

            return View();
        }

        
        public ActionResult Horoscope(Models.UserData ud)
        {

            ud.CurrentDate= DateTime.Now;

            // Instantiate Connected Soap WebService
            WebService1SoapClient service = new WebService1SoapClient(WebService1SoapClient.EndpointConfiguration.WebService1Soap);

            // Call HelloWorld Web Service Method
            Task<HelloWorldResponse> Msg = service.HelloWorldAsync();

            // Call Horoscope Web Service Methode // Pass User Data as Input Parameters
            Task<HoroscopeResponse> Horoscope = service.HoroscopeAsync(ud.FirstName, ud.LastName, ud.ComputerName, ud.IpAddress, ud.BirthDay, ud.CurrentDate);

            //Populate ViewBag for use in Horoscope View
            ViewBag.Msg = Msg.Result.Body.HelloWorldResult;
            ViewBag.HoroscopeResult = Horoscope.Result.Body.HoroscopeResult;


            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
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
