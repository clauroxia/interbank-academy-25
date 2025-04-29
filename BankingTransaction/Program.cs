class Program
{
  static void Main(string[] args)
  {
    bool exit = false;
    string? userAnswer;
    while (!exit)
    {
      Console.WriteLine("\nProcesamiento de Transacciones Bancarias");
      Console.WriteLine("Menu:");
      Console.WriteLine("1. See Final Balance");
      Console.WriteLine("2. Get Higher Value Transaction");
      Console.WriteLine("3. Get Transaction Count");
      Console.WriteLine("4. See Transaction Report");
      Console.WriteLine("5. Exit");
      Console.Write("Please write an option: ");
      userAnswer = Console.ReadLine();

      switch (userAnswer)
      {
        case "1":
          Console.WriteLine("See Final Balance");
          break;
        case "2":
          Console.WriteLine("Get Higher Value Transaction");
          break;
        case "3":
          Console.WriteLine("Get Transaction Count");
          break;
        case "4":
          Console.WriteLine("See Transaction Report");
          break;
        case "5":
          Console.WriteLine("Good bye!");
          exit = true;
          break;
        default:
          Console.WriteLine("Please enter a valid option");
          break;
      }
    }
  }
}