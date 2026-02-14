// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main()
    {
        Introduction();

        char choice;
        do
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter a number: ");
            int number = int.Parse(Console.ReadLine());

            UserInput(name, number);



            int result = CalculationSum(number, 10);
            Console.WriteLine($"Your result is {result}");


            if (result > 15)
            {
                Console.WriteLine("Your number is greater than 15");
            }
            else if (result < 15)
            {
                Console.WriteLine("Your number is less than 15");
            }
            else
            {
                Console.WriteLine("Your number is equal to 15");
            }
            
            Console.WriteLine("Would you like to run the program again? (Y/N)"); 
            choice = char.Parse(Console.ReadLine());

        }
        while (choice == 'Y' || choice == 'y');
        Console.WriteLine("Program Ended.");

    }

    static void Introduction()
    {
        Console.WriteLine("Welcome to C#!!");
    }

    static void UserInput(string name, int number)
    {
        Console.WriteLine($"Your name is: {name}");
        
        
        Console.WriteLine($"Your number is: {number}");
       
        
    }

    static int CalculationSum(int a, int b)
    {
        return a + b;
        
    }
    
}