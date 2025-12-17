using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gra_rpg_konsola
{
    
    internal class Fight
    {
        private Gracz Player;
        private Enemy Opponent;
        private bool isFight = true;
        public Fight(Gracz player, Enemy opponent)
        {
            Player = player;
            Opponent = opponent;

            

            Console.Clear();

            
            while (isFight)
            {
                printState();

                takeAction();

                Console.Clear();

            }
        }

        void printState()
        {
            Console.WriteLine("+" + new String('-', 68) + "+");
            Console.WriteLine("|" + "Walka".PadLeft(34).PadRight(68) + "|");
            Console.WriteLine("+" + new String('-', 68) + "+");
            int colWidth = 19;
            string l =
            $"""
+{new string('-', colWidth)}+
|{CONSTS.CenterText($"{Player.name}", colWidth)}|
|{CONSTS.CenterText($"H: {Player.health}/{Player.maxHealth}", colWidth)}|
|{CONSTS.CenterText($"S: {Player.stamina}/{Player.maxStamina}", colWidth)}|
+{new string('-', colWidth)}+
""";

            string r =
            $"""
+{new string('-', colWidth)}+
|{CONSTS.CenterText($"{Opponent.name}", colWidth)}|
|{CONSTS.CenterText($"H: {Opponent.health}/{Opponent.maxHealth}", colWidth)}|
|{new string(' ', colWidth)}|
+{new string('-', colWidth)}+
""";

            CONSTS.printTextIn2Cols(l, r);


            Console.Write("\n\n");

            CONSTS.printTextIn2Cols(CONSTS.PLAYER_IMAGE, Opponent.image);
        }


        void takeAction()
        {
            Console.WriteLine($"Walczysz z potworem o nazwie: {Opponent.name}! Możesz uciec, będzie to kosztować 20S lub walczyć! Co wybierasz?");

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("A - atakuj, U - uciekaj");

            Console.ResetColor();

            Console.WriteLine("Czekanie na wybór...");


            string choice = "";

            while(!(choice == "A" || choice == "U"))
            {
                choice = Console.ReadLine();
            }

            switch(choice)
            {
                case "U":
                    if (Player.stamina >= 20)
                    {
                        Player.LowerStamina(20);
                        isFight = false;
                    }
                    
                    break;

                case "A":
                    attack();
                    break;

            }

        }

        void attack()
        {
            if (Player.stamina < 5)
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Brak staminy!");
                Console.ResetColor();
                CONSTS.wait_entry();
            } else
            {
                Opponent.TakeDamage(Player.damage);
                Player.LowerStamina(5);
            }




            if (Opponent.health <= 0)
            {
                isFight = false;
                return;
            }

            Player.TakeDamage(Opponent.damage-Player.armor);

            if (Player.health <= 0)
            {
                isFight = false;
                return;
            }


        }
    }
}
