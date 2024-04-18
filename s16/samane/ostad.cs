using System.Collections;
using System.Data.Common;
using System.Diagnostics.Contracts;


public class ostad : karmand , ostadi
{
    static private int Ido = 0;
    public int ido{ get; set; }
    public List<string> doroos {get; set;}

    public ostad(string name,string LName,int Yob,int hogoogh , List<string> doroos)
    : base(name, LName, Yob, hogoogh)
    {
        ostad.Ido++;
        this.ido = ostad.Ido;
        this.doroos = doroos;
    }

    public void Adddars(string doroos)
    {
        this.doroos.Add(doroos);
    }

    public void kamdars(string doroos)
    {
       /*  اینو گذاشتم که اگر بود کم کنه . اگر نبود خب چیزی رو نمیشه کم کرد که .  */
        if(this.doroos.Remove(doroos))
            this.doroos.Remove(doroos);
    }

    public void chapdoroos()
    {
        string sssss="";
        for(int i=0;i<this.doroos.Count;i++)
        {
            sssss+=this.doroos[i];
        }
        System.Console.WriteLine($"{sssss}");
    }

    public override void chap()
    {
        System.Console.WriteLine($"{base.chapsaz()} , hoghoogh : {hoghoogh} ");
    }
}

