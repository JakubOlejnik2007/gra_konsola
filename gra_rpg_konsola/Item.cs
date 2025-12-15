using System;

namespace gra_rpg_konsola
{
    public class Item
    {
        public string Name;
        public int Armor;
        public int Damage;
        public int Health;
        public int Stamina;

        public Item(string name, int armor, int damage, int health, int stamina)
        {
            Name = name;
            Armor = armor;
            Damage = damage;
            Health = health;
            Stamina = stamina;
        }

        public void GetItemInfo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(Name + " | ");
            Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("Pancerz: " + Armor + " | ");
            Console.ForegroundColor = ConsoleColor.Red; Console.Write("DMG: " + Damage + " | ");
            Console.ForegroundColor = ConsoleColor.Green; Console.Write("HP: " + Health + " | ");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("STA: " + Stamina);
            Console.ResetColor();
        }
    }
}