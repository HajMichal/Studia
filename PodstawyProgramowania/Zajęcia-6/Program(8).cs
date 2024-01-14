using System.ComponentModel.Design.Serialization;

internal class Program
{
	private static void Main(string[] args)
	{
		Console.WriteLine("Podaj pierwszy tekst: ");
		string firstText = Console.ReadLine()!;
		Console.WriteLine("Podaj drugi tekst: ");
		string secondText = Console.ReadLine()!;

		string output = "";

		char[] firstTextParts = firstText.ToCharArray();
		char[] secondTextParts = secondText.ToCharArray();

		for (int i = 0; i < firstText.Length - 1; i++)
		{
			if (firstTextParts[i] == secondTextParts[i])
			{
				output += firstTextParts[i];
			}
			else
			{
				output += "?";
			}
		}
		Console.WriteLine(output);
	}
}
