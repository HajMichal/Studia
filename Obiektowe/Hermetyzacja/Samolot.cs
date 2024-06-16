namespace Hermetyzacja;

public class Samolot : ITypSamolot
{
	public double Waga { get; set; }
	public int IloscCylindryow { get; set; }
	public int IloscSilnikow { get; set; }
	public int IloscMiejsc { get; set; }
	public TypUsterzenia TypUsterzenia { get; set; }

	public Samolot(double waga, int iloscCylindryow, int iloscSilnikow, int iloscMiejsc, TypUsterzenia typUsterzenia)
	{
		Waga = waga;
		IloscCylindryow = iloscCylindryow;
		IloscSilnikow = iloscSilnikow;
		IloscMiejsc = iloscMiejsc;
		TypUsterzenia = typUsterzenia;
	}

	public void WyswietlDaneSamolotu()
	{
		NarysujSamolot();
		Console.WriteLine("Dane samolotu:");
		Console.WriteLine($"Waga: {Waga}");
		Console.WriteLine($"Ilość cylindrów: {IloscCylindryow}");
		Console.WriteLine($"Ilość silników: {IloscSilnikow}");
		Console.WriteLine($"Ilość miejsc: {IloscMiejsc}");
		Console.WriteLine($"Typ usterzenia: {TypUsterzenia}");
	}
	private void NarysujSamolot()
	{
		Console.WriteLine("       __|__");
		Console.WriteLine("--o--o--(_)--o--o--");
		Console.WriteLine("       / \\");
		Console.WriteLine("      /___\\");
		Console.WriteLine("     /_____\\");
		Console.WriteLine("    /       \\");
		Console.WriteLine("   /         \\");
	}

}
