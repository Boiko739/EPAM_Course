namespace Aggregation
{
    public class Client
    {
        private readonly Deposit[] deposits;

        public Client()
        {
            deposits = new Deposit[10];
        }

        public bool AddDeposit(Deposit deposit)
        {
            for (int i = 0; i < deposits.Length; i++)
            {
                if (deposits[i] == null)
                {
                    deposits[i] = deposit;
                    return true;
                }
            }

            return false;
        }

        public decimal TotalIncome()
        {
            decimal total = 0;

            for (int i = 0; i < deposits.Length; i++)
            {
                if (deposits[i] is null)
                {
                    break;
                }
                else
                {
                    total += deposits[i].Income();
                }
            }

            return total;
        }

        public decimal MaxIncome()
        {
            decimal maxIncome = 0;

            foreach (Deposit deposit in deposits)
            {
                if (deposit is null)
                {
                    break;
                }
                else if (deposit.Income() > maxIncome)
                {
                    maxIncome = deposit.Income();
                }
            }

            return maxIncome;
        }

        public decimal GetIncomeByNumber(int number)
        {
            return deposits[number - 1] == null ? 0 : deposits[number - 1].Income();
        }
    }
}