namespace Aggregation
{
    public class LongDeposit : Deposit
    {
        public LongDeposit(decimal depositAmount, int depositPeriod) : base(depositAmount, depositPeriod) { }

        public override decimal Income()
        {
            int MothsToWait = 6;
            int percentsAfterSomePeriod = 15;
            decimal totalAmount = Amount;
            for (int i = 0; i < Period; i++)
            {
                totalAmount += i < MothsToWait ? 0 : (totalAmount * percentsAfterSomePeriod) / 100;
            }

            return totalAmount - Amount;
        }
    }
}