namespace Zbrojenie 
{
	public class Luska:Pocisk
	{
		private string RodzajStali;

		public Luska(string nazwa, string adres, string nip, string rodzajStali, double kaliber,  string model) : base(nazwa, adres, nip, kaliber, model)
		{
			RodzajStali = rodzajStali;
		}

    public override void Opis()
    {
			base.Opis();	
      Console.WriteLine($"To jest luska zrobiona ze stali: {RodzajStali}");
    }
	}
}