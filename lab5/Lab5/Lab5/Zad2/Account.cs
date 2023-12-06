namespace Lab5.Zad2
{
    public class Account
    {
        public List<Transactions> Transactions { get; set; } = new List<Transactions>();

        public static double Income {get; set;}
        public static double Expense { get; set;}

        public void DisplaySummary()
        {
            Console.WriteLine($"Uznanie rachunku: {Income}; obciążenie: {Expense}.");
        }

        public void Add(Transactions transaction)
        {
            Transactions.Add(transaction);
            transaction.ProcessTransaction();
        }
    }
}
