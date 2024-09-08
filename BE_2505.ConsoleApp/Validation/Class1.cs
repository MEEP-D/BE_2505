using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Validation
{
    public static class ValidationData
    {
        public static double ValidationInput(string message)
        {
            double number;
            string input;
            while (true)
            {
                Console.WriteLine(message);
                input = Console.ReadLine();

                if (Regex.IsMatch(input, @"^\d+(\.\d+)?$") && double.TryParse(input, out number))

                    break;

                else
                    Console.WriteLine("Repeat input number!!!");
            }
            return number;
        }
    } 
}