using System;
using System.Collections.Generic;
using System.Linq;


namespace GuessingGame
{
    class Program
    {
        void Main()
        {
            int SecretNum = 42;

            Console.Write("Welcome! Guess a number!");
            string response = Console.ReadLine();
            int ParsedResponse = int.Parse(response);
            Console.WriteLine(ParsedResponse);
            
        }
    }
}

