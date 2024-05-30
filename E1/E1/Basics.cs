using System.Numerics;

namespace E1;

public partial class Basics
{
    #region TODO
    // Q0_Reverse
    // Q1_Reverse
    // Q2_Reverse
    // Q5_CalculateSum
    // Q6_TryCalculateSum
    #endregion

    public static void Q0_Reverse(int[] nums)
    {
        /* اینا هر دوش کار میکنه . رفتیم جلو کلین کدش کردم  */
        // if(nums.Length==0)
        //     return;
        // int[] ba_in_kar_mikonim=new int[nums.Length];
        // ba_in_kar_mikonim[0]=nums[0];
        // for (int i=1;i<ba_in_kar_mikonim.Length;i++)
        // {
        //     ba_in_kar_mikonim[i]=nums[nums.Length-i-1];
        // }
        // ba_in_kar_mikonim[nums.Length-1]=nums[nums.Length-1];
        // for (int i=1;i<nums.Length;i++)
        //     nums[i]=ba_in_kar_mikonim[i];


        Basics.Q2_Reverse<int>(nums);
    }

    public static int[] Q1_Reverse(int[] nums)
    {
        if(nums.Length==0)
            return nums;
        int[] ba_in_kar_mikonim=new int[nums.Length];
        ba_in_kar_mikonim[0]=nums[0];
        for (int i=1;i<ba_in_kar_mikonim.Length;i++)
        {
            ba_in_kar_mikonim[i]=nums[nums.Length-i-1];
        }
        ba_in_kar_mikonim[nums.Length-1]=nums[nums.Length-1];
        return ba_in_kar_mikonim;
    }

    public static void Q2_Reverse<T>(T[] nums)
    {
        if(nums.Length==0)
            return;
        T[] ba_in_kar_mikonim=new T[nums.Length];
        ba_in_kar_mikonim[0]=nums[0];
        for (int i=1;i<ba_in_kar_mikonim.Length;i++)
        {
            ba_in_kar_mikonim[i]=nums[nums.Length-i-1];
        }
        ba_in_kar_mikonim[nums.Length-1]=nums[nums.Length-1];
        for (int i=1;i<nums.Length;i++)
            nums[i]=ba_in_kar_mikonim[i];
    }

    public static List<int> adadkon(string voroodi)
    {
        try
        {
            var ss=voroodi.Split('+');
            if(ss.Contains(""))
                throw new InvalidDataException();
            List<int> ints=new List<int>();
            foreach(var k in ss)
                ints.Add(int.Parse(k));
            return ints;
        }
        catch(InvalidDataException ide)
        {
            throw ide;
        }
    }

    public static T amalgar<T>(List<T> values , Func<T,T,T> tabe) where T : INumber<T>
    {
        T a = values[0];
        for(int i=1;i<values.Count;i++)
            a=tabe(values[i],a);
        return a;
    }

    public static T jam<T>(T a , T b) where T : INumber<T> => a+b;
    
    public static int Q5_CalculateSum(string voroodi)
    {
        try
        {
            List<int> ints= Basics.adadkon(voroodi);
            return amalgar(ints , Basics.jam);

        }
        catch(FormatException)
        {
            throw new FormatException();
        }
            
    }

    public static bool Q6_TryCalculateSum(string voroodi1 , out int voroodi2)
    {
        try
        {
            voroodi2=Basics.Q5_CalculateSum(voroodi1);
            return true;
        }
        catch
        {
            voroodi2=0;
            return false;
        }
    }
}

#region TODO
// IHasAge
// Human
#endregion

public interface IHasAge
{
    int GetAge();
}

public class Human: IHasAge
{
    public string Name{get;set;}
    public int sen{get;set;}

    public Human(string nam,int _sen)
    {
        this.Name=nam;
        this.sen=_sen;
    }

    public int GetAge()
    {
        return this.sen;
    }
}
