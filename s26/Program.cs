using System.ComponentModel;

public class  prgram
{
    public static void Main()
    {
        Thread t = new Thread(() => 
        {
            while (true)
            {
                meal1.a+=1;
                System.Console.WriteLine(meal1.a.ToString());
            }
        });
        Thread k = new Thread(() =>
        {
            while(true)
                System.Console.WriteLine("hay");
        });
        t.Start();
        k.Start();;
        while(true)
            System.Console.WriteLine("hello");
        double tabe(int a , int b) 
        {
            return 1.2;
        }
        
    }
    public delegate double tavbe(int a , int b);

    public tavbe? tabeha {get; set;}
}

public class meal1
{
    public static int a=10;
    public void mamadreza(int a , Func<int , int , double> fn)
    {
        double chishod = fn(a,2);
    }
}

public class meal2
{
    static meal2()
    {
        
    }
    public static int a=meal1.a;
    public meal1 s=new meal1();
}



public class meal3
{
    public static int a=30;

    public void chishid()
    {
        meal2.a=a;
    }
}