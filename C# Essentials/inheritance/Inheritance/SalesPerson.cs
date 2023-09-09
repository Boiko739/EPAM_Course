namespace InheritanceTask
{
    public class SalesPerson : Employee
    {
        private readonly int percent;
        public SalesPerson(string name, decimal salary, int percent) : base(name, salary)
        {
            this.percent = percent;
        }

        public override void SetBonus(decimal bonus)
        {
            int multiplier = 1;
            if (percent > 100)
            {
                multiplier = percent <= 200 ? 2 : 3;
            }
            base.SetBonus(bonus * multiplier);
        }
    }
}
