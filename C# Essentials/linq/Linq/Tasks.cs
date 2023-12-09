using Linq.Objects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    public static class Tasks
    {
        //The implementation of your tasks should look like this:
        public static string TaskExample(IEnumerable<string> stringList)
        {
            return stringList.Aggregate((x, y) => x + y);
        }

        #region Low

        public static IEnumerable<string> Task1(char c, IEnumerable<string> stringList)
        {
            return stringList.Where(x =>
            x[0] == c &&
            x[^1] == c &&
            x.Length > 1);
        }

        public static IEnumerable<int> Task2(IEnumerable<string> stringList)
        {
            return stringList.Select(x => x.Length).OrderBy(x => x);
        }

        public static IEnumerable<string> Task3(IEnumerable<string> stringList)
        {
            return stringList.Select(x => $"{x[0]}{x[^1]}");
        }

        public static IEnumerable<string> Task4(int k, IEnumerable<string> stringList)
        {
            return stringList.Where(x =>
            x.Length == k &&
            char.IsDigit(x[^1])).
            OrderBy(x => x);
        }

        public static IEnumerable<string> Task5(IEnumerable<int> integerList)
        {
            return integerList.
                Where(x => x % 2 == 1).
                OrderBy(x => x).
                Select(x => x.ToString());
        }

        #endregion

        #region Middle

        public static IEnumerable<string> Task6(IEnumerable<int> numbers, IEnumerable<string> stringList)
        {
            return numbers.Select(n => stringList.
            FirstOrDefault(s => char.IsDigit(s[0]) && s.Length == n) ?? "Not found");
        }

        public static IEnumerable<int> Task7(int k, IEnumerable<int> integerList)
        {
            return integerList.Where(x => x % 2 == 0).Except(integerList.Skip(k)).Reverse();
        }

        public static IEnumerable<int> Task8(int k, int d, IEnumerable<int> integerList)
        {
            return integerList.TakeWhile(x => x <= d).Union(integerList.Skip(k)).
                OrderByDescending(x => x);
        }

        public static IEnumerable<string> Task9(IEnumerable<string> stringList)
        {
            return stringList.GroupBy(x => x[0]).
                OrderByDescending(x => x.Sum(x => x.Length)).
                ThenBy(x => x.Key).
                Select(x => $"{x.Sum(x => x.Length)}-{x.Key}");
        }

        public static IEnumerable<string> Task10(IEnumerable<string> stringList)
        {
            return stringList.GroupBy(word => word.Length).
                Select(group => group.OrderBy(word => word)).
                OrderBy(group => group.First(), StringComparer.Ordinal).
                Select(group => string.Concat(group.Select(word => char.ToUpperInvariant(word.Last())))).
                OrderByDescending(word => word.Length);
        }

        #endregion

        #region Advance

        public static IEnumerable<YearSchoolStat> Task11(IEnumerable<Entrant> nameList)
        {
            return nameList.GroupBy(entrant => entrant.Year).
                Select(group => new YearSchoolStat()
                {
                    Year = group.Key,
                    NumberOfSchools = group.GroupBy(entrant => entrant.SchoolNumber).
                        Select(schools => schools.Key).Count()
                }).
                OrderBy(stats => stats.NumberOfSchools).ThenBy(stats => stats.Year);
        }

        public static IEnumerable<NumberPair> Task12(IEnumerable<int> integerList1, IEnumerable<int> integerList2)
        {
            return integerList1.
                SelectMany(num1 => integerList2.Where(num2 => num1 % 10 == num2 % 10),
                (num1, num2) => new NumberPair() { Item1 = num1, Item2 = num2 }).
                OrderBy(pair => pair.Item1).ThenBy(pair => pair.Item2);
        }

        public static IEnumerable<YearSchoolStat> Task13(IEnumerable<Entrant> nameList, IEnumerable<int> yearList)
        {
            return yearList.Select(year => new YearSchoolStat()
            {
                Year = year,
                NumberOfSchools = nameList.Where(info => info.Year == year).GroupBy(info => info.SchoolNumber).Count()
            }).
            OrderBy(stat => stat.NumberOfSchools).ThenBy(stat => stat.Year);
        }

        public static IEnumerable<MaxDiscountOwner> Task14(IEnumerable<Supplier> supplierList,
                IEnumerable<SupplierDiscount> supplierDiscountList)
        {
            return supplierList.
            Join(supplierDiscountList, supplier => supplier.Id, discount => discount.SupplierId,
            (supplier, discount) => new { supplier, discount }).
            GroupBy(x => x.discount.ShopName).
            Select(group => new MaxDiscountOwner()
            {
                ShopName = group.Key,
                Owner = group.Where(x => x.discount.Discount == group.Max(x => x.discount.Discount)).
                    OrderBy(x => x.supplier.Id).First().supplier,
                Discount = group.Max(x => x.discount.Discount),
            }).OrderBy(owner => owner.ShopName);
        }

        public static IEnumerable<CountryStat> Task15(IEnumerable<Good> goodList,
            IEnumerable<StorePrice> storePriceList)
        {
            return goodList.GroupJoin(
             storePriceList, good => good.Id, price => price.GoodId,
             (good, prices) => new { Good = good, Prices = prices.DefaultIfEmpty() })
             .SelectMany(
             x => x.Prices,
             (x, price) => new { x.Good, Price = price }).
             GroupBy(x => x.Good.Country, x => x.Price,
             (key, g) => new CountryStat
             {
                 Country = key,
                 StoresNumber = g.Where(x => x != null).Select(x => x.Shop).Distinct().Count(),
                 MinPrice = g.Any(x => x != null) ? g.Min(x => x.Price) : 0
             }).
             OrderBy(x => x.Country);
        }

        #endregion

    }
}
