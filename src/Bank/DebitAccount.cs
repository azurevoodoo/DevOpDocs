using System;
using Bank.Exceptions;

namespace Bank
{

    /// <inheritdoc />
    public class DebitAccount : IAccount
    {
        private void Transfer(decimal amount, DebitAccount toAccount)
        {
            if (amount <= decimal.Zero)
            {
                throw new NegativeOrZeroAmountException(amount);
            }

            if (Balance < amount)
            {
                throw new InsufficientFundsException(Balance, amount);
            }

            Balance -= amount;
            toAccount.Balance += amount;
        }

        /// <inheritdoc />
        /// <remarks>
        /// Will return "Bank Debit Account" for <see cref="DebitAccount"/>.
        /// </remarks>
        public string AccountType => "Bank Debit Account";

        /// <inheritdoc />
        public decimal Balance { get; private set; }

        /// <inheritdoc />
        /// <exception cref="InsufficientFundsException"/>
        /// <exception cref="NegativeOrZeroAmountException"/>
        /// <exception cref="ArgumentOutOfRangeException"/>
        public void Transfer(decimal amount, IAccount toAccount)
        {
            switch (toAccount)
            {
                case DebitAccount account:
                    Transfer(amount, account);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(toAccount), $"Unkown account type {toAccount?.AccountType ?? "Null"}");
            }
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="DebitAccount"/> class.
        /// </summary>
        public DebitAccount(decimal balance) => Balance = balance;
    }
}
