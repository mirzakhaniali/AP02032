using System;

public class setad : ja , setadi 
{
    public List<karmand> karkonan{get;set;}

    public setad(string name,person riasat,List<karmand> karmands)
    :base(name,riasat)
    {
        this.karkonan = karmands;
    }

    public void chap()
    {
        System.Console.WriteLine($"name setad = {name} , riasat: {this.riasat.chapsaz()} va karkonan :");
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