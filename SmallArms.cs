using System;
using static System.Console;

namespace MilitaryUnitGame
{
    public class SmallArms : Weapons
    {
        public override void TypeOfWeaponry()
        {
            WriteLine("Small Arms Weapons");
            WriteLine("--------");
            
        }
        public override void System()
        {
            WriteLine("Platform: M4 Carbine");
        }
        public override void Caliber()
        {
            WriteLine("Caliber: 5.56mm");
        }
        public override void ROF()
        {
            WriteLine("Rate of Fire: Semi-Auto and Auto");
        }
        public override void Sound()
        {
            WriteLine("Sound: pew... pew... pew...");
        }

        //public void M4 (string ROF, string ammo, string sound)
        //{
        //    WriteLine($"The M4 has a {ROF}, uses a {ammo} round, and makes a {sound} sound.");
        //}
        //public void SAW(string ROF, string ammo, string sound)
        //{
        //    WriteLine($"The SAW (Squad Automatic Weapon) has an {ROF}rate of fire, uses a {ammo} round, and makes a {sound} sound.");
        //}
    }
}
