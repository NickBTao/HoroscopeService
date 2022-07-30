using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP_MVC_AdminHoroscopeClient1.Models
{
    public class UserData
    {

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ComputerName { get; set; }
        public string IpAddress { get; set; }
        public DateTime BirthDay { get; set; }
        public DateTime CurrentDate { get; set; }
        public int Age { get; set; }
        public string Sign { get; set; }

        public UserData()
        {
        }

        public UserData(int id, string firstName, string lastName, string computerName, string ipAddress, DateTime birthDay, DateTime currentDate, int age, string sign)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            ComputerName = computerName;
            IpAddress = ipAddress;
            BirthDay = birthDay;
            CurrentDate = currentDate;
            Age = age;
            Sign = sign;
        }
    }
}
