namespace Bank.Exceptions
{
    /// <summary>
    /// Represents account amount releated errors.
    /// </summary>
    public class AccountAmountException : System.Exception
    {
        /// <summary>
        /// Gets the amount that caused the error.
        /// </summary>
        public decimal Amount { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountAmountException"/> class.
        /// </summary>
        /// <param name="amount">The amount that caused the error.</param>
        /// <param name="message">The message that describes the error.</param>
        public AccountAmountException(decimal amount, string message)
            : base(message) => Amount = amount;
    }
}
