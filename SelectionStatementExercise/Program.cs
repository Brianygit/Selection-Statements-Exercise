﻿namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int favNumber = 7;
            Console.WriteLine("Guess my favorite number.");
            int userInput = int.Parse(Console.ReadLine());
            if (userInput < favNumber)
                {
                Console.WriteLine("You entered an incorrect number. Higher!");
                }
            else if (userInput > favNumber)
            {
                Console.WriteLine("You entered an incorrect number. Lower!");
            }
            else 
                
            {
                Console.WriteLine("You guessed this number!");
            }
                

        }
    }
}
