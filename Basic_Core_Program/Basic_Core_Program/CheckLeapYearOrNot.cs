
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Program
{
    class CheckLeapYearOrNot
    {
        public void LeapYear()
        {
            Console.WriteLine("Enter to Year(YYYY) to Check if it is Leap Year or Not: ");//Input From User
            int Checkyear = Convert.ToInt32(Console.ReadLine()); //ConvertToInt

            if ((Checkyear % 400 == 0) || (Checkyear % 4 == 0 && Checkyear % 100 != 0))//checking if year is % of 400 or %4 then its a leap year if %100 its not a leap year
                Console.WriteLine(Checkyear + " is a Leap Year");//For leap Year
            else
                Console.WriteLine(Checkyear + " is not a Leap Year");//For Not a Leap Year
        }
    }
}