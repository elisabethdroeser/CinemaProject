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
            ui.PrintString("2 - Repeat ten times");
            ui.PrintString("3 - The third word");
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
                    RepeatInput();
                    break;
                case "3":
                    ChooseThirdWord();
                    break;
                default:
                    ui.PrintString("Wrong input");
                    break;
            }
        }

        private static void ChooseCustomer()
        {
            Console.WriteLine("Please enter your age!");
            int age = int.Parse(Console.ReadLine());

            if (age >= 5 && age <=18)
            {
                Console.WriteLine("You are a youth");
            } 
            else if (age <= 64)
            {
                Console.WriteLine("You are an adult");
            }
            else if (age >= 64)
            {
                Console.WriteLine("You are a senior citizen");
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
