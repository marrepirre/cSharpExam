namespace LeaugeTable.Services;

public class FileService
{
    private static readonly string _filePath = "C:\\Nackademin\\Leauge.json";
    public static async Task SaveToFileAsync(string content)
    {
        if (!File.Exists(_filePath))
        {
            using StreamWriter sw = new StreamWriter(_filePath);
            await sw.WriteAsync(content)!;
            Console.WriteLine("Fil Sparad, tryck på knapp för att gå vidare");
        }
        else
        {
            using StreamWriter sw = File.AppendText(_filePath);
            await sw.WriteAsync(content);
            Console.WriteLine("Ny klubb sparad i listan, tryck på knapp för att gå vidare");
        }
    }
}
