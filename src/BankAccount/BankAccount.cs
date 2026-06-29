namespace Banking;

public class BankAccount
{
    private decimal _balance;

    public BankAccount(decimal openingBalance = 0m)
    {
        if (openingBalance < 0m)
            throw new ArgumentException("Opening balance cannot be negative.", nameof(openingBalance));

        _balance = openingBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0m)
            throw new ArgumentException("Deposit amount must be greater than zero.", nameof(amount));

        _balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0m)
            throw new ArgumentException("Withdrawal amount must be greater than zero.", nameof(amount));

        if (amount > _balance)
            throw new InvalidOperationException("Insufficient funds: cannot withdraw more than the current balance.");

        _balance -= amount;
    }

    public decimal GetBalance() => _balance;
}
