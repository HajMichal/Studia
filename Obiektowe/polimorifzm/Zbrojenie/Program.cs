namespace Zbrojenie 
{
	class Program
{
    static void Main()
    {
			Random random = new Random();

			Srut srut = new Srut("KorpoZbroja", "Bielsko-Biala", "8712387123", random.Next(1, 51),  "Nierdzewna", 6.2, "GG-WP-model");	
			Grot grot = new Grot("SzybkaStrzala", "Gdańsk", "109723233", "Paraboliczny", 19.3, "Balistyczna", "GL-HF-model", 58.0);

			srut.Opis();
			grot.Opis();
    }
}
}