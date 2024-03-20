namespace LGT.Geolis.Geoldba;
[Table(name: "TYRIMAI", Schema = "GEOLDBA")]
public class Tyrimas
{
  public ICollection<Telkinys_Tyrimas>? TelkiniuAssignments { get; set; }

  [Key][Column("TYR_SUTR")] public string ID { get; set; } = default!;  // Tyrimo pavadinimo sutrumpinimas, pirminis raktas
	[Column("TYR_PAV")] public string Name { get; set; } = default!;  // Tyrimo pavadinimas
	[Column("TYR_DATA_IKI")] public DateTime? Until { get; set; }  // Nurodyti nuo kada negalima naudoti (įvesti) tyrimo pavadinimo
}
