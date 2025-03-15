namespace OOP.Encapsulation;

public class BankAccountService
{
    private decimal balance;

    public BankAccountService(decimal balance)
    {
        Deposit(balance);
    }

    public decimal GetBalance()
    {
        return balance;
    }

    public void Deposit(decimal ammount)
    {
        if (ammount <= 0)
        {
            throw new ArgumentException("Deposit must be positive.");
        }
        this.balance += ammount;
    }
    public void Withdraw(decimal ammount)
    {
        if (ammount <= 0) 
        {
            throw new ArgumentException("Withdraw must be positive.");
        }
        if (ammount > balance) { 
        }
    }
}