namespace PoliGame;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player("Michal", 10);
        Sword sword = new Sword("Infiniti Edge", 90.0, 15, true, false, 0, 0);

        player.Opis();
        sword.Description();
    }
}
