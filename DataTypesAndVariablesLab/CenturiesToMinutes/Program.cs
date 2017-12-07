using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = 100 * centuries;
            int days = (int)(365.2422 * years);
            int hours = 24 * days;
            int minutes = 60 * hours;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = " +
                $"{minutes} minutes");



        }
    }
}
