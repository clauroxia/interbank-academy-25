public static class TransactionService
{
    public static decimal CalculateFinalBalance(List<Transaction> transactions)
    {   
        // Sum of credit transactions
        decimal creditSum = transactions
            .Where(t => t.Type?.Trim().Equals("Crédito", StringComparison.OrdinalIgnoreCase) == true)
            .Sum(t => t.Amount);

        // Sum of debit transactions
        decimal debitSum = transactions
            .Where(t => t.Type?.Trim().Equals("Débito", StringComparison.OrdinalIgnoreCase) == true)
            .Sum(t => t.Amount);

        return creditSum - debitSum;
    }

    public static Transaction? GetHighestTransaction(List<Transaction> transactions)
    {
        return transactions.OrderByDescending(t => t.Amount).FirstOrDefault();
    }

    public static (int creditCount, int debitCount) GetTransactionCount(List<Transaction> transactions)
    {
        // Number of credit transactions
        int creditCount = transactions
            .Count(t => t.Type?.Trim().Equals("Crédito", StringComparison.OrdinalIgnoreCase) == true);

        int debitCount = transactions
            .Count(t => t.Type?.Trim().Equals("Débito", StringComparison.OrdinalIgnoreCase) == true);

        // Number of debit transactions
        return (creditCount, debitCount);
    }
}