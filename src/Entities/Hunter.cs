namespace lab_joguinho.src.Entities
{
    public class Hunter : Character
    {
        public Hunter(string Name, int Level, int Hp, int Energy, int Evasion) : base(Name, Level, Hp)
        {
            this.Energy = Energy;
            this.Evasion = Evasion;
        }

        public int Energy { get; set; }
        public int Evasion { get; set; }

        public override string Attack(){
            return $"{this.Name} atirou uma flexa com seu crossbow, perfurando a carne!";
        }
    }
}