


namespace HerosDIO.src.Entites
{
    public abstract class Hero
    {
        public Hero( string Name, int Level, string HeroType, int Hp, int Mp, string ItemType){

            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Hp = Hp;
            this.Mp = Mp;
            this.ItemType = ItemType;
        }
        public Hero()
        {
            
        }

        public string Name;
        public int Level;
        public string HeroType;
        public int Hp;
        public int Mp;
        public string ItemType;


        public override string ToString(){
            return this.Name+ " " +this.Level+" "+this.HeroType+ " "+ this.Hp+ " "+ this.Mp+" "+ ItemType ;

        }

        public virtual string Attack(){
            return Name +" "+ "Atacou com sua"+" "+ ItemType;
        }




        
    }
}