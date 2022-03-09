namespace RPG_Do_Capiroto.src.entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string herotype) : base(name, level, herotype)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        
        public override string Attack()
        {
            return this.Name + " Lançou uma magia";
        }

        public  string Attack(int Bonus)
        {
            if (Bonus <6)
                return this.Name + " Lançou Magia efetiva com bonus de ataque de " + Bonus;
            else
                return this.Name + " Lançou Magia fraca com bonus de ataque de " + Bonus;
        }
    }
}
