using System;

namespace CinemaProject
{
    public class ConsoleUI : IUI
    {
        public string GetStringInput()
        {
            return Console.ReadLine();
        }
        public void PrintString(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class MockUI : IUI
    {
        public string GetStringInput()
        {
            return "1";
        }

        public void PrintString(string message);
        {

        }
    }
}
