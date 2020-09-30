using System;
using System.ComponentModel;

namespace Ch2_Studio
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a radius: ");
            string radius = Console.ReadLine();

            double area = Math.PI * Math.Pow(double.Parse(radius), 2);
            double circumference = 2 * Math.PI * double.Parse(radius);
            
            Console.WriteLine("The area of a circle with radius " + radius + " is: " + area);
            Console.WriteLine("The circumference of a circle with radius " + radius + " is: " + circumference);

            Console.WriteLine("How many miles per gallon does your car get?");
            string milesPerGallon = Console.ReadLine();
            double gallons = circumference / double.Parse(milesPerGallon);

            Console.WriteLine("Your car will use " + gallons + " gallons of gas to travel the circumference of a circle with radius " + radius);
        }
    }
}
