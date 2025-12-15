using System.Text.RegularExpressions;

namespace gra_rpg_konsola { 

class Program
{

        static void Main(string[] args)
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
                        playerHealth += 10;
                        playerStamina += 10;
                        Console.WriteLine("Odpoczywasz i regenerujesz siły...");
                        break;
                    case "2":
                        playerStamina -= 5;
                        Console.WriteLine("Eksplorujesz okolicę i napotykasz różne przygody...");
                        break;
                    case "3":
                        Console.WriteLine($"HP: {playerHealth}, STA: {playerStamina}");
                        break;
                    case "4":
                        Console.WriteLine("Opuszczasz grę. Do zobaczenia!");
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Niepoprawny wybór. Spróbuj ponownie.");
                        break;
                }

                if (isRunning)
                {
                    Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować...");
                    Console.ReadKey();
                }
            }
        }
    }
}

Console.Write("Hello world");
        }
    
}
}
