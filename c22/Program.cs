using System;

public class ds
{
    public static void Main(String[] args)
    {

    }

    public delegate mesal1 tabemesal1(mesal1 a);


    public int tabe1(mesal1 a)
    {
        return a.x*a.x;
    }


}


public struct mesal1
{
    public int x=0;
    public int y=0;

    public mesal1(int x, int y)
    {
        ds s=new ds(); 
        this.x=x;
        this.y=y;
        Func<int,int> x5= (int x2)=>
        {
            s.GetType();
            return (int)(x2);
        };
    }
}


