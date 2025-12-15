using System;
namespace gra_rpg_konsola
{
	public class Gracz
	{
        public string Imie;

        public float Zdrowie;
        public float MaxZdrowie;

        public float Stamina;
        public float MaxStamina;

		public float Obrazenia;


        public Gracz(float zdrowie, float stamina, float obrazenia)
		{
			this.Zdrowie = zdrowie;
			this.Stamina = stamina;
			this.MaxStamina = stamina;
			this.Obrazenia = obrazenia;
			this.MaxZdrowie = zdrowie;
		}
	}
}

