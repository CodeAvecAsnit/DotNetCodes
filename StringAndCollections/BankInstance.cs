namespace Lab1.Files.StringAndCollections;

public class BankInstance
{

    public int _userId { get; set; }
    public string stringUserName { get; set; }
    private long balance;

    public BankInstance(long balance)
    {
        this.balance = balance;
    }

    public void ShowBalance()
    {
        Console.WriteLine("The Balance of " +stringUserName +$"is {balance}");
    }

    public bool WithdrawMoney(int withDrawAmount)
    {
        if (withDrawAmount > balance)
        {
            throw new BalanceNotEnoughException(balance, withDrawAmount);
        }

        balance -= withDrawAmount;
        Console.WriteLine($"The Balance of {_userId} is {balance} after withdraw of {withDrawAmount}");

        return true;
    }

    
}
public class BalanceNotEnoughException(long currentBalance, int withdrawAmount) : Exception(
    $"Balance not enough. Current balance: {currentBalance}, attempted withdrawal: {withdrawAmount}")
{
    public long CurrentBalance { get; } = currentBalance;
    public int WithdrawAmount { get; } = withdrawAmount;
}

// Program.cs
// var bankUser = new BankInstance(5000)
// {
//     _userId = 45,
//     stringUserName = "John Pork"
// };
// try
// {
//     bankUser.WithdrawMoney(4000);
//     bankUser.WithdrawMoney(1500);
// }
// catch (BalanceNotEnoughException ex)
// {
//     Console.WriteLine(ex.Message);
// }
// catch (Exception ex)
// {
//     Console.WriteLine(ex.Message);
// }