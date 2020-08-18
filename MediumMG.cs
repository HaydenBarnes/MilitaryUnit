using System;
using static System.Console;

namespace MilitaryUnitGame
{
    public class MediumMG : Weapons
    {
        public override void TypeOfWeaponry()
        {
            WriteLine("Medium Machine Guns");
            WriteLine("--------");
            
        }
        public override void System()
        {
            WriteLine("Platform: M240L");
        }
        public override void Caliber()
        {
            WriteLine("Caliber: 7.62mm");
        }
        public override void ROF()
        {
            WriteLine("Rate of Fire: Automatic");
        }
        public override void Sound()
        {
            WriteLine("bang,bang,bang,bang,bang");
        }

        //public void MK48(string ROF, string ammo, string sound)
        //{
        //    WriteLine($"The MK48 has an {ROF} rate of fire, uses a {ammo} round, and makes a {sound} sound.");
        //}
        //public void M240(string ROF, string ammo, string sound)
        //{
        //    WriteLine($"The M240 has a {ROF}, uses a {ammo} round, and makes a {sound} sound.");
        //}

    }
}
