public class SavingsAccount : BankAccount
{
    public double InterestRate;

    public SavingsAccount(string owner, double balance, double rate)
        : base(owner, balance)
    {
        InterestRate = rate;
    }

    public void AddInterest() => Deposit(GetBalanceForInterest() * InterestRate);

    private double GetBalanceForInterest() => 1000;
}
