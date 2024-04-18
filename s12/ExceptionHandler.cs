using System;
using System.ComponentModel;
using System.IO;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace A7;

public class ExceptionHandler
{
    public string ErrorMsg { get; set; }
    public readonly bool DoNotThrow;
    private string _Input;

    public string Input
    {
        get
        {
            try
            {
                if (_Input.Length < 50)
                    return _Input;
                int a=this.Input.Length;
            }
            catch(NullReferenceException)
            {
                if(!DoNotThrow)
                    throw;
                ErrorMsg = "Caught exception in GetMethod";
            }
            return null;
        }
        set
        {
            try
            {
                if (value.Length < 50)
                    _Input = value;
                int a=value.Length;
            }
            catch
            {
                if (!DoNotThrow)
                    throw;
                ErrorMsg = "Caught exception in SetMethod";
            }
        }
    }


    public ExceptionHandler(
        string input,
        bool causeExceptionInConstructor,
        bool doNotThrow)
    {
        DoNotThrow = doNotThrow;
        this._Input = input;
        this.Input= input;
        try
        {
            if (causeExceptionInConstructor)
            {
                string test = null;
                if (test.Length > 0)
                    Console.WriteLine("test");
            }
        }
        catch
        {
            if (!DoNotThrow)
                throw;
            ErrorMsg = "Caught exception in constructor";
        }
    }
    
    public ExceptionHandler(
        string input,
        bool causeExceptionInConstructor)
    {
        this.Input=input;
        this.DoNotThrow=false;
        if(causeExceptionInConstructor)
        {
            try
            {
                string s=null;
                int a=s.Length;
            }
            catch(NullReferenceException)
            {
                Console.WriteLine(input);
                throw ;
            }
        }

    }

    static int Bbb=0;

    public void OverflowExceptionMethod()
    {
        Bbb++;
        try
        {    
            int b=int.Parse(this.Input);
            int k=b+1000;
            System.Console.WriteLine(b+"        "+Bbb.ToString());
        }
        catch(OverflowException)
        {
            System.Console.WriteLine("error dad"+this.Input);
            if(!DoNotThrow)
                throw;
            this.ErrorMsg=$"Caught exception {typeof(OverflowException)}";
        }
    }

    public void FormatExceptionMethod()
    {
        try
        {
            int i = int.Parse(Input);
        }
        catch(FormatException e)
        {
            if (!DoNotThrow)
                throw;
            ErrorMsg = $"Caught exception {e.GetType()}";
        }
    }

    public void FileNotFoundExceptionMethod()
    {
        try
        {
            if(this.Input!="10")
            {
                string[] str=File.ReadAllLines("estesmashes.paytakht2");
            }
        }
        catch(FileNotFoundException)
        {
            if(!DoNotThrow)
                throw;
            this.ErrorMsg=$"Caught exception {typeof(FileNotFoundException)}";
        }
    }

    public void IndexOutOfRangeExceptionMethod()
    {
        try
        {
            if(this.Input!="0")
            {
                string b=this.Input; 
                char a;
                a=b[5];
            }
        }
        catch(IndexOutOfRangeException)
        {
            if(!DoNotThrow)
                throw;
            this.ErrorMsg="Caught exception System.IndexOutOfRangeException";
        }
    }

    public void OutOfMemoryExceptionMethod()
    {
        try
        {
            int a=int.Parse(this.Input);
            List<int>[] b=new List<int>[a];
        }
        catch(OutOfMemoryException)
        {
            if(!DoNotThrow)
                throw;
            this.ErrorMsg=$"Caught exception {typeof(OutOfMemoryException)}";
        }
    }

    public void MultiExceptionMethod()
    {
        try
        {
            string ss=new string("a");
            int b=int.Parse(this.Input);
            List<int>[] sb=new List<int>[b];
            char s=ss[b];
        }
        catch(OutOfMemoryException)
        {
            if(!DoNotThrow)
            {
                this.ErrorMsg=$"Caught exception {typeof(OutOfMemoryException)}";
                throw;
            }
            this.ErrorMsg=$"Caught exception {typeof(OutOfMemoryException)}";
        }
        catch(IndexOutOfRangeException)
        {
            if(!DoNotThrow)
            {
                this.ErrorMsg=$"Caught exception {typeof(OutOfMemoryException)}";
                throw;
            }
            this.ErrorMsg=$"Caught exception {typeof(IndexOutOfRangeException)}";
        }
    }

    public static void ThrowIfOdd(int n)
    {
        if(n%2==1)
        {
            throw new InvalidDataException();
        }
        
    }

    public string FinallyBlockStringOut;

    public void FinallyBlockMethod(string s)
    {
        StringBuilder sb = new StringBuilder();
        StringWriter swr = new StringWriter(sb);
        try
        {
            swr.Write("InTryBlock:");
            int a=s.Length;
            if(s=="beautiful")
            {
                swr.Write("beautiful:9:DoneWriting");
            }
        }
        catch (NullReferenceException nre)
        {
            swr.Write(":Object reference not set to an instance of an object.");
            if(!DoNotThrow)
                throw;
        }
        finally
        {
            swr.Write(":InFinallyBlock");
            swr.Dispose();
            FinallyBlockStringOut = sb.ToString();
            
        }
        if(s=="ugly")
        {
            return ;
        }
        FinallyBlockStringOut += ":EndOfMethod";
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void NestedMethods()
    {
        MethodA();
    }

    static void MethodA()
    {
        MethodB();
    }

    static void MethodB()
    {
        MethodC();
    }

    static void MethodC()
    {
        MethodD();
    }

    static void MethodD()
    {
        throw new NotImplementedException();
    }
}

struct memory_kharab_kon()
{
    int a;
    int b;
    int c;
    int d;
    int k;
}

struct memory_kharab_kon2()
{
    memory_kharab_kon a;
    memory_kharab_kon b;
    memory_kharab_kon c;
    memory_kharab_kon d;
    memory_kharab_kon k1;
    memory_kharab_kon k2;
    memory_kharab_kon k3;
    memory_kharab_kon k4;
    memory_kharab_kon k5;
    memory_kharab_kon k;
}

struct memory_kharab_kon3()
{
    memory_kharab_kon2 a;
    memory_kharab_kon2 b;
    memory_kharab_kon2 c;
    memory_kharab_kon2 d;
    memory_kharab_kon2 k;
    memory_kharab_kon2 k1;
    memory_kharab_kon2 k2;
    memory_kharab_kon2 k3;
    memory_kharab_kon2 k4;
    memory_kharab_kon2 k5;
}

struct memory_kharab_kon4()
{
    memory_kharab_kon3 a;
    memory_kharab_kon3 b;
    memory_kharab_kon3 c;
    memory_kharab_kon3 d;
    memory_kharab_kon3 k;
    memory_kharab_kon3 k1;
    memory_kharab_kon3 k2;
    memory_kharab_kon3 k3;
    memory_kharab_kon3 k4;
    memory_kharab_kon3 k5;
}

struct memory_kharab_kon5()
{
    memory_kharab_kon4 a;
    memory_kharab_kon4 b;
    memory_kharab_kon4 c;
    memory_kharab_kon4 d;
    memory_kharab_kon4 k1;
    memory_kharab_kon4 k2;
    memory_kharab_kon4 k3;
    memory_kharab_kon4 k4;
    memory_kharab_kon4 k5;
    memory_kharab_kon4 k;
}

struct memory_kharab_kon6()
{
    memory_kharab_kon5 a;
    memory_kharab_kon5 b;
    memory_kharab_kon5 c;
    memory_kharab_kon5 d;
    memory_kharab_kon5 k1;
    memory_kharab_kon5 k2;
    memory_kharab_kon5 k3;
    memory_kharab_kon4 k4;
}
