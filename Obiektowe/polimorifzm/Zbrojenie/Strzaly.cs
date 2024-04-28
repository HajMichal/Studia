namespace Zbrojenie 
{
	public class Strzaly:Kolczan
	{
		protected string RodzajStrzaly;

		public Strzaly(string nazwa, string adres, string nip, string rodzajStrzaly, string model, double glebokosc): base(nazwa, adres, nip, model, glebokosc)
		{
			RodzajStrzaly=rodzajStrzaly;
		}

		public override void Opis() 
		{
			base.Opis();
			Console.WriteLine($"Typ strzały: {RodzajStrzaly}");
		}
	}

}