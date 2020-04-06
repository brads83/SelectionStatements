using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var favNumber = 12;
            int userInput;
            
            do
            {
                Console.WriteLine("Enter a number between 0-100 to guess my favorite number");
                userInput = int.Parse(Console.ReadLine());

                if (userInput < favNumber)
                {
                    Console.WriteLine("Too low, try again");
                    
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine("Too High, try again");
                    
                }
                else 
                {
                    Console.WriteLine("Bingo, you got it!");
                } 
            } while (userInput != favNumber);

        }
    }
}
