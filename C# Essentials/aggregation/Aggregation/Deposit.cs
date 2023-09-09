namespace Aggregation
{
    public abstract class Deposit
    {
        public decimal Amount { get; set; }
        public int Period { get; set; }

        public Deposit(decimal depositAmount, int depositPeriod)
        {
            Amount = depositAmount;
            Period = depositPeriod;
        }

        public abstract decimal Income();
    }
}