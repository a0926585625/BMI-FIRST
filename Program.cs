using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double BMI;
            Console.Write("身高:");
            double a = Convert.ToInt32(Console.ReadLine());

            Console.Write("體重:");
            double b = Convert.ToInt32(Console.ReadLine());

            double c = b / ((a / 100) * (a / 100));

            Console.WriteLine("BMI:" + c);

            if (c > 24 && c < 30)
            {
                Console.WriteLine("過重");
                Console.ReadLine();
            }
            else if (c < 24 && c > 18)
            {
                Console.WriteLine("適中");
                Console.ReadLine();
            }
            
            else if (c < 18 && c <15)
            {
                Console.WriteLine("過輕");
                Console.ReadLine();
            }
            else if (c > 30 || c <15)
            {
                Console.WriteLine("免役");
                Console.ReadLine();
            }
            }
            }
    }
