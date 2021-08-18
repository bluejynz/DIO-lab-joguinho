using System;
using lab_joguinho.src.Entities;

namespace lab_joguinho
{
    class Program
    {
        static void Main(string[] args)
        {
            Character[] chars = new Character[4];
            chars[0] = new Witch("Josie", 18, 100, 100, 40);
            chars[1] = new Hunter("Ric", 30, 100, 100, 15);
            chars[2] = new Vampire("MG", 8, 350, 100, 40, 40);
            chars[3] = new Werewolf("Rafael", 5, 120, 100, 10, 10, false);
            
            foreach (Character c in chars)
            {
                // Console.WriteLine(c);
                Console.WriteLine(c.Attack());
            }

        }
    }
}
