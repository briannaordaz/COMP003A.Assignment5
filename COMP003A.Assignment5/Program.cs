// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main() 
    {
        Introduction(); //the introduction method gets called in the Main method 

        char choice; 
        do //This do-while loop will loop the prompt if the condition below is true
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter a number: ");
            int number = int.Parse(Console.ReadLine());

            UserInput(name, number); //this calls the UserInput method with two parameters 'name' and 'number'



            int result = CalculationSum(number, 10);
            Console.WriteLine($"Your result is {result}");


            if (result > 15) //this is an if/else-if/else statement, it's used to display a message based on whether the condition is true
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
        while (choice == 'Y' || choice == 'y'); //if the user inputs "y" then all of the code above will execute
        Console.WriteLine("Program Ended."); //if the user inputs "n" then the console will display a message and stop the execution  

    }

    static void Introduction() //The Introduction() method displays an introduction message
    {
        Console.WriteLine("Welcome to C#!!");
    }

    static void UserInput(string name, int number) //This UserInput method displays the user's inputs (name and number) and the input gets passed as parameters 'name' and 'number'
    {
        Console.WriteLine($"Your name is: {name}");
        
        
        Console.WriteLine($"Your number is: {number}");
       
        
    }

    static int CalculationSum(int a, int b) //this CalculationSum method returns the sum of the two parameters a and b
    {
        return a + b;
        
    }
    
}