namespace Zbrojenie 
{
	public abstract class Producent
	{
		private string Nazwa;
		private string Adres;
		private string Nip;

    public Producent(string nazwa, string adres, string nip)
    {
			Nazwa = nazwa;
			Adres = adres;
			Nip = nip;
    }

    public virtual void Opis()
    {
        Console.WriteLine($"Producent: \n Nazwa: {Nazwa} \n Adres: {Adres} \n NIP: {Nip}");
    }
	}
}