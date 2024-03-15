using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A6.Tests;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace A6;

public class Program
{
    private static int GetMaxRecursion<_Type>(int currentDepth, _Type bvt)
    {
        try
        {
            EnsureSufficientExecutionStack();
            return GetMaxRecursion(currentDepth + 1, bvt);
        }
        catch (InsufficientExecutionStackException) { }
        return currentDepth;
    }
    
    public static bool IdealHusband(FutureHusbandType a)
    {
        int barresi=0;
        int b=(int)a/4;
        if(b!=0)
        {
            barresi++;
        }
        b=(int)a%4;
        b=(int)b/2;
        if(b!=0)
        {
            barresi++;
        }
        b=(int)a%2;
        b=(int)b/1;
        if(b!=0)
        {
            barresi++;
        }
        if(barresi==2)
        {
            return true;
        }
        return false;
    }

    public static int GetObjectType(object o)
    {
        // throw NotImplementedException();
        string r=o as string;
        if(r!=null)
        {
            return 0;
        }
        int[] r1 = o as int[];
        if(r1!=null)
        {
            return 1;
        }
        return 2;
    }

}
