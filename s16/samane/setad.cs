using System;

public class setad : ja , setadi 
{
    public List<karmand> karkonan{get;set;} = new List<karmand>();

    public setad(string name,person riasat,List<karmand> karmands)
    :base(name,riasat)
    {
        this.karkonan = karmands;
    }

    public void chap()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        System.Console.WriteLine($"name setad = {name} ");
        Console.ForegroundColor = ConsoleColor.White;
        System.Console.WriteLine($"riasat: {this.riasat.chapsaz()}");
        System.Console.WriteLine("va karkonan :");
        Console.ForegroundColor = ConsoleColor.Red;
        this.chapkarkonan();
    }

    public void chapkarkonan()
    {
        for (int i = 0; i < this.karkonan.Count;i++)
        {
            karkonan[i].chap();
        }
    }
}