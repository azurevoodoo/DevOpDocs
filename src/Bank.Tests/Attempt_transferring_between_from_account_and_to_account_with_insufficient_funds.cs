using System;
using Bank.Exceptions;
using Machine.Specifications;
using Machine.Specifications.Model;


namespace Bank.Tests
{
    [Subject(typeof(DebitAccount))]
    public class Attempt_transferring_between_from_account_and_to_account_with_insufficient_funds
    {
        static IAccount fromAccount;
        static IAccount toAccount;
        static Exception Exception;

        Establish context =
        () =>
        {
            fromAccount = new DebitAccount(1m);
            toAccount = new DebitAccount(1m);
        };

        Because of = () => Exception = Catch.Exception(()=> fromAccount.Transfer(2m, toAccount));

        It should_fail = () => Exception.ShouldBeOfExactType<InsufficientFundsException>();

        It should_have_a_specific_reason = () => Exception.Message.ShouldStartWith("Insufficient funds");

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
