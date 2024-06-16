namespace PoliGame
{
	public class Sword : Weapon
	{
		public bool SingleHanded;
		public double FlamesDmg;
		public double FrozenDmg;

		public Sword(string name, double dmg, int requiredLvl, bool closeRange, bool singleHanded, double flamesDmg, double frozenDmg) : base(name, dmg + flamesDmg + frozenDmg, requiredLvl, closeRange)
		{
			SingleHanded = singleHanded;
			FlamesDmg = flamesDmg;
			FrozenDmg = frozenDmg;
		}

		public override void Description()
		{
			Console.WriteLine($"{(SingleHanded ? "Single handed" : "Two handed")} sword \n with {FlamesDmg} fire and {FrozenDmg} ice additional damage");
		}
	}
}