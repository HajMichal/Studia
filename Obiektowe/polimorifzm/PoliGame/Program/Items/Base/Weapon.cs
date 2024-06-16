namespace PoliGame
{
	public class Weapon
	{
		public string Name;
		public double Dmg;
		public int RequiredLvl;
		public bool CloseRange;

		public Weapon(string name, double dmg, int requiredLvl, bool closeRange)
		{
			Name = name;
			Dmg = dmg;
			RequiredLvl = requiredLvl;
			CloseRange = closeRange;
		}

		public virtual void Description()
		{
			Console.WriteLine(
				$"Item: {Name} \n Damage per hit: {Dmg} \n Required player level: {RequiredLvl} \n Weapon Range: {(CloseRange ? "Close range" : "Distance")}"
			);
		}
	}
}