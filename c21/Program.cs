
using System.Numerics;
using Microsoft.VisualBasic;

public class sarklas
{
    public delegate t methodi<t>(t x , t y) where t : INumber<t>;
    public static t jam<t>(t a , t b) where t : INumber<t>
    {
        return a+b;
    }
    public static t kam<t>(t a, t b) where t : INumber<t> 
    {
        return a-b;
    }
    public static void Main(String[] args)
    {
        System.Console.WriteLine();
        
    }

    // public static t[] apply<t>(t[] x, t[] y,sumop<t> op)
    // {
    //     int[] result = new int[x.Length];
    //     for (int i = 0;i<x.Length;i++)
    //     {
    //         result[i] = op(x[i], y[i]);
    //     }
    //     return result;
    // }

    Tuple<int> a = 

    var a = Tuple.Create("ali" , 2); 

    var b = Tuple.Create("reza",7);
}


