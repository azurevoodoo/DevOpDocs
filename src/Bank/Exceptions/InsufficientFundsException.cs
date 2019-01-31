namespace Bank.Exceptions
{
    /// <summary>
    /// Represents account insufficient funds releated errors.
    /// </summary>
    public class InsufficientFundsException : AccountAmountException
    {
        /// <summary>
        /// Gets the balance at the time of the error.
        /// </summary>
        public decimal Balance { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="InsufficientFundsException"/> class.
        /// </summary>
        /// <param name="balance">The balance at the time of the error.</param>
        /// <param name="amount">The amount that caused the error.</param>
        public InsufficientFundsException(decimal balance, decimal amount)
            : base(amount, $"Insufficient funds, amount {amount} can't be withdrawn due to balance of {balance}.")
        {
        }
    }
}
