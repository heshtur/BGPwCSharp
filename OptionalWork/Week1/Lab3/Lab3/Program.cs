using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            float originalFahrenheit;
            Console.Write("Enter temperature (Fahrenheight): ");
            originalFahrenheit = float.Parse(Console.ReadLine());

            float FtoC = (originalFahrenheit - 32) / 9 * 5;
            float CtoF = (float)((FtoC * 9) / 5) + 32;
            
            Console.WriteLine(originalFahrenheit + " degrees Fahrenheit is " + FtoC + " degrees Celsius.");
            Console.WriteLine(FtoC + " degrees Celsius is " + CtoF + " degrees Fahrenheit");
            Console.ReadLine();
            
            
        }
    }
}
