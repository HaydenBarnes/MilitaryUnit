using System;
using static System.Console;

namespace MilitaryUnitGame
{
    public class AntiTank : Weapons
    {
        public override void TypeOfWeaponry()
        {
            WriteLine("Anti-Tank");
            WriteLine("--------");
            
        }
        public override void System()
        {
            WriteLine("Platform: Carl G");
        }
        public override void Caliber()
        {
            WriteLine("Caliber: 84mm");
        }
        public override void Sound()
        {
            WriteLine("BOOM!......KABOOM!");
        }

        //public void CarlG(string ROF, string ammo, string sound)
        //{
        //    WriteLine($"The CarlG has a {ROF}, uses a {ammo} round, and makes a {sound}sound.");
        //}
        //public void AT4(string ROF, string ammo, string sound)
        //{
        //    WriteLine($"The AT4 has an {ROF}rate of fire, uses a {ammo} round, and makes a {sound}sound.");
        //}
    }
}

