namespace s27;

public class rangavazkon : IDisposable
{
    private ConsoleColor rang {get;set;}
    public rangavazkon (ConsoleColor a)
    {
        rang = Console.ForegroundColor;
        Console.ForegroundColor=a;
    }

    public void Dispose()
    {
        Console.ForegroundColor=rang;
    }
}

public class hesab
{
    public string holder {get;set;}
    public double balance {get; private set;}
    public delegate void karbanki(string s);
    public karbanki _karbanki{get;set;}
    public hesab(string _holder, double _balance , karbanki reporter = null)
    {
        holder = _holder;
        balance = _balance;
        if(reporter != null)
            _karbanki=reporter;
    }

    public bool withdraw(double amount)
    {
        if(balance>=amount)
        {
            balance-=amount;
            using rangavazkon a = new rangavazkon(ConsoleColor.Red);
            var msg = $"bardasht az hesab : {amount} \nmande hesab : {balance}";
            _karbanki?.Invoke(msg);
            return true;
        }
        using rangavazkon b = new rangavazkon(ConsoleColor.Gray);
            var msg2 = "mojoodi hesab kafi nist";
        _karbanki?.Invoke(msg2);
        return false;
    }

    public void deposit(double amount)
    {
        balance+=amount;
        using rangavazkon a = new rangavazkon(ConsoleColor.Green);
        System.Console.WriteLine($"variz be hesab : {amount} \nmojoodi feeli : {balance}");
    }
}
