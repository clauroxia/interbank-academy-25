using CsvHelper.Configuration.Attributes;
using CsvHelper;
using System.Globalization;

public class Transaction
{ 
  [Name("id")]
  public int Id {get; set;}

  [Name("tipo")]
  public string? Type {get; set;}

  [Name("monto")]
  public decimal Amount {get; set;}

  public static List<Transaction> ReadCsvFile()
  {
    using var reader = new StreamReader("../data.csv");

    try
    { 
        // Deserialize .csv file
        using var csvFile = new CsvReader(reader, CultureInfo.InvariantCulture);
        var records = csvFile.GetRecords<Transaction>().ToList();
        return records;
    }
    catch (FileNotFoundException)
    {
        Console.WriteLine("CSV file not found.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error reading CSV file: {ex.Message}");
    }
    return new List<Transaction>();
  }
}