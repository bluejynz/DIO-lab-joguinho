namespace lab_joguinho.src.Entities
{
    public abstract class Character
    {
        public Character(){}
        public Character(string Name, int Level, int Hp)
        {
            this.Name = Name;
            this.Level = Level;
            this.Hp = Hp;
        }
        public string Name { get; set; }
        public int Level { get; set; }
        public int Hp { get; set; }

        public override string ToString(){
            string show = $"{this.Name}\nLv. {this.Level}\nHP {this.Hp}\n----------------------------------------------------";
            return show;
        }

        public virtual string Attack(){
            return $"{this.Name} atacou com sua espada!";
        }

    }
}