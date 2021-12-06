using System;

namespace CinemaProject
{
    class Program
    {
        static IUI ui = new ConsoleUI();
        static void Main(string[] args)
        {
            //Display text on header
            Console.WriteLine("Cinema Le Xicon");
            Console.WriteLine("You have reached our menu");
            Console.WriteLine("Choose an option from the following list");
            //Ask the user to choose an option
            Console.WriteLine("0 - Exit");
            Console.WriteLine("1 - Customer");
            Console.WriteLine("2 - Repeat ten times");
            Console.WriteLine("3 - The third word");

            do
            {
                ShowMainMenu();
                UserInput();
            } while (true);
        }

        private static void ShowMainMenu()
        {
            ui.PrintString("0 - Exit");
            ui.PrintString("1 - Customer");
            ui.PrintString("2 - Repeat ten times");
            ui.PrintString("3 - The third word");
        }

        private static void UserInput()
        {
            //Different actions for the user to perform on menu
            var input = uint.GetStringInput();
            switch (input)
            {
                case "0":
                    //Ends the program
                    Environment.Exit(0);
                    break;
                case "1":
                    ChooseCustomer();
                    break;
                case "2":
                    RepeatInput();
                    break;
                case "3":
                    ChooseThirdWord;
                    break;
                default:
                    uint.PrintString("Wrong input");
                    break;
            }
        }
    }
}
