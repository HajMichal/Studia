namespace Zbrojenie 
{
	public class Magazynek:Producent
	{
		protected string Model;

		public Magazynek (string nazwa, string adres, string nip, string model):base(nazwa, adres, nip)
		{
			Model = model;
		}
    public override void Opis()
    {
			base.Opis();
      Console.WriteLine($"To jest magazynek z {Model}.");
    }
	}

	// public interface IMagazynek
	// {
	// 	void Magazynek(string nazwa, string adres, string nip, int iloscKol, string rodzajStali, double kaliber);
	// 	void Opis();
	// }
}

//  klasy bazowe moga definiwowac i implementowac metody wirtualne
//  klasy pochodne moga je przesłonic, czyli nadpisac. Co oznacza ze 
//  zapewniaja własna implementacje tych metod.
// 
// W czasie wykonywania obiekty klasy pochodnej moga byc trkatowane 
// jak obiekty klasy bazowej w takich miejscach jak parametry metod i 
// koleklcje lub tablice.
// W tym przypadku zadeklarowany typ obiektu nie jest juz identyczny z 
// typem podczas czasu wykonania