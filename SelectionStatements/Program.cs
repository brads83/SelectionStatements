using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 0-100 to guess my favorite number");
            var favNumber = 12;
            var userInput = int.Parse(Console.ReadLine());
            if (userInput < favNumber)
            {
                Console.WriteLine("Too low, try again");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Too High, try again");
                Console.ReadLine();
            }
            else (userInput < favNumber)
                { 
                       
                }
            
            
            
        }
    }
}
