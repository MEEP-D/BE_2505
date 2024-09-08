using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Validation;
using System.Threading.Tasks;

namespace BE_2505.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double Number1 = ValidationData.ValidationInput("Number 1:");
            double Number2 = ValidationData.ValidationInput("Number 2:");

            double tong = Number1 + Number2;
            double hieu = Number1 - Number2;
            double tich = Number1 * Number2;

            Console.WriteLine($"Tong :{tong}");
            Console.WriteLine($"Hieu :{hieu}");
            Console.WriteLine($"Tong :{tich}");

            Console.ReadLine();
        }
    }
}
