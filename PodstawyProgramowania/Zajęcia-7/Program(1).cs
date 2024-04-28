using System.ComponentModel.Design.Serialization;

internal class Program
{
	private static void Main(string[] args)
	{
		Console.WriteLine("Podaj gęstość zaludnienia w miescie A: ");
		double cityA = double.Parse(Console.ReadLine()!);
		Console.WriteLine("Podaj gęstość zaludnienia w miescie B: ");
		double cityB = double.Parse(Console.ReadLine()!);

		Console.WriteLine("Średnia gęstość zaludnienia to: " + CityPopulation(cityA, cityB) + " os/km^2");
	}

	static double CityPopulation(double cityA, double cityB)
	{
		return 2 / ((1 / cityA) + (1 / cityB));
	}
}
