namespace Hermetyzacja;

class Program
{
    static void Main(string[] args)
    {
        Samolot samolot = new Samolot(5500, 20, 4, 10, TypUsterzenia.centropłat);
        samolot.WyswietlDaneSamolotu();
    }
}
