using System;

namespace Interfaces
{
    public abstract class Deposit : IComparable<Deposit>
    {
        public decimal Amount { get; set; }
        public int Period { get; set; }

        public Deposit(decimal depositAmount, int depositPeriod)
        {
            Amount = depositAmount;
            Period = depositPeriod;
        }

        public abstract decimal Income();

        public int CompareTo(Deposit other)
        {
            var thisTotal = Amount + Income();
            var otherTotal = other.Amount + other.Income();
            var thisIsLessOrEqual = thisTotal > otherTotal ? 1 : 0;
            return thisTotal < otherTotal ? -1 : thisIsLessOrEqual;
        }

        private static bool OperatorIsNotNull(Deposit lhs, Deposit rhs)
        {
            return !(lhs is null) && !(rhs is null);
        }

        public static bool operator ==(Deposit lhs, Deposit rhs) => OperatorIsNotNull(lhs, rhs) && lhs.Equals(rhs);
        public static bool operator !=(Deposit lhs, Deposit rhs) => OperatorIsNotNull(lhs, rhs) && !lhs.Equals(rhs);
        public static bool operator <(Deposit lhs, Deposit rhs) => OperatorIsNotNull(lhs, rhs) && lhs.CompareTo(rhs) < 0;
        public static bool operator >(Deposit lhs, Deposit rhs) => OperatorIsNotNull(lhs, rhs) && lhs.CompareTo(rhs) > 0;
        public static bool operator <=(Deposit lhs, Deposit rhs) => OperatorIsNotNull(lhs, rhs) && lhs.CompareTo(rhs) <= 0;
        public static bool operator >=(Deposit lhs, Deposit rhs) => OperatorIsNotNull(lhs, rhs) && lhs.CompareTo(rhs) >= 0;

        public override bool Equals(object obj)
        {
            return obj is Deposit deposit &&
                   Amount + Income() == deposit.Amount + deposit.Income();
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Amount, Period, Income());
        }

        public override string ToString()
        {
            return $"Amount = {Amount}, Period = {Period}, Income = {Income()}";
        }
    }
}
