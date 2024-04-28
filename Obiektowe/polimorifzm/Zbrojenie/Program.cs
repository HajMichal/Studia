namespace Zbrojenie 
{
	class Program
{
    static void Main()
    {
			Random random = new Random();
			// Kolczan kolczan = new Kolczan();
			Magazynek magazynek = new Magazynek("KorpoZbroja", "Bielsko-Biala", "8712387123", random.Next(1, 51),  "Nierdzewna", 6.2, "GG-WP-model");	

			magazynek.Opis();
				// Pocisk pocisk = new Pocisk("Rozpruwacz", 6.2);
				// Srut srut = new Srut("Nowoczesnt srut", "Pojedynczy");
				// Luska luska = new Luska("Hartowana", "Nierdzewna");

				// Grot grot = new Grot("kolczanMaster", 30, "balistyczna", "Włókno węglowe");

        // pocisk.Opis();
        // luska.Opis();
				// srut.Opis();
				// grot.Opis();
    }
}
}