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
            Random myRandom = new Random();
            int randomNumber = myRandom.Next(1, 11);
            int guesses = 0;
            bool incorrect = true;
            while(incorrect) {
                Console.WriteLine("Pick a number between 1 and 10 inclusive:");
                int guess = int.Parse(Console.ReadLine());
                guesses++;
                if(guess == randomNumber) {
                    incorrect = false;
                    Console.WriteLine("Correct! you took " + guesses + " guesses.");
                } else if (guess < randomNumber) {
                    Console.WriteLine("Incorrect, you guessed too low!");
                } else if (guess > randomNumber) {
                    Console.WriteLine("Incorrect, you guessed too high!");
                }
            }
            Console.ReadLine();
        }
    }
}
