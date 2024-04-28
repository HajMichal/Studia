internal class Program
{
	private static void Main(string[] args)
	{
		Stack<string> colors = new Stack<string>();
		Console.WriteLine("Wprowadź oceny cząstkowe");
		do
		{
			Console.WriteLine("Podaj ulubiony kolor, jezeli chcesz skonczyc wcisnij ENTER");
			string color = Console.ReadLine()!;
			if (color == "") break;
			colors.Push(color);
		} while (true);
		Console.WriteLine(colors.Last() + " " + colors.First());
	}

}

