using System;
namespace gra_rpg_konsola
{


    public class Enemy
    {
        public string name;
        public float health;
        public float damage;


        public Enemy(string name)
        {
            this.name = name;

            Random rng = new Random();

            this.health = rng.Next(19, 67);
            this.damage = rng.Next(10, 23);
        }
    }
}
