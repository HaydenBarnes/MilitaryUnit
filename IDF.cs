using System;
using static System.Console;

namespace MilitaryUnitGame
{
    public class IDF : Weapons
    {
        public override void TypeOfWeaponry()
        {
            WriteLine("Indirect Fire");
            WriteLine("--------");
            
        }

        public override void System()
        {
            WriteLine("Platform: Mortar");
        }
        public override void Caliber()
        {
            WriteLine("Caliber: 60mm, 81mm, 120mm");
        }
        public override void ROF()
        {
            WriteLine("Rate of Fire: Semi-Auto");
        }
        public override void Sound()
        {
            WriteLine("thump....... BOOM!");
        }

        //public void Sixtey(string ROF, string ammo, string sound)
        //{
        //    WriteLine($"The 60mm has a {ROF}, uses a {ammo} round, and makes a {sound}sound.");
        //}
        //public void EightyOne(string ROF, string ammo, string sound)
        //{
        //    WriteLine($"The 81mm has a {ROF}, uses a {ammo} round, and makes a {sound}sound.");
        //}
        //public void OneTwenty(string ROF, string ammo, string sound)
        //{
        //    WriteLine($"The 120mm has an {ROF}rate of fire, uses a {ammo} round, and makes a {sound}sound.");
        //}
    }
}

