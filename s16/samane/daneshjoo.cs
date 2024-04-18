using System.Collections;
using System.Data;
using System.Diagnostics.Contracts;

public class daneshjoo: person , daneshjoi
{
    public static int id{get;set;}=0;
    public List<string> doroos {get; set;}
    public List<int> nomarat {get; set;}

    public daneshjoo(int nId, string name,string LName,int Yob , int TId, List<string> doroos , List<int> nomarat)
    : base(daneshjoo.id++,name,LName,Yob)
    {
        this.doroos = doroos;
        this.nomarat = nomarat;
        System.Console.WriteLine("shod");
    }

    public override void chap()
    {
        base.chap();
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

    public void Addnomre(int nomarat)
    {
        this.nomarat.Add(nomarat);
    }

    public void kamnomre(int nomarat)
    {
       /*  اینو گذاشتم که اگر بود کم کنه . اگر نبود خب چیزی رو نمیشه کم کرد که .  */
        if(this.nomarat.Remove(nomarat))
            this.nomarat.Remove(nomarat);
    }

    public void chapdoroos()
    {
        string sss="";
        for(int i = 0;i<this.doroos.Count;i++)
        {
            sss+=this.doroos[i]+",";
        }
        System.Console.WriteLine(sss);
    }

    public void chapnomarat()
    {
        string sss="";
        for(int i = 0;i<this.nomarat.Count;i++)
        {
            sss+=this.nomarat[i].ToString()+",";
        }
        System.Console.WriteLine(sss);
    }

    public double Average()
    {
        int nomre=0;
        int ii=0;
        while(ii<this.nomarat.Count)
        {
            nomre+=this.nomarat[ii];
            ii++;
        }
        return (double)((double)nomre/(double)ii);
    }

}