using System;

public class tashakkol : ja, chapgar, tashakkoli    
{
    public daneshjoo dabir { get; set; }
    public List<daneshjoo> daneshjoos { get; set; }

    public tashakkol(string name_daneshgah , daneshjoo dabir , List<daneshjoo> daneshjoos)
    : base(name_daneshgah)
    {
        this.dabir = dabir;
        this.daneshjoos = daneshjoos;
    }

    public override void chap()
    {
        string sss=$"{name} be dabiri : {this.dabir.chapsaz()}";
        System.Console.WriteLine($" tashakkole daneshjooyie {sss} va daneshjoosye :");
        chapdaneshjoo();
    }

    public void chapdaneshjoo()
    {
        foreach(daneshjoo aaa in daneshjoos)
            aaa.chap();
    }


}