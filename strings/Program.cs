using System;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string alice = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            Console.WriteLine("Please enter search term:");
            string userSearch = Console.ReadLine();
            if (alice.ToLower().IndexOf(userSearch.ToLower()) == -1)
            {
                Console.WriteLine("Your search term was not found.");
                Console.WriteLine("boo hoo");
            } else
            {
                Console.WriteLine("Your search term was found.");
                Console.WriteLine("Index: " + alice.ToLower().IndexOf(userSearch.ToLower()));
                Console.WriteLine("Length: " + userSearch.Length);
                
            }
        }
    }
}
