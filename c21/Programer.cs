namespace S21;

class Program
{
    public delegate int Calculation(int a, int b);

    public static int Sum(int x, int y)=> x+y;
    public static int Subtract(int x, int y)=>x-y;
    public static int Multiply(int x, int y)=>x*y;

    public static int[] Apply(int[] x, int[] y, Calculation op)
    {
        int[] result = new int[x.Length];
        for (int i = 0;i<x.Length;i++)
        {
            result[i] = op(x[i], y[i]);
        }
        return result;
    }

    public static int[] Apply2(int[] x, int[]y, Ioperation op)
    {
        int[] result = new int[x.Length];
        for (int i = 0;i<x.Length;i++)
        {
            result[i] = op.Operator(x[i], y[i]);
        }
        return result;
    }

    static void Main(string[] args)
    {
        int[] q = new int[5]{1,2,3,4,5};
        int[] p = new int[5]{2,4,6,8,10};

        int[] r = Apply(q,p,Sum);
        int[] e = Apply(q,p,Subtract);
        int[] m = Apply(q,p,Multiply);


        int[] r2 = Apply2(q,p, new SumOp());
        int[] e2 = Apply2(q,p, new SubtractOp());
        int[] m2 = Apply2(q,p,new MultiplyOp());


        Console.WriteLine("Hello, World!");
    }
}
