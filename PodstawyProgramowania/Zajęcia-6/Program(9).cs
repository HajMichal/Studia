using System.ComponentModel.Design.Serialization;

internal class Program
{
	private static void Main(string[] args)
	{
		Console.WriteLine("Podaj tekst: ");
		string text = Console.ReadLine()!;
		char[] firstTextParts = text.ToCharArray();
		Console.WriteLine(String.Join(" ", firstTextParts));
	}
}
