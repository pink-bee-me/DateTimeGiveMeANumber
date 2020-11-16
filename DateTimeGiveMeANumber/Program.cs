using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeGiveMeANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("The current date and time is now: " + now);
            Console.WriteLine("\nHow many hours will it be until you must call the taxi to take you to the airport? ");
            int hoursTilDeparture = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nGreat!! The taxi service will be called by : {0}\nHave A Nice Trip!!!", now.AddHours(hoursTilDeparture));
            Console.ReadLine();
        }
    }
}
