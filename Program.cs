using System;

namespace DemograxExecutable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set the background color and text color
            Console.BackgroundColor = ConsoleColor.DarkRed; 
            Console.ForegroundColor = ConsoleColor.Black;  

           
            Console.Clear();
            
            
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("### Welcome To DemograX ###");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\nThis is an executable file for Demograx.");

            
            Console.ResetColor();


            Console.ReadLine();
        }
    }
}
