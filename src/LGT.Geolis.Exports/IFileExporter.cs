namespace LGT.Geolis.Exports;
public interface IFileExporter
{
  Task ToFile(string path);
  bool PrintPogress { get; set; }
  bool PrintData { get; set; }
  bool PrintDebug { get; set; }
}
