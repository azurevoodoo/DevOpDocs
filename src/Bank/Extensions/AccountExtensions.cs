using System;
namespace Bank.Extensions
{
    public static class AccountExtensions
    {
        public static string BalanceToString(this IAccount account)
            => FormattableString.Invariant($"{account?.Balance:C}");
    }
}
