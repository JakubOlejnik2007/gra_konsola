using System;

namespace gra_rpg_konsola
{
    public class Gracz
    {
        private string name;

        private float health;
        private float maxHealth;

        private float stamina;
        private float maxStamina;

        private float damage;

        public Gracz(string name, float health, float stamina, float damage)
        {
            this.name = name;

            this.health = health;
            this.maxHealth = health;

            this.stamina = stamina;
            this.maxStamina = stamina;

            this.damage = damage;
        }

        public void Attack(Enemy enemy)
        {
            if (stamina < 10)
            {
                Console.WriteLine("Za mało staminy, aby zaatakować!");
                return;
            }

            stamina -= 10;
            enemy.health -= damage;

            if (enemy.health < 0)
                enemy.health = 0;

            Console.WriteLine($"{name} atakuje {enemy.name} i zadaje {damage} obrażeń!");
        }

        public void TakeDamage(float amount)
        {
            health -= amount;

            if (health < 0)
                health = 0;

            Console.WriteLine($"{name} otrzymuje {amount} obrażeń!");
        }

        public void Heal(float amount)
        {
            health += amount;

            if (health > maxHealth)
                health = maxHealth;

            Console.WriteLine($"{name} leczy się o {amount} HP");
        }

        public void Rest()
        {
            stamina = maxStamina;
            Console.WriteLine($"{name} odpoczywa i odnawia staminę");
        }

        public bool IsAlive()
        {
            return health > 0;
        }

        public void ShowStatus()
        {
            Console.WriteLine("==== GRACZ ====");
            Console.WriteLine($"Imię: {name}");
            Console.WriteLine($"HP: {health}/{maxHealth}");
            Console.WriteLine($"Stamina: {stamina}/{maxStamina}");
            Console.WriteLine($"Obrażenia: {damage}");
            Console.WriteLine("==============");
        }
    }
}