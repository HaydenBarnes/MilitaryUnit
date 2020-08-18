using System;
using static System.Console;

namespace MilitaryUnitGame
{
    public class HeavyMG : Weapons
    {
        public override void TypeOfWeaponry()
        {
            WriteLine("Heavy Machine Guns");
            WriteLine("--------");
            
        }

        public override void System()
        {
            WriteLine("Platform: M2A1");
        }
        public override void Caliber()
        {
            WriteLine("Caliber: .50 cal");
        }
        public override void ROF()
        {
            WriteLine("Rate of Fire: Automatic");
        }
        public override void Sound()
        {
            WriteLine("boom,boom,boom,boom,boom");
        }

        //public void M2(string ROF, string ammo, string sound)
        //{
        //    WriteLine($"The M2 has a {ROF}, uses a {ammo} round, and makes a {sound} sound.");
        //}
        //public void MK19(string ROF, string ammo, string sound)
        //{
        //    WriteLine($"The MK19 has a {ROF}, uses a {ammo} round, and makes a {sound} sound.");
        //}
    }
}

