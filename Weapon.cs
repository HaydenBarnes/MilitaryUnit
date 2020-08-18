using System;
using static System.Console;

namespace MilitaryUnitGame
{
    public class Weapons
    {
        public virtual void TypeOfWeaponry()
        {
            WriteLine("  Type ");
            WriteLine("--------");
        }

        public virtual void System()
        {
            WriteLine("Boom Stick");
        }
        public virtual void Caliber()
        {
            WriteLine("Default");
        }
        public virtual void ROF()
        {
            WriteLine("Soooooo much hate (Default ROF)");
        }
        public virtual void Sound()
        {
            WriteLine("bang bang");
        }
        public void Weaponry()
        {
            Clear();
            WriteLine("This will give a description of weapons used in an Infantry Company");
            WriteLine("Press Enter to continue.");
            ReadLine();
            Clear();

            SmallArms sa = new SmallArms();
            sa.TypeOfWeaponry();
            sa.System();
            sa.Caliber();
            sa.ROF();
            sa.Sound();
            ReadLine();
            

            MediumMG mmg = new MediumMG();
            mmg.TypeOfWeaponry();
            mmg.System();
            mmg.Caliber();
            mmg.ROF();
            mmg.Sound();
            ReadLine();

            HeavyMG hmg = new HeavyMG();
            hmg.TypeOfWeaponry();
            hmg.System();
            hmg.Caliber();
            hmg.ROF();
            hmg.Sound();
            ReadLine();

            AntiTank at = new AntiTank();
            at.TypeOfWeaponry();
            at.System();
            at.Caliber();
            at.ROF();
            at.Sound();
            ReadLine();

            IDF idf = new IDF();
            idf.TypeOfWeaponry();
            idf.System();
            idf.Caliber();
            idf.ROF();
            idf.Sound();
            ReadLine();

            //    ReadLine();
        }
    }
}
