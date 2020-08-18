using System;
using static System.Console;
namespace MilitaryUnitGame
{
    class Program
    {

        static void Main(string[] args)
        {

            bool displayMenu = true;
            while (displayMenu == true)
            {
                displayMenu = MainMenu();
            }

        }

        public static bool MainMenu()
        {
            Clear();
            WriteLine("Choose an option below:\n(1) Weapon Info\n(2) Vehicle Info\n(3) Personnel Info\n(4) Exit");
            string result = ReadLine();

            if (result == "1")
            {
                Weapons weapons = new Weapons();
                weapons.Weaponry();
                return true;
            }
            //else if (result == "2")
            //{
            //    Personnel personnel = new Personnel();

            //    return true;

            //}
            //else if (result == "3")
            //{
            //    Vehicles vehicles = new Vehicles();

            //    return true;
            //}
            else if (result == "4")
            {
                Exit();
                return false;
            }
            else
            {
                WriteLine("Choose a valid option");
                ReadLine();
                return true;
            }

        }
        static void Exit()
        {
            Clear();
            WriteLine("Are you sure?");
            WriteLine("Y or N?");
            string result = ReadLine();

            if (result == "Y")
            {
                Clear();
                WriteLine("Thank you! Goodbye!");
            }
            else if (result == "y")
            {
                Clear();
                WriteLine("Thank you! Goodbye!");
            }
            else if (result == "N")
            {
                MainMenu();
            }
            else if (result == "n")
            {
                MainMenu();
            }
        }
    }
}
