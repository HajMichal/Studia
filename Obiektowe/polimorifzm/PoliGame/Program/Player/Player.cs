namespace PoliGame;

class Player
{
	protected string? Name;
	protected int Lvl { get; set; }
	public Player(string name, int lvl)
	{
		Name = name;
		Lvl = lvl;
	}

	public void Opis()
	{
		Console.WriteLine($"Player: {Name} has {Lvl} level");
	}
}
