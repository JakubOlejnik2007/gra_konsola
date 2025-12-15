using System.Text.RegularExpressions;

namespace gra_rpg_konsola { 

class Program
{

        private enemies;


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

            Console.Write("Hello world");
        }
    
}
}
