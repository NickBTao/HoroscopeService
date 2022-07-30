using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Console_HoroscopeClient3
{
    class Utils
    {
        /// <summary>
        /// Found this function on the Interwebs, quite elgant and useful
        /// Not sure about ConsoleKey and readKey... but it works.
        /// Promts user for 'y' or 'n' and loops until it gets it one or the other
        /// Made to be used inside an IF or a While Condition, The user's choice then deciding what happens next
        /// </summary>
        /// <param name="msg">A string message prompting the user with a yes or no question
        /// Example: Do you with to update X value?
        /// </param>
        /// <returns>true/false</returns>
        public static bool Confirm(string msg)
        {
            ConsoleKey Entry;
            do
            {
                Console.Write("{0} [y/n]", msg);
                Entry = Console.ReadKey(false).Key;
                if (Entry != ConsoleKey.Enter)
                {
                    Console.WriteLine();
                }
            } while (Entry != ConsoleKey.Y && Entry != ConsoleKey.N);

            return (Entry == ConsoleKey.Y);

        }


        /* Validates that the entered date is a valid DateTime format*/
        public static DateTime ValidateDateTime(string msg, string error_msg)
        {
            DateTime Date = Convert.ToDateTime("2000-01-01");
            string string_date;
            bool error = true;

            Console.WriteLine(msg);
            do
            {
                string_date = Console.ReadLine();
                try
                {
                    Date = Convert.ToDateTime(string_date);
                    error = false;
                }
                catch
                {
                    Console.WriteLine(error_msg);
                    Console.WriteLine(msg);
                }
            } while (error);
            return Date;
        }


    }
}
