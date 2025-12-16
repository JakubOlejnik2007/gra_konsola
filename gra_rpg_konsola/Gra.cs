using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gra_rpg_konsola
{
    internal class Gra
    {
        bool hasFailed = false;
        private Gracz GRACZ = new Gracz("Player", 80f, 100f, 1f);
        void fight(Gracz player, Enemy enemy)
        {
            Console.Clear();

            Console.WriteLine("=== WALKA ===");
            Console.WriteLine($"{player.getImie()} walczy z {enemy.name}!");
        }

        void eksploruj()
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
                int enemyIdx = rng.Next(0, CONSTS.ENEMIES.Count);
                Enemy enemy = new Enemy(CONSTS.ENEMIES[enemyIdx]);

                new Fight(GRACZ, enemy);

                if (enemy.health <= 0)
                {
                    Console.WriteLine("Wygrałeś");
                }

                if (GRACZ.health <= 0)
                {
                    Console.WriteLine("przegrałeś");
                }

                if (enemy.health > 0 && GRACZ.health > 0)
                {
                    Console.WriteLine("Uciekłeś!");
                }

                return;
            }
            else
            {
                int itemIdx = rng.Next(0, CONSTS.ITEMS.Count);
                Item item = CONSTS.ITEMS[itemIdx];

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Znalazłeś przedmiot!");
                Console.ResetColor();

                item.GetItemInfo();

                GRACZ.CollectItems(item);
            }
        }


        public void start()
        {


            

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Witaj w krainie Eldoria, gdzie magia i stal splatają się w nieustannym konflikcie.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("W lasach skrywają się pradawne potwory, a w zamkach czai się zdrada i intryga.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Tylko najodważniejsi bohaterowie odważą się wkroczyć na szlak przygody,");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("by zdobyć legendarny artefakt, który może odmienić losy świata.");
            Console.ResetColor();

            CONSTS.wait_entry();

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
                        eksploruj();
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
                    CONSTS.wait_entry();
                }
            }
        } }
}
