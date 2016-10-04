using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool displayMenu = true;
            while(displayMenu){
                displayMenu = MainMenu();
            }
        }

        private static bool MainMenu() 
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Option 1");
            Console.WriteLine("2) Option 2");
            Console.WriteLine("3) Exit");
            string result = Console.ReadLine();
            if(result == "1"){
                PrintNumbers();
                return true;
            } else if (result == "2"){
                GuessingGame();
                return true;
            } else if (result == "3"){
                return false;
            } else {
                Console.WriteLine("Invalid input");
                return true;
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
