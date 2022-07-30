using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP_HoroscopeService.Models
{
    public class UserData
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ComputerName { get; set; }
        public string IpAddress { get; set; }
        public DateTime BirthDay { get; set; }
        public DateTime CurrentDate { get; set; }


        public UserData()
        {
        }
        public UserData(string firstName, string lastName, string computerName, string ipAddress, DateTime birthDay, DateTime currentDate)
        {
            FirstName = firstName;
            LastName = lastName;
            ComputerName = computerName;
            IpAddress = ipAddress;
            BirthDay = birthDay;
            CurrentDate = currentDate;
        }
    }
}