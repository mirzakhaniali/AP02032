public static class Extensions
{
    public static IEnumerable<int> To(this int a, int b)
    {
        List<int> k = new List<int>();
        for(int i = a; i <= b;i++)
            k.Add(i);
        return k;
    }

    public static int NextPrime(this int a)
    {
        int k = a +1 ;
        for(int i = a+1;!isPrime(i);i++)
            k++;
        return k ; 
    }

    public static bool isPrime(int a)
    {
        for(int i=2; i<a;i++)
        {
            if(a%i==0) 
                return false;
        }
        return true;
    }
}
