using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TP_MVC_AdminHoroscopeClient1.Models;

using DB_HoroscopeService;

namespace TP_MVC_AdminHoroscopeClient1.Controllers
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


            //Instantiate Web Seriveice
            DB_WebService1SoapClient service = new DB_WebService1SoapClient(DB_WebService1SoapClient.EndpointConfiguration.DB_WebService1Soap);
            // Call Select user data Web Service Method
            Task<SELECT_UserDataResponse> ud = service.SELECT_UserDataAsync();

            // Since Class User Data are identical in both DB_Service and Admin Client
            // This is all that is needed to itterate through the list 
            ViewBag.UserDataList= ud.Result.Body.SELECT_UserDataResult;

            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
