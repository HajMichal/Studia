namespace Zbrojenie
{
	public class Grot:Strzaly
	{

	private string TypGrotu;
	private double DlugoscGrotu;

	public Grot(string nazwa, string adres, string nip, string typGrotu, double dlugoscGrotu, string rodzajStrzaly, string model, double glebokosc ): base(nazwa, adres, nip, rodzajStrzaly, model, glebokosc)
	{
		DlugoscGrotu = dlugoscGrotu;
		TypGrotu = typGrotu;
	}

	public override void Opis()
	{
		base.Opis();
		Console.WriteLine($"Grot typu: {TypGrotu} o długośći {DlugoscGrotu} mm");
	}
	}
}