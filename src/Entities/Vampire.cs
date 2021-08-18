namespace lab_joguinho.src.Entities
{
    public class Vampire : Character
    {
        public Vampire(string Name, int Level, int Hp, int Fullness, int Speed, int Strength) : base(Name, Level, Hp)
        {
            this.Speed = Speed;
            this.Strength = Strength;
            this.Fullness = Fullness;
        }

        public int Speed { get; set; }
        public int Strength { get; set; }
        public int Fullness { get; set; }

        public override string Attack(){
            return $"{this.Name} atacou com suas presas, tirando muito sangue!";
        }
    }
}