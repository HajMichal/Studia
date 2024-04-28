namespace polimorfizm
{
	public class Kwadrat:Figura
	{
		private double Bok;

		public Kwadrat(string nazwa, double bok) : base(nazwa)
		{
			Bok = bok;
		}

		public override double Pole() 
		{
			return Bok * Bok;
		}

		public override void Opis()
		{
			base.Opis();
			Console.WriteLine($"Jest to kwadrat o rozmiarze {Bok}");
		}
}
}