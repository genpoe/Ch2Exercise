using System;

namespace NumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the rectangle's length?");
            string userInput = Console.ReadLine();
            int length = int.Parse(userInput);
            Console.WriteLine("What is the rectangle's width?");
            userInput = Console.ReadLine();
            int width = int.Parse(userInput);
            int area = length * width;
            Console.WriteLine("The area of the rectangle is " + area);

        }
    }
}
