using System;

public class daneshkade : ja , chapgar , daneshkadei
{
    public List<ostad> asatid {get; set; } = new List<ostad>();
    public List<daneshjoo> daneshjoos {get; set;} = new List<daneshjoo>();
    public List<karmand> karkonan {get; set; } = new List<karmand>();
    public List<tashakkol> gorooh {get; set; } = new List<tashakkol>();

    public daneshkade(string nam, person riasat, List<ostad> ostads , List<daneshjoo> daneshjoos , List<karmand> karmands , List<tashakkol> setads)
    : base(nam, riasat)
    {
        this.asatid = ostads;
        this.karkonan=karmands;
        this.gorooh = setads;
        this.daneshjoos=daneshjoos;
    }

    public daneshkade(string nam, person riasat)
    : base(nam, riasat)
    {
    }

    public override void chap()
    {
        string[] chapi=base.chapsaz().Split(',');
        Console.ForegroundColor=ConsoleColor.Green;
        System.Console.WriteLine($"daneshkade {chapi[0]}");
        Console.ForegroundColor = ConsoleColor.White;
        System.Console.WriteLine($"{chapi[1]}");
        System.Console.WriteLine("ba asatide :");
        Console.ForegroundColor = ConsoleColor.Yellow;
        chapostad();
        System.Console.WriteLine("ba daneshjooyane : ");
        Console.ForegroundColor = ConsoleColor.Blue;
        chapdaneshjoo();
        System.Console.WriteLine("ba karkonane : ");
        Console.ForegroundColor = ConsoleColor.Red;
        chapkarkonan();
        System.Console.WriteLine("ba tashakkol haye daneshjoyi : ");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        chapgorooh();
    }

    public void chapgorooh()
    {
        for(int i=0;i<this.gorooh.Count;i++)
            this.gorooh[i].chap();
    }

    public void chapkarkonan()
    {
        for(int i=0;i<this.karkonan.Count;i++)
            this.karkonan[i].chap();
    }

    public void chapdaneshjoo()
    {
        for(int i=0;i<this.daneshjoos.Count;i++)
            this.daneshjoos[i].chap();
    }

    public void chapostad()
    {
        for(int i=0; i<asatid.Count;i++)
            this.asatid[i].chap();
    }
}