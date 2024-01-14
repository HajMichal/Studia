using System.ComponentModel.Design.Serialization;

internal class Program
{
	private static void Main(string[] args)
	{
		Console.WriteLine("Podaj imię i naziwsko");
		string name = Console.ReadLine()!;
		Console.WriteLine("Podaj drugie imię");
		string secondName = Console.ReadLine()!;

		string[] nameParts = name.Split(' ');

		nameParts[1] = secondName + " " + nameParts[1];

		string modifiedName = string.Join(" ", nameParts);
		Console.WriteLine("Imię, drugię imię i nazwisko: " + modifiedName);
		string secondNameWithSurname = modifiedName.Replace(nameParts[0] + " ", "");
		Console.WriteLine("Drugię imie i naziwsko: " + secondNameWithSurname);
		string[] secondNameParts = secondNameWithSurname.Split(' ');
		Console.WriteLine("Inicjały: " + secondNameParts[0][0] + secondNameParts[1][0]);

	}
}
