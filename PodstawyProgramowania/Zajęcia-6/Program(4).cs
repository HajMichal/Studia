using System.ComponentModel.Design.Serialization;

internal class Program
{
	private static void Main(string[] args)
	{
		Console.WriteLine("Wprowadz swoj tekst");
		string x = Console.ReadLine()!;

		string[] words = x.Split(' ', StringSplitOptions.RemoveEmptyEntries);
		Console.WriteLine("Liczba słów w twoim tekście " + words.Length);
	}
}
