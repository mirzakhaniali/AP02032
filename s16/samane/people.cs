using System.Collections;
using System.Diagnostics.Contracts;

public class poeple
{
    public int NId{ get; set; }
    public string Name{ get; set; } 
    public string LName{ get; set; }
    public int Yob{ get; set; }

    public poeple(int nId, string name,string lName,int yob)
    {
        NId = nId;
        Name = name;
        LName = lName;
        Yob = yob;
        System.Console.WriteLine("shod");
    }

    public void print()
    {
        System.Console.WriteLine($"{NId},{Name},{LName},{Yob}");
    }
}