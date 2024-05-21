public class program
{
    public static void Main(String[] args)
    {
        
        string[] a = { "ali", "amir",};
        System.Console.WriteLine($"{methods.sum(a,methods.stadd)}");
    }
}

public class methods
{
    public delegate t addfn<t> (t a , t b);

    public static int iadd(int a , int b)
    {
        return a + b;
    }

    public static string stadd(string a , string b)
    {
        return a + b;
    }

    public static int sum(IEnumerable<int> a , addfn<int> f)
    {
        int sumi = 0;
        foreach(int t in a)
        {
            sumi=f(t , sumi);
        }
        return sumi;
    }

    public static string sum(IEnumerable<string> a , addfn<string> f)
    {
        string sumi = "";
        foreach(string t in a)
        {
            sumi=f(t , sumi);
        }
        return sumi;
    }



}