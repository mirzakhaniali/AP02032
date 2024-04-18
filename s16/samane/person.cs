using System;


public class person : chapgar
{
    public int Id { get; set;}
    public string fname { get; set;}
    public string lname { get; set;}
    public int yob{ get; set;}
    public int age{ get
    {
        return DateTime.Now.Year-this.yob;
    }
    set
    {
        this.yob = DateTime.Now.Year-value;
    }}
    public person(int id, string fname, string lname,int yob)
    {
        this.Id = id;
        this.fname = fname;
        this.lname = lname;
        this.yob = yob;
    }

    public virtual void chap()
    {
        System.Console.WriteLine(this.chapsaz());
    }

    public virtual string chapsaz()
    {
        return $"name : {this.fname} {this.lname} , sen {this.age} , sale tavallod {this.yob} , shomare id {this.Id}";
    }
}