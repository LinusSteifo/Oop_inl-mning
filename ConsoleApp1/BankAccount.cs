public class BankAccount
{
    public string Owner;
    public double Balance;

    public void ShowInfo()
    {
        Console.WriteLine($"{Owner} har {Balance} kr");
    }
}