namespace ConsoleApp
{
    public class Transaction
    {
        public decimal Amount { get;}
        public DateTime Date { get; }
        public string Notes { get; }

        public Transaction(decimal amount, DateTime date, string notes)
        {
            Amount = amount;
            Date = date;
            Notes = notes;
        }

        public void makeTransaction (decimal amount, DateTime date, string notes)
        {

        }
    }
}