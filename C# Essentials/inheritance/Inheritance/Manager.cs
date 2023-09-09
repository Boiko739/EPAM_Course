namespace InheritanceTask
{
    public class Manager : Employee
    {
        private readonly int quantity;
        public Manager(string name, decimal salary, int clientAmount) : base(name, salary)
        {
            quantity = clientAmount;
        }

        public override void SetBonus(decimal bonus)
        {
            decimal extra = 0;
            if (quantity > 100)
            {
                extra = (quantity > 150 ? 1000 : 500);
            }
            base.SetBonus(bonus + extra);
        }
    }
}

