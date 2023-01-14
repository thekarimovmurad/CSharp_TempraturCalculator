using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_TempraturCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Kelvin to other-1 // Fahrenheit to other-2 // Celsius to other-3 // Exit-0 ");
                int operation = Convert.ToInt32(Console.ReadLine());
                double degree = Convert.ToInt32(Console.ReadLine());
                if (operation == 0)
                {

                    break;
                }
                switch (operation)
                {
                    case 1:
                        Console.WriteLine($"Kelvin to Fahrenheit: {((degree - 273.15) * 1.8) + 32}");
                        Console.WriteLine($"Kelvin to Celsius: {degree - 273.15}");
                        break;
                    case 2:
                        Console.WriteLine($"Celsius to Fahrenheit: {(degree * 1.8) + 32}");
                        Console.WriteLine($"Celsius to Kelvin: {degree + 273.15}");
                        break;
                    case 3:
                        Console.WriteLine($"Fahrenheit to Kelvin: {(degree) * 5 / 9 + 459.67}");
                        Console.WriteLine($"Fahrenheit to Celsius: {(degree - 32) * 5 / 9}");
                        break;

                    default:
                        {
                            Console.WriteLine("Again");
                            break;
                        }
                }
            }
        }
    }
}
