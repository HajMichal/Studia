namespace Zbrojenie 
{
	public class Luska:Pocisk
	{
		private string RodzajStali;

		public Luska(string nazwa, string adres, string nip, string rodzajStali) : base(nazwa, adres, nip)
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