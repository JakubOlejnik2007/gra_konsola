using System;
using System.Collections.Generic;

namespace gra_rpg_konsola
{
    public class Gracz
    {
        public string name { get; private set; }

        public float health { get; private set; }
        public float maxHealth { get; private set; }

        public float stamina { get; private set; }
        public float maxStamina { get; private set; }
        public float armor { get; private set; }

        public float damage { get; private set; }
        public List<Item> collectedItems = new List<Item>();

        public Gracz(string name, float health, float stamina, float damage)
        {
            this.name = name;

            this.health = health;
            this.maxHealth = health;

            this.stamina = stamina;
            this.maxStamina = stamina;
            this.armor = 0;
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
            //enemy.health -= damage;

            //if (enemy.health < 0)
              //  enemy.health = 0;

            Console.WriteLine($"{name} atakuje {enemy.name} i zadaje {damage} obrażeń!");
        }

        public void TakeDamage(float amount)
        {
            health -= amount;

            if (health < 0)
                health = 0;

            Console.WriteLine($"{name} otrzymuje {amount} obrażeń!");
        }

        public void LowerStamina(float stamina)
        {
            this.stamina -= stamina;
            if(this.stamina < 0)
            {
                this.stamina = 0;
            }
        }

        public float getStamina()
        {
            return stamina;
        }

        public float getZdrowie()
        {
            return health;
        }

        public string getImie()
        {
            return name;
        }

        public void CollectItems(Item item)
        {
            if (collectedItems.Count >= 3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nie możesz unieść więcej niż 3 przedmioty!");
                Console.ResetColor();
                return;
            }

            collectedItems.Add(item);

            health += item.Health;
            maxHealth += item.Health;
            stamina += item.Stamina;
            maxStamina += item.Stamina;

            armor += item.Armor;


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Dodano do ekwipunku: {item.Name}");
            Console.ResetColor();
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
            Console.WriteLine($"Przedmioty:");
            foreach (Item item in collectedItems) item.GetItemInfo();
            Console.WriteLine("==============");
        }
    }
}