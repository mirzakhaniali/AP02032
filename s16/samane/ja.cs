using System;

public class ja : chapgar
{
    public string name{get; set;}
    public person riasat{get; set;}
    public ja(string name, person riasat)
    {
        this.name = name;
        this.riasat = riasat;
    }

    public ja(string name){ this.name = name; }

    public virtual void chap()
    {
        System.Console.WriteLine("tarif nashode");
    }

    public virtual string chapsaz()
    /* اینجا قبلش باید بنویسوید نام محل . */
    {
        return $" : {this.name} , name riasat : {this.riasat.fname} {this.riasat.lname}";
    }
}