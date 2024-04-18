using System.Collections;
using System.Diagnostics.Contracts;

public class daneshgah : ja , daneshgahi , chapgar
{
    public string keshvar{ get; set; }
    public List<daneshkade> daneshkadeList{ get; set; }
    public List<setad> setadha{ get; set; }

    public void ezafe(daneshkade a)
    {
        daneshkadeList.Add(a);
    }

    public void kam(daneshkade a)
    {
        if(daneshkadeList.Remove(a))
            daneshkadeList.Remove(a);
    }
    
    public void ezafe(setad a)
    {
        setadha.Add(a);
    }

    public void kam(setad a)
    {
        if(setadha.Remove(a))
            setadha.Remove(a);
    }

    public override void chap()
    {
        System.Console.WriteLine($"daneshgahe {name}, be riasat {riasat}");
        System.Console.WriteLine("ettelaate daneshkade ha :");
        for(int i = 0;i<daneshkadeList.Count;i++)
            this.daneshkadeList[i].chap();
        System.Console.WriteLine("ettelaate tashakkol ha :  ");
        for(int i = 0;i<setadha.Count;i++)
            this.setadha[i].chap();
    }

    public daneshgah(string nam,person riasat , string keshvar , List<daneshkade> danesh , List<setad> setads)
    : base(nam, riasat)
    {
        this.keshvar = keshvar;
        this.setadha = setads;
        this.daneshkadeList=danesh;
    }

}