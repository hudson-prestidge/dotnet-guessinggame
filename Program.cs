﻿using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MainMenu();
        }

        private static void MainMenu() 
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Option 1");
            Console.WriteLine("2) Option 2");
            Console.WriteLine("3) Exit");
            string result = Console.ReadLine();
            if(result == "1"){
                PrintNumbers();
            } else if (result == "2"){
                GuessingGame();
            } else if (result == "3"){

            } else {
                Console.WriteLine("Invalid input");
            }
        }

        private static void PrintNumbers() {
            Console.WriteLine("Print Numbers");
            Console.ReadLine();
        }
        private static void GuessingGame() {
            Console.WriteLine("Guessing game!");
            Console.ReadLine();
        }
    }
}
