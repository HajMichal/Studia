namespace Zbrojenie 
{
	public class Srut:Luska
	{
		private int IloscKol;

		public Srut(string nazwa, string adres, string nip, int iloscKol, string rodzajStali, double kaliber,  string model) : base(nazwa, adres, nip, rodzajStali, kaliber, model)
		{
			IloscKol = iloscKol;
		}

    public override void Opis()
    {
			base.Opis();
      Console.WriteLine($"Liczba kól wynsoi {IloscKol}");	
    }
	}
}