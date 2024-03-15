using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;

namespace A6;
struct TypeOfSize1()
{
    char sa = 'a';
}

struct TypeOfSize5()
{
    TypeOfSize1 s1;
    TypeOfSize1 s2;
    TypeOfSize1 s3;
    TypeOfSize1 s4;
    TypeOfSize1 s5;
}

struct TypeOfSize22()
{
    TypeOfSize5 s1;
    TypeOfSize5 s2;
    TypeOfSize5 s3;
    TypeOfSize5 s4;
    TypeOfSize1 a1;
    TypeOfSize1 a2;
}

struct TypeOfSize125()
{
    TypeOfSize22 s1;
    TypeOfSize22 s2;
    TypeOfSize22 s3;
    TypeOfSize22 s4;
    TypeOfSize22 s5;
    TypeOfSize5 a1;
    TypeOfSize5 a2;
    TypeOfSize5 a3;
}

struct TypeOfSize256()
{
    TypeOfSize125 s1;
    TypeOfSize125 s2;
    TypeOfSize5 a2;
    TypeOfSize1 b1;

}

struct TypeOfSize512()
{
    TypeOfSize256 s1;
    TypeOfSize256 s2;
}

struct TypeOfSize1024()
{
    TypeOfSize512 a1;
    TypeOfSize512 a2;
}
struct TypeOfSize1024_4()
{
    TypeOfSize1024 a1;
    TypeOfSize1024 a2;
    TypeOfSize1024 a3;
    TypeOfSize1024 a4;
}

struct TypeOfSize1024_16()
{
    TypeOfSize1024_4 a1;
    TypeOfSize1024_4 a2;
    TypeOfSize1024_4 a3;
    TypeOfSize1024_4 a4;
}

struct TypeOfSize1024_64()
{
    TypeOfSize1024_16 a1;
    TypeOfSize1024_16 a2;
    TypeOfSize1024_16 a3;
    TypeOfSize1024_16 a4;
}

struct TypeOfSize32768()
{
    TypeOfSize1024_16 a1;
    TypeOfSize1024_16 a2;
}

class TypeOfSize7()
{
    TypeOfSize512 a1;
    TypeOfSize512 a2;
}

struct TypeOfSize1024_256()
{
    TypeOfSize1024_64 a1;
    TypeOfSize1024_64 a2;
    TypeOfSize1024_64 a3;
    TypeOfSize1024_64 a4;
}

struct TypeForMaxStackOfDepth10()
{
    TypeOfSize1024_4 a1;
    TypeOfSize1024_16 a2;
    TypeOfSize1024_16 a3;
    TypeOfSize1024_16 a4;
}

struct TypeForMaxStackOfDepth100()
{
    TypeOfSize1024_4 a4;
    TypeOfSize1024 a3;
    TypeOfSize1024 a5;
    TypeOfSize1024 a6;

}

struct TypeForMaxStackOfDepth3000()
{
    TypeOfSize125 a;
    TypeOfSize22 a1;
    TypeOfSize22 a2;
    TypeOfSize22 a3;
}

struct TypeForMaxStackOfDepth1000()
{
    TypeForMaxStackOfDepth3000 a1;
    TypeForMaxStackOfDepth3000 a2;
    TypeForMaxStackOfDepth3000 a3;
    TypeOfSize22 a4;
    TypeOfSize22 a5;
}

class TypeWithMemoryOnHeap
{
    List<TypeOfSize7> r=new List<TypeOfSize7>();
    public void Allocate()
    {   
        for(int i = 0 ; i<1_950;i++)
        {
            r.Add(new TypeOfSize7());
        }
    }

    public void DeAllocate()
    {
        GC.WaitForPendingFinalizers();
        r=null;
        GC.Collect();
        GC.WaitForPendingFinalizers();
    }
}

struct StructOrClass1()
{
    public int X=0;
}

class StructOrClass2()
{
    public int X=0;
}

class StructOrClass3()
{
    public StructOrClass2 X=null;
}

public enum FutureHusbandType
{
    HasBigNose=1,
    IsBald=2,
    IsShort=4,
}