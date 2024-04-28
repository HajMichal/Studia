using System.ComponentModel.Design.Serialization;

internal class Program
{
	private static void Main(string[] args)
	{
		Console.WriteLine("n\tPotęga\t\tSilnia");
		for (int n = 0; n < 20; n++)
		{
			Console.WriteLine($"{n}\t{Power(n, 2)}\t\t{Silnia(n)}");
		}

	}

	static long Silnia(int n)
	{
		if (n == 0)
			return 1;
		else
			return n * Silnia(n - 1);
	}
	static long Power(int n, int baseNumber)
	{
		if (n == 0)
			return 1;
		else
			return baseNumber * Power(n - 1, baseNumber);
	}
}


