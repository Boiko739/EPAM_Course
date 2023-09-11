namespace Interfaces
{
    public class BaseDeposit : Deposit
    {
        public BaseDeposit(decimal depositAmount, int depositPeriod) : base(depositAmount, depositPeriod) { }

        public override decimal Income()
        {
            int percentsPerMonth = 5;
            decimal totalAmount = Amount;
            for (int i = 0; i < Period; i++)
            {
                totalAmount += totalAmount * percentsPerMonth / 100;
            }

            return totalAmount - Amount;
        }
    }
}
