using System;
namespace gra_rpg_konsola
{


    public class Enemy
    {
        public string name;
        public float health;
        public float damage;


        public Enemy(string name, float health, float damage)
        {
            this.name = name;
            this.health = health;
            this.damage = damage;
        }
    }
}
