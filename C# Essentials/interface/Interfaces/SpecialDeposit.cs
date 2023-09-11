namespace Interfaces
{
    public class SpecialDeposit : Deposit, IProlongable
    {
        public SpecialDeposit(decimal depositAmount, int depositPeriod) : base(depositAmount, depositPeriod) { }

        public bool CanToProlong()
        {
            return Amount > 1000;
        }

        public override decimal Income()
        {
            int percentsForTheMonth = 1;
            decimal totalAmount = Amount;
            for (int i = 0; i < Period; i++)
            {
                totalAmount += totalAmount * percentsForTheMonth / 100;
                percentsForTheMonth++;
            }

            return totalAmount - Amount;
        }
    }
}
