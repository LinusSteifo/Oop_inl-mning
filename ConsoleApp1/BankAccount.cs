public class BankAccount
{
    private string owner;
    private double balance;

    public BankAccount(string owner, double balance)
    {
        this.owner = owner;
        this.balance = balance;
    }

    public void Deposit(double amount) => balance += amount;

    public void Withdraw(double amount)
    {
        if (amount <= balance) balance -= amount;
        else Console.WriteLine("Inte tillräckligt med pengar");
    }

    public void ShowInfo() => Console.WriteLine($"{owner} har {balance} kr");
}