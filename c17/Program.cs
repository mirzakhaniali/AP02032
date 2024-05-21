using System.Security.Cryptography.X509Certificates;

public class aini
{
    public static void Main(String[] args)
    {
        int[][] b=new int[3][];
        b[0]=new int[1];
        b[1]=new int[3];
        b[2] = new int[2];
        for(int i=0;i<b.Length;i++)
        {
            for(int j=0;j<b[i].Length;j++)
            {
                System.Console.Write(b[i][j]);
            }
            System.Console.WriteLine();
        }
        am a=new am();
        int q=a+1;
        System.Console.WriteLine(q);

        complex me=new complex(2,3);
        complex ma=new complex(5,1);
        complex sa=new complex(6,2);
        sa=ma+me;
        System.Console.WriteLine($"{sa.x} , {sa.y}");
        sa=ma-me;
        System.Console.WriteLine($"{sa.x} , {sa.y}");
        sa=-ma;
        System.Console.WriteLine($"{sa.x} , {sa.y}");
        sa=+ ma;
        System.Console.WriteLine($"{sa.x} , {sa.y}");
        int sao=sa[false];
        System.Console.WriteLine(sao);
        string saom="12993sadobistose";
        int mesalo=saom.kharabkon_babadametgarm();
        System.Console.WriteLine(mesalo);
        mesalo=saom.kharabkon_m(2);
        mesalo=mesalo.khar();

    }
}



/* ya emamzade saleh . khodaya in che chiz sakhtie . operator shoroo shod */

public class am
{
    public static int operator +(am s, int w)
    {
        System.Console.WriteLine("ee kar kard khoda ro shokr , albare sefr mide sar karid");
        return 0;
    }
}


public class complex
{
    public int x;
    public int y;
    public static complex operator +(complex s,complex w)
    {
        return new complex(s.x+w.x, s.y+w.y);

    }

    static public complex operator -(complex s, complex w)
    {
        return new complex(s.x-w.x, s.y-w.y);
    }

    static public complex operator -(complex s)
    {
        return new complex(-s.x,-s.y);
    }

    static public complex operator +(complex s)
    {
        return -new complex(s.x,s.y);
    }

    public complex(int x,int y)
    {
        this.x = x;
        this.y = y;
    }

    public int this[bool a]
    {
        get
        {
            if(a)
                return this.x;
            return this.y;
        }
        set
        {
            if(a)
                this.x = value;
            else
                this.y = value;
        }
    }
}



public static class stringkharabkon
{

    public static bool isdigit(char s)
    {
        List<char> adad=new List<char>{'1','2','3','4','5','6','7','8','9','0'};
        for(int i=0;i<adad.Count;i++)
        {
            if(s==adad[i])
                return true;
        }
        return false;

    }

    public static int khar(this int s)
    {
        return 0;
    }

    public static int kharabkon_babadametgarm(this string s)
    {
        int i=0 ; 
        int tedad=0;
        while(i<s.Length)
        {
            if(isdigit(s[i]))
                tedad++;
            i++;
        }
        return tedad;
    }

    public static int kharabkon_m(this string s , int abx)
    {
        int i=0 ; 
        int tedad=0;
        while(i<s.Length)
        {
            if(isdigit(s[i]))
                tedad++;
            i++;
        }
        return tedad;
    }
}