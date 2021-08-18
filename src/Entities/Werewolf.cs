namespace lab_joguinho.src.Entities
{
    public class Werewolf : Character
    {
        public Werewolf(string Name, int Level, int Hp, int Energy, int Speed, int Strength, bool WolfForm) : base(Name, Level, Hp)
        {
            this.Energy = Energy;
            this.Speed = Speed;
            this.Strength = Strength;
            this.WolfForm = WolfForm;
        }

        public bool WolfForm { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }
        public int Energy { get; set; }

        public override string Attack(){
            return $"{this.Name} atacou com suas garras, deixando varias feridas abertas!";
        }
    }
}