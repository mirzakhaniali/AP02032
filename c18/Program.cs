using System.Security.Cryptography;

public class  main
{
    public static void Main(String[] args)
    {
        // System.Console.WriteLine("kelid ra vared konid");
        // string? voroodi = System.Console.ReadLine();
        // // int kelid1=0;
        // // if( voroodi != null )
        // // {
        // //     kelid1=int.Parse(voroodi);
        // // }
        // int kelid2 = 0;
        // System.Console.WriteLine("mikhahid ramzgozari kelii shavad ? 1=bale  0=na");
        // int bana=0;
        // voroodi=Console.ReadLine();
        // if( voroodi != null )
        //     bana=int.Parse(voroodi);
        // if(bana==1)
        // {
        //     kelid2=RandomNumberGenerator.GetInt32(200);
        //     System.Console.WriteLine(kelid2);
        //     int kelid1=0;
        //     if( voroodi != null )
        //     {
        //         System.Console.WriteLine("kelid ra vared konid");
        //         voroodi = System.Console.ReadLine();
        //         kelid1=int.Parse(voroodi);
        //     }
        // }
        System.Console.WriteLine("kelid ra vared konid");
        string? voroodi = System.Console.ReadLine();
        int kelid1=0;
        if( voroodi != null )
        {
            kelid1=int.Parse(voroodi);
        }
        System.Console.WriteLine("matn morede nazar ra vared konid ");
        voroodi = System.Console.ReadLine();
        if( voroodi != null )
            voroodi=voroodi.sezar(kelid1);
        else
        {
            voroodi=string.Empty.sezar(kelid1);
        }
        System.Console.WriteLine(voroodi);
    }
}