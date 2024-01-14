using System.ComponentModel.Design.Serialization;

internal class Program
{
	private static void Main(string[] args)
	{
		int x;
		Console.WriteLine("Podaj liczbę osób, dla których chcesz przechowywać dane:");
		x = int.Parse(Console.ReadLine()!);
		string[,] array2d = new string[x, 2];

		for (int i = 0; i < x; i++)
		{
			for (int j = 0; j < 2; j++)
			{
				Console.WriteLine(array2d[i, j]);
				if (j == 0)
				{
					Console.Write("Podaj pseudonim osoby {0}: ", i + 1);
					string name = Console.ReadLine()!;
					array2d[i, j] = name;

				}
				else
				{
					Console.Write("Podaj numer telefonu osoby {0}: ", i + 1);
					string phone = Console.ReadLine()!;
					array2d[i, j] = phone;
				}
			}
		}

		Console.WriteLine("Podaj nickname osoby, której numer telefonu chcesz znaleźć");
		string nameId = Console.ReadLine()!;

		Console.WriteLine("Numer telefonu do {0} to: {1}", nameId, FindPhoneNumber(array2d, nameId));
	}

	static string FindPhoneNumber(string[,] array2d, string name)
	{
		string phone = "";
		for (int i = 0; i < array2d.Length / 2; i++)
		{
			if (array2d[i, 0] == name)
			{
				phone = array2d[i, 1];
				break;
			}
			else
			{
				phone = "User not found";
			}
		}
		return phone;
	}
}
