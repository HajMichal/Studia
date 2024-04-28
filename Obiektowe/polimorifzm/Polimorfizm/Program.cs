namespace polimorfizm
{
	internal class Program 
	{
			static void Main(string[] args)
			{
					Kwadrat kwadrat = new Kwadrat("MojKwadrat", 5);

					kwadrat.Opis();
					Console.WriteLine($"Pole: {kwadrat.Pole}");
			}
}
}