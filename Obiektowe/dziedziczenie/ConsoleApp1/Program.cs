using System.Net.Security;

namespace ProgramDziedziczeniaAuto
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Podaj markę pojazdu");
			string? markaPojazdu = Console.ReadLine();

			Console.WriteLine("Podaj moc w kW pojazdu");
			int mocKWPojazdu = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Podaj kategorię pojazdu");
			string? kategoriaPojazdu = Console.ReadLine();

			Console.WriteLine("Podaj wagę pojazdu");
			int wagaPojazdu = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Podaj pojemność silnika pojazdu");
			int pojemnoscSilnika = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Podaj kolor pojazdu");
			string? kolorPojazdu = Console.ReadLine();

			Console.WriteLine("Podaj ilość osi pojazdu");
			int iloscOsiPojazdu = Convert.ToInt32(Console.ReadLine());


			Auto auto = new Auto();

			auto.parametryAuto(mocKWPojazdu, markaPojazdu);
			auto.kategoriaPojazdu(kategoriaPojazdu);
			auto.parametrWaga(wagaPojazdu);
			auto.parametrPojemnosc(pojemnoscSilnika);
			auto.parametrKolor(kolorPojazdu);
			auto.parametrLiczbaOsi(iloscOsiPojazdu);
		}
	}
}