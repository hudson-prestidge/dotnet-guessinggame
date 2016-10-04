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
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Printing Numbers");
            Console.WriteLine("2) Guessing Game");
            Console.WriteLine("3) Exit");
            string result = Console.ReadLine();
            if(result == "1"){
                PrintNumbers();
            } else if (result == "2"){
                GuessingGame();
            } else if (result == "3"){
                return false;
            } else {
                Console.WriteLine("Invalid input");
            } return true;
        }

        private static void PrintNumbers() {
            Console.Clear();
            Console.WriteLine("Print Numbers");
            Console.Write("Type a number:");
            int result = int.Parse(Console.ReadLine());
            Console.Write("1");
            int counter = 2;
            while(counter < result + 1) {
                Console.Write("-" + counter);
                counter++;
            }
            Console.WriteLine();
            Console.WriteLine("Press Enter to Continue");
            Console.ReadLine();
        }
        private static void GuessingGame() {
            Console.Clear();
            Console.WriteLine("Guessing game!");
            Console.ReadLine();
        }
    }
}
