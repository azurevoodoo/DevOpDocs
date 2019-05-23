using System;
namespace Bank.Extensions
{
    public static class AccountExtensions
    {
        /// <summary>
        /// Balances to string.
        /// </summary>
        /// <returns>The to string.</returns>
        /// <param name="account">Account.</param>
        public static string BalanceToString(this IAccount account)
            => FormattableString.Invariant($"{account?.Balance:C}");
    }
}
