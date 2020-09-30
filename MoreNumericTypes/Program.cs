using System;

namespace MoreNumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many miles did you drive?");
            string userInput = Console.ReadLine();
            int milesDriven = int.Parse(userInput);
            Console.WriteLine("How many gallons of gas did you use?");
            userInput = Console.ReadLine();
            int gallonsGas = int.Parse(userInput);
            float mpg = milesDriven / gallonsGas;
            Console.WriteLine("Your miles-per-gallon is " + mpg);
        }
    }
}
