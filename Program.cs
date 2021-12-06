using System;

namespace CinemaProject
{
    class Program
    {
        static ConsoleUI ui = new ConsoleUI();
        static void Main(string[] args)
        {
            //Inevitable iteration. Exit by using CTRL+C
            /*int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
            }*/

            //Display text on header
            Console.WriteLine("-------Cinema Le Xicon------");
            Console.WriteLine("You have reached our menu");
            Console.WriteLine("Choose an option from the following list");

            do
            {
                ShowMainMenu();
                UserInput();
            } while (true);
            
        }

        private static void ShowMainMenu()
        {
            //Ask the user to choose an option
            ui.PrintString("0 - Exit");
            ui.PrintString("1 - Customer");
            ui.PrintString("2 - Choose tickets");
            ui.PrintString("3 - Repeat ten times");
            ui.PrintString("4 - The third word");
        }

        private static void UserInput()
        {
            //Different actions for the user to perform on menu
            var input = ui.GetStringInput();
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
                    ChooseTickets();
                    break;
                case "3":
                    RepeatInput();
                    break;
                case "4":
                    ChooseThirdWord();
                    break;
                default:
                    ui.PrintString("Wrong input");
                    break;
            }
        }

        private static void ChooseTickets()
        {
            throw new NotImplementedException();
        }

        private static void ChooseCustomer()
        {
            //Method to show customer type 
            Console.WriteLine("Please enter your age");
            var age = int.Parse(Console.ReadLine());

            if (age <=18)
            {
                Console.WriteLine("You are a youth and your price is 80 SEK.\n");
            } 
            else if (age <= 64)
            {
                Console.WriteLine("You are an adult and your price is 120 kr\n");
            }
            else if (age >= 64)
            {
                Console.WriteLine("You are a senior citizen and your price is 90 kr\n");
            }
        }

        private static void ChooseThirdWord()
        {
            throw new NotImplementedException();
        }

        private static void RepeatInput()
        {
            throw new NotImplementedException();
        }

       
    }
}
