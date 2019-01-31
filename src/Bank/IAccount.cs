namespace Bank
{
    /// <summary>
    /// Represents a bank account.
    /// </summary>
    public interface IAccount
    {
        /// <summary>
        /// Gets the account type.
        /// </summary>
        string AccountType { get; }

        /// <summary>
        /// Gets the account balance.
        /// </summary>
        decimal Balance { get; }

        /// <summary>
        /// Transfers ammount to specified account.
        /// </summary>
        /// <param name="amount">The amount to transfer.</param>
        /// <param name="toAccount">The recipient account.</param>
        /// <example>
        /// <code>
        /// var fromAccount = new DebitAccount(1m);
        /// var toAccount = new DebitAccount(1m);
        /// fromAccount.Transfer(2m, toAccount);
        /// </code>
        /// </example>
        void Transfer(decimal amount, IAccount toAccount);
    }
}