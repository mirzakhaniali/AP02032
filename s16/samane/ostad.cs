using System.Collections;
using System.Diagnostics.Contracts;


public class teacher
{
    public int NId{ get; set;}
    public string Name{ get; set; }
    public string LName { get; set; }
    public int Yob { get; set; }

    public int TId { get; set; }
    public List<string> course {get; set;}=new List<string>();

    public teacher(int nId, string name,string LName,int Yob , int TId, List<string> course)
    {
        this.NId = nId;
        this.Name=name;
        this.LName = LName;
        this.Yob = Yob;
        this.TId = TId;
        this.course = course;
        System.Console.WriteLine("shod");
    }

    public void print()
    {
        System.Console.WriteLine($"{NId},{Name},{LName},{Yob},{TId},{course}");
    }
}

