using System;
using Machine.Specifications;
using Machine.Specifications.Model;
using Bank.Exceptions;

namespace Bank.Tests
{
    [Subject(typeof(DebitAccount))]
    public class Attempt_transferring_negative_amount_between_from_account_and_to_account
    {
        static DebitAccount fromAccount;
        static DebitAccount toAccount;
        static Exception Exception;

        Establish context =
        () =>
        {
            fromAccount = new DebitAccount(1m);
            toAccount = new DebitAccount(1m);
        };

        Because of = () => Exception = Catch.Exception(() => fromAccount.Transfer(-1m, toAccount));

        It should_fail = () => Exception.ShouldBeOfExactType<NegativeOrZeroAmountException>();

        It should_have_a_specific_reason = () => Exception.Message.ShouldStartWith("Negative or zero amount");

        It should_not_debit_the_from_account_by_the_amount_transferred = () =>
        {
            fromAccount.Balance.ShouldEqual(1m);
        };

        It should_not_credit_the_to_account_by_the_amount_transferred = () =>
        {
            toAccount.Balance.ShouldEqual(1m);
        };
    }
}
