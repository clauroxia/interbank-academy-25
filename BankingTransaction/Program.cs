class Program
{
    public static List<Transaction> transactionList = Transaction.ReadCsvFile();
    static void Main(string[] args)
    {
        bool exit = false;
        string? userAnswer;
        while (!exit)
        {
            Console.WriteLine("\n******************************************");
            Console.WriteLine(" Procesamiento de Transacciones Bancarias ");
            Console.WriteLine("******************************************");
            Console.WriteLine("Menu:");
            Console.WriteLine("1. See Final Balance");
            Console.WriteLine("2. Get Highest Value Transaction");
            Console.WriteLine("3. Get Transaction Count");
            Console.WriteLine("4. See Transaction Report");
            Console.WriteLine("5. Exit");
            Console.Write("Please write an option: ");
            userAnswer = Console.ReadLine();

            switch (userAnswer)
            {
            case "1":
                GetFinalBalance();
                break;
            case "2":
                GetHighestValueTransaction();
                break;
            case "3":
                GetTransactionCount();
                break;
            case "4":
                GetFinalTransactionReport();
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

    public static void GetFinalBalance()
    {
        if (transactionList.Count == 0)
        {
            Console.WriteLine("No transactions found.");
            return;
        }

        decimal finalBalance = TransactionService.CalculateFinalBalance(transactionList);
        Console.WriteLine($"Final Balance: {finalBalance:F2}");
    }

    public static void GetHighestValueTransaction()
    {
        if (transactionList.Count == 0)
        {
            Console.WriteLine("No transactions found.");
            return;
        }

        var highestTransaction = TransactionService.GetHighestTransaction(transactionList);

        if (highestTransaction != null)
        {
            Console.WriteLine($"Highest Value Transaction: ID {highestTransaction.Id} - {highestTransaction.Amount:F2}");
        }
    }

    public static void GetTransactionCount()
    {
        if (transactionList.Count == 0)
        {
            Console.WriteLine("Credit: 0 Debit: 0");
            return;
        }

        var (credit, debit) = TransactionService.GetTransactionCount(transactionList);

        Console.WriteLine($"Transactions Count: {credit + debit}");
        Console.WriteLine($"Credit: {credit} Debit: {debit}");
    }

    public static void GetFinalTransactionReport()
    {
        if (transactionList.Count == 0)
        {
            Console.WriteLine("Credit: 0 Debit: 0");
            return;
        }

        var balance = TransactionService.CalculateFinalBalance(transactionList);
        var highestValue = TransactionService.GetHighestTransaction(transactionList);
        var (credit, debit) = TransactionService.GetTransactionCount(transactionList);

        Console.WriteLine("\nReporte de Transacciones");
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine($"Balance Final: {balance:F2}");
        Console.WriteLine($"Transacción de Mayor Monto: ID {highestValue?.Id} - {highestValue?.Amount:F2}");
        Console.WriteLine($"Conteo de Transacciones: Crédito: {credit} Débito: {debit}");
    }
}