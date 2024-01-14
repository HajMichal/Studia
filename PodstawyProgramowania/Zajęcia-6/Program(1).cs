using System.ComponentModel.Design.Serialization;

internal class Program
{
	private static void Main(string[] args)
	{
		string x;
		int decimalNum = 0;
		do
		{
			Console.WriteLine("Wybierz liczbe binarną");
			x = Console.ReadLine()!;
			decimalNum = BinaryToDecimal(x);
		}
		while (CheckBinaryDigits(x));

		Console.WriteLine(decimalNum);
	}


	static bool CheckBinaryDigits(string givenNum)
	{

		foreach (char digit in givenNum)
		{
			if (digit != '0' && digit != '1')
			{
				return true;
			}
		}

		return false;
	}

	static int BinaryToDecimal(string binary)
	{
		int decimalNumber = 0, power = 0;

		for (int i = binary.Length - 1; i >= 0; i--)
		{
			if (binary[i] == '1')
			{
				decimalNumber += (int)Math.Pow(2, power);

			}
			power++;
		}
		return decimalNumber;
	}
}
