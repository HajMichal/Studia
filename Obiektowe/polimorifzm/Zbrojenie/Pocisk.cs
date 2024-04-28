namespace Zbrojenie 
{
		public class Pocisk:Magazynek
	{
		private double Kaliber;

    public Pocisk(string nazwa, string adres, string nip, double kaliber,  string model):base(nazwa, adres, nip, model)
    {
        Kaliber = kaliber;
    }

    public override void Opis()
    {
        base.Opis();
        Console.WriteLine($"Jest to pocisk o kalibrze: {Kaliber}");
    }
	}
}