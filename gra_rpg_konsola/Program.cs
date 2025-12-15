using System.Text.RegularExpressions;

namespace gra_rpg_konsola
{

    class Program
    {
        void fight(Gracz player, Enemy enemy)
        {
            Console.Clear();

            Console.WriteLine("=== WALKA ===");
            Console.WriteLine($"{player.getImie()} walczy z {enemy.name}!");
            Console.WriteLine

        }

        void eksploruj(Gracz player, List<Item> items, List<Enemy> enemies)
        {
            Random rng = new Random();

            int value = rng.Next(1, 10);

            if (value <= 3)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Cicho wszędzie, głucho wszędzie...");
                Console.ResetColor();
                Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować...");
                Console.ReadKey();

                return;
            }

            if (value <= 6)
            {
                int enemyIdx = rng.Next(0, enemies.Count);
                Enemy enemy = enemies[enemyIdx];

                player.Attack(enemy);

                return;
            }
            else
            {
                int itemIdx = rng.Next(0, items.Count);
                Item item = items[itemIdx];
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Znalazłeś przedmiot!");
                Console.ResetColor();
                item.GetItemInfo();
                Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować...");
                Console.ReadKey();
            }
        }

        static void Main(string[] args)
        {

            Gracz GRACZ = new Gracz("Player", 80f, 100f, 15f);

            List<Enemy> enemies = new List<Enemy>
            {
                new Enemy("Zombie", 21.37f, 67.32f),
                new Enemy("Skeleton", 34.12f, 58.44f),
                new Enemy("Ghoul", 12.89f, 73.05f),
                new Enemy("Vampire", 45.76f, 22.18f),
                new Enemy("Demon", 66.03f, 41.97f),
                new Enemy("Spider", 28.55f, 90.21f),
            };

            List<Item> items = new List<Item>
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

            bool hasFailed = false;

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Witaj w krainie Eldoria, gdzie magia i stal splatają się w nieustannym konflikcie.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("W lasach skrywają się pradawne potwory, a w zamkach czai się zdrada i intryga.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Tylko najodważniejsi bohaterowie odważą się wkroczyć na szlak przygody,");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("by zdobyć legendarny artefakt, który może odmienić losy świata.");
            Console.ResetColor();

            Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            while (!hasFailed)
            {
                Console.ResetColor();
                Console.Clear();
                Console.WriteLine("=== MENU GRY ===");
                Console.WriteLine("1. Odpoczywaj");
                Console.WriteLine("2. Eksploruj");
                Console.WriteLine("3. Wyświetl status gracza");
                Console.WriteLine("4. Opuść grę");
                Console.Write("Wybierz opcję: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        GRACZ.Heal(10);
                        GRACZ.Rest();
                        Console.WriteLine("Odpoczywasz i regenerujesz siły...");
                        break;
                    case "2":
                        GRACZ.LowerStamina(5);
                        Console.WriteLine("Eksplorujesz okolicę i napotykasz różne przygody...");
                        break;
                    case "3":
                        GRACZ.ShowStatus();
                        break;
                    case "4":
                        Console.WriteLine("Opuszczasz grę. Do zobaczenia!");
                        hasFailed = true;
                        break;
                    default:
                        Console.WriteLine("Niepoprawny wybór. Spróbuj ponownie.");
                        break;
                }

                if (!hasFailed)
                {
                    Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować...");
                    Console.ReadKey();
                }
            }
        }
    }
}
