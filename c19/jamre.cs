public class re 
{
    public int sum(int a)
    {
        if(a==1)
            return 1;
        return a + sum(a-1);
    }

    public int fibo(int a)
    {
        if(a<2)
            return a;
        return fibo(a-1)+fibo(a-2);
    }
}
    