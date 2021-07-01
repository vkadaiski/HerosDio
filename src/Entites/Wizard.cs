
using System;
namespace HerosDIO.src.Entites
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType, int Hp, int Mp, string ItemType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Hp = Hp;
            this.Mp = Mp;
            this.ItemType = ItemType;
        }

            
        public override string Attack(){
            return this.Name +" "+ "attacked with his"+ " "+ ItemType;
        }

        public string Attack(int Bonus){
            if (Bonus > 5)
                return this.Name +" "+ "attacked with his"+ " "+ ItemType + "with a Bonus Of " + Bonus;
                else{
                    return this.Name +" "+ "attacked with his"+ " "+ ItemType;
                }
        }

        
    }
}