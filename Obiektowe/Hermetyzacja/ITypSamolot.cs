namespace Hermetyzacja;

public interface ITypSamolot
{
	double Waga { get; set; }
	int IloscCylindryow { get; set; }
	int IloscSilnikow { get; set; }
	int IloscMiejsc { get; set; }

	TypUsterzenia TypUsterzenia { get; set; }
}
