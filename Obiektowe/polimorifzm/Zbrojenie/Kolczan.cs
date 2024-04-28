namespace Zbrojenie 
{
	public class Kolczan:Producent
	{
		protected string Model;
		protected double Glebokosc;

		public Kolczan (string nazwa, string adres, string nip, string model, double glebokosc):base(nazwa, adres, nip)
		{
			Model = model;
			Glebokosc = glebokosc;
		}
    public override void Opis()
    {
			base.Opis();
      Console.WriteLine($"To jest kolczan z {Model}, glebokosc kolczanu: {Glebokosc}");
    }
	}
}