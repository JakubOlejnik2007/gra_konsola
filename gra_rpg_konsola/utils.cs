using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace gra_rpg_konsola
{
    internal class CONSTS
    {
        public static List<Enemy> ENEMIES = new List<Enemy>
            {
                new Enemy("Zombie", 21.37f, 67.32f, @"
    .-""""-.
   / -   -  \
  |  .-. .- |
  |  \o| |o (
  \     ^    \
  |'.  )--'  /|
 / / '-. .-'`\ \
/ /'---` `---'\ \
'.__.       .__.'
    `|     |`
     |     \
     \      '--.
      '.        `\
        `'---.   |
           ,__) /
            `..'
"),
                new Enemy("Skeleton", 34.12f, 58.44f, @"
    .-.
   (o.o)
    |=|
   __|__
 //.=|=.\\
// .=|=. \\
\\ .=|=. //
 \\(_=_)//
  (:| |:)
   || ||
   () ()
   || ||
   || ||
  ==' '==
"),
                new Enemy("Gryphon", 12.89f, 73.05f, @"
   ____       ____
  /    )     (    \
 /    (  ^_^  )    \
|  {   \('v')/   }  |
|   {   /   \   }   |
|_)(   /\   /\   )(_|
|)  (_ | \|/  |_)  (|
'     ""--^^^^--""  '
"),
                new Enemy("Devil", 45.76f, 22.18f, @"
   ,    ,    /\   /\
  /( /\ )\  _\ \_/ /_
  |\_||_/| < \_   _/ >
  \______/  \|0   0|/
    _\/_   _(_  ^  _)_
   ( () ) /`\|V""""""V|/`\
     {}   \  \_____/  /
     ()   /\   )=(   /\
     {}  /  \_/\=/\_/  \"),
                new Enemy("Demon", 66.03f, 41.97f,@"
         __        _
       _/  \    _(\(o
      /     \  /  _  ^^^o
     /   !   \/  ! '!!!v'
    !  !  \ _' ( \____
    ! . \ _!\   \===^\)
     \ \_!  / __!
      \!   /    \
(\_      _/   _\ )
 \ ^^--^^ __-^ /(__
  ^^----^^    ""^--v'
"),
                new Enemy("Spider", 28.55f, 90.21f,@"
         (
          )
         (
   /\  .-""""""-.  /\
  //\\/  ,,,  \//\\
  |/\| ,;;;;;, |/\|
  //\\\;-""""""-;///\\
 //  \/   .   \/  \\
//`__\.-.-./__`\\
// /.-(() ())-.\ \\
(\ |)   '---'   (| /)
 ` (|           |) `
   \)           (/
"),
            };

        public static List<Item> ITEMS = new List<Item>
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

        public static void printTextIn2Cols(string l, string r, int colWidth = 35)
        {
            string[] leftLines = l.Split('\n');
            string[] rightLines = r.Split('\n');

            for (int i = 0; i < Math.Max(leftLines.Length, rightLines.Length); i++)
            {
                string left = i < leftLines.Length ? leftLines[i].Trim('\r') : "";
                string right = i < rightLines.Length ? rightLines[i].Trim('\r') : "";


                Console.Write(left.PadRight(colWidth));
                Console.WriteLine(right);
            }
        }
    }
}
