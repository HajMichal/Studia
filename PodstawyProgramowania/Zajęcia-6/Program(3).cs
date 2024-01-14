using System.ComponentModel.Design.Serialization;

internal class Program
{
	private static void Main(string[] args)
	{
		string x = "Cyryl Kwiecien         ul.Mokra 4            Tychy 40-321";

		string[] words = x.Split(' ', StringSplitOptions.RemoveEmptyEntries);
		Console.WriteLine(string.Join(' ', words));
	}
}
