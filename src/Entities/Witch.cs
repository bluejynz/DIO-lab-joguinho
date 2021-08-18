namespace lab_joguinho.src.Entities
{
    public class Witch : Character
    {
        public Witch(string Name, int Level, int Hp, int Mp, int Intelligence) : base(Name, Level, Hp)
        {
            this.Mp = Mp;
            this.Intelligence = Intelligence;
        }

        public int Mp { get; set; }
        public int Intelligence { get; set; }

        public override string Attack(){
            return $"{this.Name} lançou um feitiço de fogo, que cheiro de carne queimada!";
        }
    }
}