using System.ComponentModel.Design.Serialization;

internal class Program
{
	private static void Main(string[] args)
	{
		Console.Write("Podaj tekst 1: ");
		string text1 = Console.ReadLine()!;
		Console.Write("Podaj tekst 2: ");
		string text2 = Console.ReadLine()!;
		Console.Write("Podaj tekst 3: ");
		string text3 = Console.ReadLine()!;
		Console.Write("Podaj tekst 4: ");
		string text4 = Console.ReadLine()!;
		Console.Write("Podaj tekst 5: ");
		string text5 = Console.ReadLine()!;

		string longestText = FindLongestText(text1, text2, text3, text4, text5);
		Console.WriteLine("Najdłuszy tekst to: " + longestText);
	}

	static string FindLongestText(params string[] texts)
	{
		return texts.MaxBy(text => text.Length);
	}
}
