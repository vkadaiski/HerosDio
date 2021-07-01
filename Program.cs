using System;
using HerosDIO.src.Entites;

namespace HerosDIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard malu = new Wizard("Malu", 10, " Mage ", 200, 200, "Wand");

            Console.WriteLine(malu.Attack(6));
        }

        

        

        
    }
}
