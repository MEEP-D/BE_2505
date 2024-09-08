using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BE_2505_Bai2
{
    public class Program
    {
       public static void Main(string[] args)
        {
            double a = Validate.ValidateData.Validation("a: ");
            double b = Validate.ValidateData.Validation("b: ");
            double c = Validate.ValidateData.Validation("c: ");
            ptbac2(a, b, c);
            Console.ReadLine();
        }

        public static void ptbac2(double a, double b, double c)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("PT vo nghiem !!!");
                }
                else
                {
                    Console.WriteLine($"PT co nghiem duy nhat: {-c / b}");
                }
                return;
            }
            double delta = b * b - 4 * a * c;
            double x1;
            double x2;

            if (delta > 0)
            {
                x1 = (double)((-b + Math.Sqrt(delta)) / (2 * a));
                x2 = (double)((-b - Math.Sqrt(delta)) / (2 * a));
                Console.WriteLine($"Pt co 2 nghiem la: x1 = {x1},x2 = {x2}");
            }else if (delta == 0){
                x1 = (-b / (2 * a));
                Console.WriteLine("Pt co 1 nghiem x1: {0}", x1);
            }else
            {
                Console.WriteLine("Phuong trinh vo nghiem !!!");
            }
            
        }
    }
}
