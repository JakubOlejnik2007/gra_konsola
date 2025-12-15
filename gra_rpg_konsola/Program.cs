using System.Text.RegularExpressions;

namespace gra_rpg_konsola { 

class Program
{

        void Main(string[] args)
        {
            List<Enemy> enemies = new List<Enemy>
            {
                new Enemy("Zombie", 21.37f, 67.32f),
                new Enemy("Skeleton", 34.12f, 58.44f),
                new Enemy("Ghoul", 12.89f, 73.05f),
                new Enemy("Vampire", 45.76f, 22.18f),
                new Enemy("Demon", 66.03f, 41.97f),
                new Enemy("Spider", 28.55f, 90.21f),
            };

            var items = new List<Item>
            {
                new Item("Zardzewiały Miecz", 0, 5, 0, 0),
                new Item("Skórzana Zbroja", 3, 0, 10, 5),
                new Item("Żelazny Hełm", 2, 0, 5, 0),
                new Item("Topór Berserkera", 0, 12, -5, 5),
                new Item("Peleryna Wędrowca", 1, 0, 15, 10),
                new Item("Tarcza Strażnika", 6, 0, 0, -5),
                new Item("Sztylet Zabójcy", 0, 8, 0, 15),
                new Item("Zbroja Rycerza", 10, 0, 20, -10),
                new Item("Amulet Życia", 0, 0, 30, 0),
                new Item("Pierścień Wytrzymałości", 0, 0, 0, 25)
            };

            Console.Write("Hello world");
        }
    
}
}
