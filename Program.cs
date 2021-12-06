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
            ui.PrintString("2 - Buy tickets");
            ui.PrintString("3 - Repeat ten times");
            ui.PrintString("4 - The third word");
        }

        private static void UserInput()
        {
            //Different actions for the user to choose from on menu
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
                    BuyTicket();
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

        private static void BuyTicket()
        {
            if ((age <= 18 && ticket)
        }

        private static void ChooseCustomer()
        {
            //Method to show customer type 
            Console.WriteLine("Please enter your age");
            var age = int.Parse(Console.ReadLine());
            int ticketA = 80;
            int ticketB = 120;
            int ticketC = 90;

            if (age <= 18)
            {
                Console.WriteLine($"You are a youth, your ticketprice is {ticketA} SEK.\n");
            }
            else if (age <= 64)
            {
                Console.WriteLine($"You are an adult, your ticketprice is {ticketB} kr\n");
            }
            else if (age >= 64)
            {
                Console.WriteLine($"You are a senior citizen, your ticketprice is {ticketC} kr\n");
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
