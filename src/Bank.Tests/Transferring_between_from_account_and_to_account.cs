using Machine.Specifications;
using Machine.Specifications.Model;

namespace Bank.Tests
{
    [Subject(typeof(DebitAccount))]
    public class Transferring_between_from_account_and_to_account
    {
        static DebitAccount fromAccount;
        static DebitAccount toAccount;

        Establish context =
        () =>
        {
            fromAccount = new DebitAccount(1m);
            toAccount = new DebitAccount(1m);
        };

        Because of = () => fromAccount.Transfer(1m, toAccount);

        It should_debit_the_from_account_by_the_amount_transferred = () =>
        {
            fromAccount.Balance.ShouldEqual(0m);
        };

        It should_credit_the_to_account_by_the_amount_transferred = () =>
        {
            toAccount.Balance.ShouldEqual(2m);
        };
    }
}
