// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main()
    {
        Introduction();
        
        
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        
        
        Console.WriteLine("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());
        
        UserInput(name, number);
    }

    static void Introduction()
    {
        Console.WriteLine("Welcome to C#!!");
    }

    static void UserInput(string name, int number)
    {
        Console.WriteLine($"Your name is {name}");
        
        
        Console.WriteLine($"Your number is {number}");
       
        
    }
    
}