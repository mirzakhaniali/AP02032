using System;
using System.Reflection.PortableExecutable;


public class karmand : person , chapgar
{
    public static int id=0;
    public int hoghoogh;
    public karmand(string fname,string lname,int yob,int hoghoogh)
    : base(id++,fname, lname, yob)
    {
        this.hoghoogh=hoghoogh;
    }

    public override void chap()
    {
        Console.ForegroundColor = ConsoleColor.Red;   
        System.Console.WriteLine($"{base.chapsaz()} , hoghoogh : {this.hoghoogh}");
    }
}