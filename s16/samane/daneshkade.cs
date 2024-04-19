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
        System.Console.WriteLine($"daneshkade {base.chapsaz()} ba asatide :");
        chapostad();
        System.Console.WriteLine("ba daneshjooyane : ");
        chapdaneshjoo();
        System.Console.WriteLine("ba karkonane : ");
        chapkarkonan();
        System.Console.WriteLine("ba tashakkol haye daneshjoyi : ");
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