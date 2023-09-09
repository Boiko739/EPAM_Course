namespace InheritanceTask
{
    public class Company
    {
        private readonly Employee[] employees;
        public Company(Employee[] employees)
        {
            this.employees = employees;
        }

        public void GiveEverybodyBonus(decimal companyBonus)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i] is Manager manager)
                {
                    manager.SetBonus(companyBonus);
                }
                else if (employees[i] is SalesPerson sales)
                {
                    sales.SetBonus(companyBonus);
                }
                else
                {
                    employees[i].SetBonus(companyBonus);
                }
            }
        }

        public decimal TotalToPay()
        {
            decimal totalToPay = 0;
            for (int i = 0; i < employees.Length; i++)
            {
                totalToPay += employees[i].ToPay();
            }

            return totalToPay;
        }

        public string NameMaxSalary()
        {
            int ind = 0;
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i].ToPay() > employees[ind].ToPay())
                {
                    ind = i;
                }
            }

            return employees[ind].Name;
        }
    }
}
