namespace Bank.Exceptions
{
    /// <summary>
    /// Represents account amount zero or below releated errors.
    /// </summary>
    public class NegativeOrZeroAmountException : AccountAmountException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NegativeOrZeroAmountException"/> class.
        /// </summary>
        /// <param name="amount">The amount that caused the error.</param>
        public NegativeOrZeroAmountException(decimal amount)
            : base(amount, $"Negative or zero amount {amount} not allowed.")
        {
        }
    }
}
