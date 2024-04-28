namespace polimorfizm
{
	public class Figura
	{
			public virtual void Opis()
			{
					Console.WriteLine("To jest figura.");
			}

			public abstract double Pole();

			public virtual void Opis()
			{
				Console.WriteLine($"To jest figura o polu:");
			}

	}
}