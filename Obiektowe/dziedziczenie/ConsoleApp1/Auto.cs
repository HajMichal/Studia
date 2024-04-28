namespace ProgramDziedziczeniaAuto
{
	public class Auto : IWaga, IKategoria, IKolor, ILiczbaOsi, IPojemnosc
	{
		public void parametryAuto(double opisMocKw, string? opisMarkaPojazdu)
		{
			Console.WriteLine($"Marka pojazdu to: {opisMarkaPojazdu}");
			Console.WriteLine($"Moc w kW to: {opisMocKw}");
		}
		public void kategoriaPojazdu(string? kategoriaPojazdu)
		{
			Console.WriteLine($"Kategoria pojazdu to: {kategoriaPojazdu}");
		}
		public void parametrKolor(string? kolor)
		{
			Console.WriteLine($"Kolor pojazdu to: {kolor}");
		}
		public void parametrLiczbaOsi(int liczbaOsi)
		{
			Console.WriteLine($"Liczba osi pojazdu to: {liczbaOsi}");
		}
		public void parametrPojemnosc(int pojemnoscSilnika)
		{
			Console.WriteLine($"Pojemność silnika pojazdu to: {pojemnoscSilnika}");
		}
		public void parametrWaga(int wagaPojazdu)
		{
			Console.WriteLine($"Waga pojazdu to: {wagaPojazdu}");
		}
	}
}