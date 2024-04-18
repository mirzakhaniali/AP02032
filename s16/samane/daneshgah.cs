using System.Collections;
using System.Diagnostics.Contracts;

public class university
{
    public string name{ get; set; }
    public string keshvar{ get; set; }
    public string riasat{ get; set; }
    public List<daneshkade> daneshkadeList{ get; set; }
    public List<modiriat> modiriats{ get; set; }

    public void ezafe(daneshkade a)
    {
        daneshkadeList.Add(a);
    }

    public void kam(daneshkade a)
    {
        if(daneshkadeList.FirstOrDefault(a) !=-1)
            daneshkadeList.Remove(a);
    }
    
    public void ezafe(modiriat a)
    {
        modiriats.Add(a);
    }

    public void kam(modiriat a)
    {
        if(modiriats.FirstOrDefault(a) !=-1)
            modiriats.Remove(a);
    }

    public void chap()
    {
        System.Console.WriteLine($"{name} nam riasat {riasat} ");
        for(int i = 0;i<daneshkadeList.Count;i++)
        {
            daneshkadeList[i].chap();
        }
        for(int i = 0;i<modiriats.Count;i++)
        {
            modiriats[i].chap();
        }
    }
    

}