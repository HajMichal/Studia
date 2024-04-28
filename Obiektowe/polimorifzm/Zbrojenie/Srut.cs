namespace Zbrojenie 
{
	public class Srut:Luska
	{
		private int IloscKol;

		public Srut(string nazwa, string adres, string nip, int iloscKol, string rodzajStali):base(nazwa, adres, nip)
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