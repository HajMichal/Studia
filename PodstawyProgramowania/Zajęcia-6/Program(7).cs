using System.ComponentModel.Design.Serialization;

internal class Program
{
	private static void Main(string[] args)
	{
		string[] products = {"KlAB-2021-12-25-klej",
"FaZXXX-2022-11-23-farba",
"TaBEWYT-2023-01-13-tapeta"};

		foreach (string product in products)
		{
			string[] splittedProd = product.Split('-');
			Array.Reverse(splittedProd);

			splittedProd = splittedProd.Skip(1).Take(splittedProd.Length - 2).ToArray();
			Console.WriteLine(product + " --> " + string.Join("-", splittedProd));
		}
	}
}
