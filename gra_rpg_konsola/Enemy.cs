using System;
namespace gra_rpg_konsola
{


    public class Enemy
    {
        public string name { get; }

        public float health { get; private set; }
        public float maxHealth { get;}

        public float damage { get; private set; }

        public string image { get; private set; }


        public Enemy(string name, float health, float damage, string image)
        {
            this.name = name;
            this.health = health;
            this.maxHealth = health;
            this.damage = damage;
            this.image = image;
        }

        public Enemy(Enemy enemy)
        {
            this.name = enemy.name;
            this.health = enemy.health;
            this.maxHealth = enemy.maxHealth;
            this.damage = enemy.damage;
            this.image = enemy.image;
        }

        public void TakeDamage(float damage)
        {
            health -= damage;
            Console.WriteLine($"{name} otrzymuje {damage} obrażeń!");
        }

        public bool isAlive() { return health > 0; }

    }
}
