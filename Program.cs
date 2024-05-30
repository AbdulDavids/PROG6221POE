using System;

namespace PROG6221POE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Recipe Management System!");
            UserInterface ui = new UserInterface();
            ui.Start();
        }
    }
}
//--------------------------------------------------------------------------------------------------------------------