using System.ComponentModel.Design.Serialization;

internal class Program
{
	private static void Main(string[] args)
	{
		for (int i = 0; i < 21; i++)
		{
			Console.WriteLine("Suma liczba od 1 do {0} to {1}", i, SumDigits(i));
		}
	}

	static int SumDigits(int n)
	{
		int sum = 0;
		for (int i = 0; i <= n; i++)
		{
			sum += i;
		}
		return sum;
	}
}
