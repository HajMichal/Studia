internal class Program
{
	private static void Main(string[] args)
	{
		// Program 1
		Console.WriteLine("Podaj imię");
		string userName = Console.ReadLine();
		Console.WriteLine("Witaj " + userName);
		Console.ReadKey();

		//  Program 2
		Console.WriteLine("Podaj liczbę");
		double firstNumber = double.Parse(Console.ReadLine());
		Console.WriteLine("Podaj liczbę");
		double secondNumber = double.Parse(Console.ReadLine());
		Console.WriteLine((firstNumber + secondNumber) / 2);
		Console.ReadKey();

		// Program 3 i 4
		Console.WriteLine("Podaj a");
		double a = double.Parse(Console.ReadLine());
		Console.WriteLine("Podaj b");
		double b = double.Parse(Console.ReadLine());
		Console.WriteLine("Podaj c");
		double c = double.Parse(Console.ReadLine());

		// Program 3
		if (a > b)
			if (a > c)
				Console.WriteLine("Największa " + a);
			else
				Console.WriteLine("Największa " + c);
		else if (b > c)

			if (b > a)
				Console.WriteLine("Największa " + b);
			else
				Console.WriteLine("Największa " + a);
		else if (c > a)
			if (c > b)
				Console.WriteLine("Największa " + c);
			else
				Console.WriteLine("Największa " + b);

		// Program 4
		if (a > b & a > c)
			Console.WriteLine("Największa " + a);
		else if (b > a & b > c)
			Console.WriteLine("Największa " + b);
		else if (c > a & c > b)
			Console.WriteLine("Największa " + c);



		// Program 5
		Console.WriteLine("Podaj a");
		double aa = double.Parse(Console.ReadLine());
		Console.WriteLine("Podaj b");
		double bb = double.Parse(Console.ReadLine());
		Console.WriteLine("Podaj c");
		double cc = double.Parse(Console.ReadLine());
		double delta = (b * b) - 4 * a * c;
		if (delta > 0)
		{
			double x1 = ((-bb) + delta) / (2 * aa);
			double x2 = ((-bb) - delta) / (2 * aa);
			Console.WriteLine("Delta ma 2 rozwiązania x1: " + x1 + ", x2: " + x2);
		}
		else if (delta < 0)
			Console.WriteLine("Brak rozwiązań dla ujemnej delty");
		else if (delta == 0)
		{
			double x1 = (-bb) / 2 * aa;
			Console.WriteLine("Delta ma 1 rozwiązanie: " + x1);
		}
	}
}